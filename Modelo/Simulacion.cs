using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Final.Modelo
{
    class Simulacion
    {
        private int totalMinutos;
        private int minutoDesde;
        private int totalFilas;
        private DataTable tabla;
        private Random generadorRND;
        private RungeKutta rungeKutta;
        private double tiempoTirada;
        private int colaMaxima;
        private double esperaMaximaCola;
        private StringBuilder objetosTemporales;
        private List<Persona> personasDeslizandose;
        private List<Persona> personasEsperando;

        public void realizarSimulacion(int totalMinutos, int minutoDesde, int totalFilas, double limiteA, double limiteB, int tiempoEntreSuspensiones, int tiempoEntreLimpiezas, int duracionLimpieza)
        {
            this.totalMinutos = totalMinutos;
            this.minutoDesde = minutoDesde;
            this.totalFilas = totalFilas;
            crearTabla();
            this.generadorRND = new Random();
            this.rungeKutta = new RungeKutta();
            rungeKutta.integracionNumerica(); //calculo del tiempo de tirada (por unica vez)
            this.tiempoTirada = rungeKutta.Tiempo;
            this.objetosTemporales = new StringBuilder("");
            this.personasDeslizandose = new List<Persona> { };
            this.personasEsperando = new List<Persona> { };

            Fila fila = new Fila();
            Fila filaAnterior;

            double tiempoProximaPersonaATerminar;
            int indiceUltimaPersonaEnTerminar;
            double tiempoUltimaPersonaEnTerminar;
            string proximoEvento;
            int contadorLlegadas = 0;
            int contadorFilas = 1;

            //inicializacion
            fila.Evento = "inicializacion";
            fila.RndLlegada = Math.Truncate(100 * generadorRND.NextDouble()) / 100;
            fila.TiempoEntreLlegadas = Math.Truncate(100 * limiteA + fila.RndLlegada * (limiteB - limiteA)) / 100;
            fila.ProximaLlegada = fila.Reloj + fila.TiempoEntreLlegadas;
            fila.ProximaSuspension = fila.Reloj + tiempoEntreSuspensiones;
            fila.ProximaLimpieza = fila.Reloj + tiempoEntreLimpiezas;

            agregarFila(fila);
            filaAnterior = fila.copiarFila();

            while (fila.Reloj <= this.totalMinutos)
            {
                if (this.personasDeslizandose.Count == 0)
                    tiempoProximaPersonaATerminar = double.MaxValue;
                else
                    tiempoProximaPersonaATerminar = this.personasDeslizandose[0].FinTirada;

                if (this.personasDeslizandose.Count == 0)
                    indiceUltimaPersonaEnTerminar = -1;
                else
                    indiceUltimaPersonaEnTerminar = this.personasDeslizandose.Count - 1;

                //borrar el tiempo de espera en cola a cada persona que esta deslizandose (ya no lo necesito)
                if (filaAnterior.Evento == "fin_suspension" || filaAnterior.Evento == "fin_limpieza")
                {
                    for (int i = 0; i < this.personasDeslizandose.Count; i++)
                    {
                        this.personasDeslizandose[i].EsperaEnCola = -1;
                    }
                }

                proximoEvento = eventoProximo(filaAnterior.ProximaLlegada, tiempoProximaPersonaATerminar, filaAnterior.ProximaSuspension, filaAnterior.FinSuspension, filaAnterior.ProximaLimpieza, filaAnterior.FinLimpieza);

                switch (proximoEvento)
                {
                    case "llegada_persona":
                        contadorLlegadas++;
                        fila.Reloj = filaAnterior.ProximaLlegada;
                        fila.RndLlegada = Math.Truncate(100 * generadorRND.NextDouble()) / 100;
                        fila.TiempoEntreLlegadas = Math.Truncate(100 * limiteA + fila.RndLlegada * (limiteB - limiteA)) / 100;
                        fila.ProximaLlegada = fila.Reloj + fila.TiempoEntreLlegadas;

                        Persona persona;
                        if (!fila.AlfombraDisponible)
                        {
                            fila.Cola++;
                            if (fila.Cola >= filaAnterior.ColaMaxima)
                                fila.ColaMaxima = fila.Cola;
                            persona = new Persona(fila.Reloj, contadorLlegadas);
                            this.personasEsperando.Add(persona);
                        }
                        else
                        {
                            fila.TiempoTirada = this.tiempoTirada;
                            persona = new Persona(contadorLlegadas, fila.Reloj + fila.TiempoTirada);
                            this.personasDeslizandose.Add(persona); //actualizar lista de personas deslizandose
                            fila.FinTiradas.Append(armarStringTirada(persona));
                        }
                        this.objetosTemporales.Append(persona.armarStringPersona());
                        fila.Evento = "llegada_persona_" + persona.Id.ToString();
                        break;

                    case "fin_tirada":
                        fila.Evento = "fin_tirada_" + this.personasDeslizandose[0].Id.ToString();
                        fila.Reloj = tiempoProximaPersonaATerminar;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = 0;
                        fila.FinTiradas = fila.FinTiradas.Remove(0, 17);
                        this.objetosTemporales = this.objetosTemporales.Remove(0, 37);
                        this.personasDeslizandose[0].Destruido = true;
                        this.personasDeslizandose.RemoveAt(0); //eliminarlo de la lista de personas deslizandose

                        break;

                    case "suspension":
                        fila.Evento = "suspension";
                        fila.Reloj = filaAnterior.ProximaSuspension;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = 0;
                        fila.ProximaSuspension = fila.Reloj + tiempoEntreSuspensiones;

                        if (fila.ProximaSuspension == fila.ProximaLimpieza)
                            fila.ProximaSuspension = fila.ProximaSuspension + tiempoEntreSuspensiones;

                        
                        if (indiceUltimaPersonaEnTerminar == -1) // No hay personas deslizandose
                            tiempoUltimaPersonaEnTerminar = fila.Reloj;
                        else
                            tiempoUltimaPersonaEnTerminar = this.personasDeslizandose[indiceUltimaPersonaEnTerminar].FinTirada;

                        fila.FinSuspension = tiempoUltimaPersonaEnTerminar;
                        fila.AlfombraDisponible = false;
                        break;

                    case "fin_suspension":
                        fila.Evento = "fin_suspension";
                        fila.Reloj = filaAnterior.FinSuspension;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = this.tiempoTirada;

                        for (int i = 0; i < this.personasEsperando.Count; i++)
                        {
                            this.personasEsperando[i].Estado = "D";
                            this.personasEsperando[i].EsperaEnCola = Math.Truncate(100 * (fila.Reloj - this.personasEsperando[i].HoraLlegada)) / 100;
                            this.personasEsperando[i].HoraLlegada = -1;
                            this.personasEsperando[i].FinTirada = fila.Reloj + this.tiempoTirada;

                            if (this.personasEsperando[i].EsperaEnCola > fila.EsperaMaximaCola)
                                fila.EsperaMaximaCola = this.personasEsperando[i].EsperaEnCola;

                            fila.FinTiradas.Append(armarStringTirada(this.personasEsperando[i]));
                            this.objetosTemporales.Append(this.personasEsperando[i].armarStringPersona());
                            this.personasDeslizandose.Add(this.personasEsperando[i]);
                        }
                        this.personasEsperando.Clear();
                        fila.FinSuspension = double.MaxValue;
                        fila.AlfombraDisponible = true;
                        fila.Cola = 0;
                        break;

                    case "limpieza":
                        fila.Evento = "limpieza";
                        fila.Reloj = filaAnterior.ProximaLimpieza;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = 0;
                        fila.ProximaLimpieza = fila.Reloj + tiempoEntreLimpiezas;

                        if (indiceUltimaPersonaEnTerminar == -1) // No hay personas deslizandose
                            tiempoUltimaPersonaEnTerminar = fila.Reloj;
                        else
                            tiempoUltimaPersonaEnTerminar = this.personasDeslizandose[indiceUltimaPersonaEnTerminar].FinTirada;

                        fila.FinLimpieza = tiempoUltimaPersonaEnTerminar + duracionLimpieza;
                        fila.ProximaSuspension = fila.FinLimpieza + tiempoEntreSuspensiones; //se pospone la suspension

                        fila.AlfombraDisponible = false;
                        break;

                    case "fin_limpieza":
                        fila.Evento = "fin_limpieza";
                        fila.Reloj = filaAnterior.FinLimpieza;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = this.tiempoTirada;

                        this.objetosTemporales = this.objetosTemporales.Clear(); //reiniciamos la cadena para actualizar los estados

                        for (int i = 0; i < this.personasEsperando.Count; i++)
                        {
                            this.personasEsperando[i].Estado = "D";
                            this.personasEsperando[i].EsperaEnCola = Math.Truncate(100 * (fila.Reloj - this.personasEsperando[i].HoraLlegada)) / 100;
                            this.personasEsperando[i].HoraLlegada = -1;
                            
                            this.personasEsperando[i].FinTirada = fila.Reloj + this.tiempoTirada;

                            if (this.personasEsperando[i].EsperaEnCola > fila.EsperaMaximaCola)
                                fila.EsperaMaximaCola = this.personasEsperando[i].EsperaEnCola;

                            fila.FinTiradas.Append(armarStringTirada(this.personasEsperando[i]));
                            this.objetosTemporales.Append(this.personasEsperando[i].armarStringPersona());
                            this.personasDeslizandose.Add(this.personasEsperando[i]);
                        }
                        this.personasEsperando.Clear();

                        fila.FinLimpieza = double.MaxValue;
                        fila.AlfombraDisponible = true;
                        fila.Cola = 0;
                        break;

                    default:
                        break;
                }
                filaAnterior = fila.copiarFila();

                if (fila.Reloj >= this.minutoDesde && contadorFilas <= this.totalFilas)
                {
                    agregarFila(fila);
                    contadorFilas++;
                }
                
            }
            //metricas
            this.colaMaxima = fila.ColaMaxima;
            this.esperaMaximaCola = fila.EsperaMaximaCola;
        }

        private string eventoProximo(double proxLlegada, double tiempoProximaPersonaATerminar, double proxSuspension, double finSuspension, double proxLimpieza, double finLimpieza)
        {
            if (proxLlegada <= Math.Min(tiempoProximaPersonaATerminar, Math.Min(proxSuspension, Math.Min(finSuspension, Math.Min(proxLimpieza, finLimpieza))))) return "llegada_persona";
            else if (tiempoProximaPersonaATerminar <= Math.Min(proxSuspension, Math.Min(finSuspension, Math.Min(proxLimpieza, finLimpieza)))) return "fin_tirada";
            else if (proxSuspension <= Math.Min(finSuspension, Math.Min(proxLimpieza, finLimpieza))) return "suspension";
            else if (finSuspension <= Math.Min(proxLimpieza, finLimpieza)) return "fin_suspension";
            else if (proxLimpieza <= finLimpieza) return "limpieza";
            else return "fin_limpieza";
        }

        private void agregarFila(Fila fila)
        {
            List<string> listaFila = new List<string> {
                fila.Evento,
                fila.Reloj.ToString(),
                beautify(fila.RndLlegada),
                beautify(fila.TiempoEntreLlegadas),
                beautify(fila.ProximaLlegada),
                beautify(fila.TiempoTirada),
                fila.FinTiradas.ToString(),
                beautify(fila.ProximaSuspension),
                beautify(fila.FinSuspension),
                beautify(fila.ProximaLimpieza),
                beautify(fila.FinLimpieza),
                fila.AlfombraDisponible? "Disponible" : "Suspendida",
                fila.Cola.ToString(),
                fila.ColaMaxima.ToString(),
                fila.EsperaMaximaCola.ToString()
            };

            listaFila.Add(this.objetosTemporales.ToString());
            this.tabla.Rows.Add(listaFila.ToArray());
        }

        private string armarStringTirada(Persona persona)
        {
            return ("(" + persona.Id + ") " + persona.FinTirada.ToString()).PadRight(17, ' ');
        }

        public int proximaPersonaATerminar()
        {
            if (this.personasDeslizandose.Count != 0)
                return 0;
            return -1;
        }

        public int ultimaPersonaEnTerminar()
        {
            int indice = this.personasDeslizandose.Count;
            if (indice != 0)
                return indice - 1;
            return -1;
        }

        private void crearTabla()
        {
            this.tabla = new DataTable();
            string[] columnas = {
                "Evento",
                "Reloj (minutos)",
                "RND Llegada",
                "Tiempo entre llegadas",
                "Próxima llegada",
                "Tiempo tirada",
                "Fin tiradas",
                "Próxima suspensión",
                "Fin suspensión",
                "Próxima limpieza",
                "Fin limpieza",
                "Estado Alfombra",
                "Cola Alfombra",
                "Cola máxima Alfombra",
                "Espera máxima en cola",
                "Personas - Estado|HoraLlegada|EsperaEnCola"
            };

            for (int i = 0; i < columnas.Length; i++)
            {
                this.tabla.Columns.Add(columnas[i]);
            }
        }

        private string beautify(double numero)
        {
            if (numero == 0 || numero == -1 || numero == double.MaxValue) return "";
            return numero.ToString();
        }

        public DataTable Tabla { get => tabla; set => tabla = value; }
        internal RungeKutta RungeKutta { get => rungeKutta; set => rungeKutta = value; }
        public int ColaMaxima { get => colaMaxima; set => colaMaxima = value; }
        public double EsperaMaximaCola { get => esperaMaximaCola; set => esperaMaximaCola = value; }
        public double TiempoTirada { get => tiempoTirada; set => tiempoTirada = value; }
    }

    internal class Fila
    {
        private String evento;
        private double reloj;
        private double rndLlegada;
        private double tiempoEntreLlegadas;
        private double proximaLlegada;
        private double tiempoTirada;
        private StringBuilder finTiradas;
        private double proximaSuspension;
        private double finSuspension;
        private double proximaLimpieza;
        private double finLimpieza;
        private bool alfombraDisponible;
        private int cola;
        private int colaMaxima;
        private double esperaMaximaCola;

        public Fila()
        {
            this.reloj = 0;
            this.finTiradas = new StringBuilder("");
            this.finSuspension = double.MaxValue;
            this.finLimpieza = double.MaxValue;
            this.alfombraDisponible = true;
            this.cola = 0;
            this.colaMaxima = 0;
            this.esperaMaximaCola = 0;
        }

        
        public Fila copiarFila()
        {
            Fila filaClon = (Fila)this.MemberwiseClone();
            return filaClon;
        }
        
        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegada { get => rndLlegada; set => rndLlegada = value; }
        public double TiempoEntreLlegadas { get => tiempoEntreLlegadas; set => tiempoEntreLlegadas = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }
        public double TiempoTirada { get => tiempoTirada; set => tiempoTirada = value; }
        public StringBuilder FinTiradas { get => finTiradas; set => finTiradas = value; }
        public double ProximaSuspension { get => proximaSuspension; set => proximaSuspension = value; }
        public double FinSuspension { get => finSuspension; set => finSuspension = value; }
        public double ProximaLimpieza { get => proximaLimpieza; set => proximaLimpieza = value; }
        public double FinLimpieza { get => finLimpieza; set => finLimpieza = value; }
        public bool AlfombraDisponible { get => alfombraDisponible; set => alfombraDisponible = value; }
        public int Cola { get => cola; set => cola = value; }
        public int ColaMaxima { get => colaMaxima; set => colaMaxima = value; }
        public double EsperaMaximaCola { get => esperaMaximaCola; set => esperaMaximaCola = value; }
    }
}

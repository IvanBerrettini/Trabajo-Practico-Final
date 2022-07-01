﻿using System;
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

        public void realizarSimulacion(int totalMinutos, int minutoDesde, int totalFilas, double limiteA, double limiteB, int tiempoEntreSuspensiones, int tiempoEntreLimpiezas, int duracionLimpieza)
        {
            this.totalMinutos = totalMinutos;
            this.minutoDesde = minutoDesde;
            this.totalFilas = totalFilas;
            crearTabla();
            this.generadorRND = new Random();
            this.rungeKutta = new RungeKutta();
            this.tiempoTirada = rungeKutta.integracionNumerica(); //calculo del tiempo de tirada (por unica vez)

            Fila fila = new Fila();
            Fila filaAnterior;

            int indiceProximaPersonaATerminar;
            double tiempoProximaPersonaATerminar;
            int indiceUltimaPersonaEnTerminar;
            double tiempoUltimaPersonaEnTerminar;
            string proximoEvento;
            int contadorLlegadas = 0;
            int contadorFilas = 1;

            //inicializacion
            fila.Evento = "inicializacion";
            fila.RndLlegada = generadorRND.NextDouble();
            //fila.RndLlegada = 0.95; //BORRAR
            fila.TiempoEntreLlegadas = limiteA + fila.RndLlegada * (limiteB - limiteA);
            fila.ProximaLlegada = fila.Reloj + fila.TiempoEntreLlegadas;
            //fila.ProximaSuspension = fila.Reloj + tiempoEntreSuspensiones;
            fila.ProximaSuspension = 5; //BORRAR
            fila.ProximaLimpieza = fila.Reloj + tiempoEntreLimpiezas;

            agregarFila(fila);
            filaAnterior = fila.copiarFila();

            //while (fila.Reloj <= totalMinutos)
            while (fila.Reloj <= this.totalMinutos)
            {
                indiceProximaPersonaATerminar = filaAnterior.proximaPersonaATerminar();
                if (indiceProximaPersonaATerminar == -1) // No hay personas deslizandose
                    tiempoProximaPersonaATerminar = double.MaxValue;
                else
                    tiempoProximaPersonaATerminar = filaAnterior.PersonasDeslizandose[indiceProximaPersonaATerminar].FinTirada;

                proximoEvento = eventoProximo(filaAnterior.ProximaLlegada, tiempoProximaPersonaATerminar, filaAnterior.ProximaSuspension, filaAnterior.FinSuspension, filaAnterior.ProximaLimpieza, filaAnterior.FinLimpieza);

                switch (proximoEvento)
                {
                    case "llegada_persona":
                        contadorLlegadas++;
                        fila.Reloj = filaAnterior.ProximaLlegada;
                        fila.RndLlegada = generadorRND.NextDouble();
                        //fila.RndLlegada = 0.12; //BORRAR
                        fila.TiempoEntreLlegadas = limiteA + fila.RndLlegada * (limiteB - limiteA);
                        fila.ProximaLlegada = fila.Reloj + fila.TiempoEntreLlegadas;

                        Persona persona;
                        if (fila.EstadoAlfombra == "Suspendida")
                        {
                            fila.Cola++;
                            persona = new Persona(fila.Reloj, contadorLlegadas);
                            fila.Personas.Add(persona);
                        }
                        else
                        {
                            fila.TiempoTirada = this.tiempoTirada;
                            persona = new Persona(contadorLlegadas, fila.Reloj + fila.TiempoTirada);
                            fila.Personas.Add(persona);
                            fila.PersonasDeslizandose.Add(persona); //actualizar lista de personas deslizandose
                            fila.FinTiradas = armarCadenaTiradas(fila.PersonasDeslizandose);
                        }
                        fila.Evento = "llegada_persona_" + persona.Id.ToString();
                        break;

                    case "fin_tirada":
                        fila.Evento = "fin_tirada_" + fila.PersonasDeslizandose[indiceProximaPersonaATerminar].Id.ToString();
                        fila.Reloj = tiempoProximaPersonaATerminar;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = 0;
                        fila.PersonasDeslizandose[indiceProximaPersonaATerminar].Estado = "XXXX";
                        fila.PersonasDeslizandose.RemoveAt(indiceProximaPersonaATerminar); //actualizar lista de personas deslizandose
                        fila.FinTiradas = armarCadenaTiradas(fila.PersonasDeslizandose);

                        break;

                    case "suspension":
                        fila.Evento = "suspension";
                        fila.Reloj = filaAnterior.ProximaSuspension;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;

                        fila.ProximaSuspension = fila.Reloj + tiempoEntreSuspensiones;

                        if (indiceProximaPersonaATerminar != -1)
                        {
                            fila.FinSuspension = tiempoProximaPersonaATerminar;
                        }
                        else
                        {
                            fila.FinSuspension = fila.Reloj;
                        }
                        fila.EstadoAlfombra = "Suspendida";

                        break;

                    case "fin_suspension":
                        fila.Evento = "fin_suspension";
                        fila.Reloj = filaAnterior.FinSuspension;
                        for (int i = 0; i < fila.Personas.Count; i++)
                        {
                            if (fila.Personas[i].Estado == "ET")
                            {
                                fila.PersonasDeslizandose.Add(fila.Personas[i]);
                                fila.Personas[i].Estado = "D";
                                fila.Personas[i].FinTirada = fila.Reloj + this.tiempoTirada;
                            }
                        }
                        fila.FinTiradas = armarCadenaTiradas(fila.PersonasDeslizandose);
                        fila.FinSuspension = double.MaxValue;
                        fila.EstadoAlfombra = "Disponible";
                        fila.Cola = 0;


                        break;

                    case "limpieza":
                        fila.Evento = "limpieza";
                        fila.Reloj = filaAnterior.ProximaLimpieza;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = 0;
                        fila.ProximaLimpieza = fila.Reloj + tiempoEntreLimpiezas;

                        indiceUltimaPersonaEnTerminar = filaAnterior.ultimaPersonaEnTerminar();
                        if (indiceUltimaPersonaEnTerminar == -1) // No hay personas deslizandose
                            tiempoUltimaPersonaEnTerminar = fila.Reloj;
                        else
                            tiempoUltimaPersonaEnTerminar = filaAnterior.PersonasDeslizandose[indiceUltimaPersonaEnTerminar].FinTirada;

                        fila.FinLimpieza = tiempoUltimaPersonaEnTerminar + duracionLimpieza;
                        fila.ProximaSuspension = fila.FinLimpieza + tiempoEntreSuspensiones; //si se encuentra en limpieza, se posponen la suspension

                        fila.EstadoAlfombra = "Suspendida";

                        break;

                    case "fin_limpieza":
                        fila.Evento = "fin_limpieza";
                        fila.Reloj = filaAnterior.FinLimpieza;
                        fila.RndLlegada = 0;
                        fila.TiempoEntreLlegadas = 0;
                        fila.TiempoTirada = this.tiempoTirada;
                        for (int i = 0; i < fila.Personas.Count; i++)
                        {
                            if (fila.Personas[i].Estado == "ET")
                            {
                                fila.PersonasDeslizandose.Add(fila.Personas[i]);
                                fila.Personas[i].Estado = "D";
                                fila.Personas[i].FinTirada = fila.Reloj + this.tiempoTirada;
                            }
                        }
                        fila.FinTiradas = armarCadenaTiradas(fila.PersonasDeslizandose);
                        fila.FinLimpieza = double.MaxValue;
                        fila.EstadoAlfombra = "Disponible";
                        fila.Cola = 0;


                        break;
                    default:
                        break;
                }
                filaAnterior = fila.copiarFila();

                if (fila.Reloj >= this.minutoDesde && contadorFilas <= this.totalFilas)
                {
                    agregarFila(fila, contadorLlegadas);
                    contadorFilas++;
                }
            }
        }

        private string eventoProximo(double proxLlegada, double tiempoProximaPersonaATerminar, double proxSuspension, double finSuspension, double proxLimpieza, double finLimpieza)
        {
            if (proxLlegada < Math.Min(tiempoProximaPersonaATerminar, Math.Min(proxSuspension, Math.Min(finSuspension, Math.Min(proxLimpieza, finLimpieza))))) return "llegada_persona";
            else if (tiempoProximaPersonaATerminar < Math.Min(proxSuspension, Math.Min(finSuspension, Math.Min(proxLimpieza, finLimpieza)))) return "fin_tirada";
            else if (proxSuspension < Math.Min(finSuspension, Math.Min(proxLimpieza, finLimpieza))) return "suspension";
            else if (finSuspension < Math.Min(proxLimpieza, finLimpieza)) return "fin_suspension";
            else if (proxLimpieza < finLimpieza) return "limpieza";
            else return "fin_limpieza";
        }

        private void agregarFila(Fila fila, int indice = -1)
        {
            List<string> listaFila = new List<string> {
                fila.Evento,
                (Math.Truncate(1000 * fila.Reloj) / 1000).ToString(),
                beautify(fila.RndLlegada),
                beautify(fila.TiempoEntreLlegadas),
                beautify(fila.ProximaLlegada),
                beautify(fila.TiempoTirada),
                fila.FinTiradas,
                beautify(fila.ProximaSuspension),
                beautify(fila.FinSuspension),
                beautify(fila.ProximaLimpieza),
                beautify(fila.FinLimpieza),
                fila.EstadoAlfombra,
                fila.Cola.ToString(),
                fila.ColaMaxima.ToString(),
                (Math.Truncate(1000 * fila.EsperaMaximaCola) / 1000).ToString()
            };

            if (indice != -1)
            {
                fila.PersonasMostrar.Add(fila.Personas[indice - 1]); //actualizar lista de personas para mostrar
            }
            
            if (fila.Evento.Contains("llegada_persona"))
            {
                this.tabla.Columns.Add("Persona " + indice.ToString() + " Estado|HoraLlegada|EsperaEnCola");
            }
            

            

            this.tabla.Rows.Add(listaFila.ToArray());
        }
        /*
        private List<string> armarListaPersonas(Fila fila)
        {
            if (fila.Reloj >= this.minutoDesde)
            {
                
                if (fila.Evento.Contains("llegada_persona"))
                {
                    this.tabla.Columns.Add("Persona " + indice.ToString() + " Estado|HoraLlegada|EsperaEnCola");
                }
                for (int i = 0; i < fila.Personas.Count; i++)
                {
                    listaFila.Add(fila.Personas[i].Estado + "|" +
                        beautify(fila.Personas[i].HoraLlegada) + "|" +
                        beautify(fila.Personas[i].EsperaEnCola)
                        );
                }
            }
            if ()
            {

            }
        }*/

        private string armarCadenaTiradas(List<Persona> personas)
        {
            string tiradas = "";
            for (int i = 0; i < personas.Count; i++)
            {
                tiradas += "(" + personas[i].Id + ") " + beautify(personas[i].FinTirada) + "     ";
            }
            return tiradas;
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
                "Espera máxima en cola"
            };

            for (int i = 0; i < columnas.Length; i++)
            {
                this.tabla.Columns.Add(columnas[i]);
            }
        }

        private string beautify(double numero)
        {
            if (numero == 0 || numero == -1 || numero == double.MaxValue) return "";
            return (Math.Truncate(1000 * numero) / 1000).ToString();
        }

        public DataTable Tabla { get => tabla; set => tabla = value; }
        internal RungeKutta RungeKutta { get => rungeKutta; set => rungeKutta = value; }
    }

    internal class Fila
    {
        private String evento;
        private double reloj;
        private double rndLlegada;
        private double tiempoEntreLlegadas;
        private double proximaLlegada;
        private double tiempoTirada;
        private string finTiradas;
        private double proximaSuspension;
        private double finSuspension;
        private double proximaLimpieza;
        private double finLimpieza;
        private string estadoAlfombra;
        private int cola;
        private int colaMaxima;
        private double esperaMaximaCola;
        private List<Persona> personas;
        private List<Persona> personasDeslizandose;
        private List<Persona> personasMostrar;

        public Fila()
        {
            this.reloj = 0;
            this.finTiradas = "";
            this.finSuspension = double.MaxValue;
            this.finLimpieza = double.MaxValue;
            this.estadoAlfombra = "Disponible";
            this.cola = 0;
            this.colaMaxima = 0;
            this.esperaMaximaCola = 0;
            this.personas = new List<Persona> {};
            this.personasDeslizandose = new List<Persona> { };
            this.personasMostrar = new List<Persona> { };
        }
        
        public int proximaPersonaATerminar()
        {
            int indice = -1;
            for (int i = 0; i < personasDeslizandose.Count; i++)
            {
                if (indice == -1)
                {
                    indice = 0;
                    continue;
                }
                if (personasDeslizandose[indice].FinTirada > personasDeslizandose[i].FinTirada)
                {
                    indice = i;
                }
            }
            return indice;
        }

        public int ultimaPersonaEnTerminar()
        {
            int indice = -1;
            for (int i = 0; i < personasDeslizandose.Count; i++)
            {
                if (indice == -1)
                {
                    indice = 0;
                    continue;
                }
                if (personasDeslizandose[indice].FinTirada < personasDeslizandose[i].FinTirada)
                {
                    indice = i;
                }
            }
            return indice;
        }

        public Fila copiarFila()
        {
            Fila filaClon = (Fila)this.MemberwiseClone();
            filaClon.personas = new List<Persona> { };
            for (int i = 0; i < this.personas.Count; i++)
            {
                Persona personaClon = new Persona(this.personas[i].Id, this.personas[i].Estado, this.personas[i].HoraLlegada, this.personas[i].EsperaEnCola, this.personas[i].FinTirada);
                filaClon.personas.Add(personaClon);
            }
            
            filaClon.personasDeslizandose = new List<Persona> { };
            for (int i = 0; i < this.personasDeslizandose.Count; i++)
            {
                Persona personaClon = new Persona(this.personasDeslizandose[i].Id, this.personasDeslizandose[i].Estado, this.personasDeslizandose[i].HoraLlegada, this.personasDeslizandose[i].EsperaEnCola, this.personasDeslizandose[i].FinTirada);
                filaClon.personasDeslizandose.Add(personaClon);
            }

            filaClon.personasMostrar = new List<Persona> { };
            for (int i = 0; i < this.personasMostrar.Count; i++)
            {
                Persona personaClon = new Persona(this.personasMostrar[i].Id, this.personasMostrar[i].Estado, this.personasMostrar[i].HoraLlegada, this.personasMostrar[i].EsperaEnCola, this.personasMostrar[i].FinTirada);
                filaClon.personasMostrar.Add(personaClon);
            }
            return filaClon;
        }

        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegada { get => rndLlegada; set => rndLlegada = value; }
        public double TiempoEntreLlegadas { get => tiempoEntreLlegadas; set => tiempoEntreLlegadas = value; }
        public double ProximaLlegada { get => proximaLlegada; set => proximaLlegada = value; }
        public double TiempoTirada { get => tiempoTirada; set => tiempoTirada = value; }
        public string FinTiradas { get => finTiradas; set => finTiradas = value; }
        public double ProximaSuspension { get => proximaSuspension; set => proximaSuspension = value; }
        public double FinSuspension { get => finSuspension; set => finSuspension = value; }
        public double ProximaLimpieza { get => proximaLimpieza; set => proximaLimpieza = value; }
        public double FinLimpieza { get => finLimpieza; set => finLimpieza = value; }
        public string EstadoAlfombra { get => estadoAlfombra; set => estadoAlfombra = value; }
        public int Cola { get => cola; set => cola = value; }
        public int ColaMaxima { get => colaMaxima; set => colaMaxima = value; }
        public double EsperaMaximaCola { get => esperaMaximaCola; set => esperaMaximaCola = value; }
        internal List<Persona> Personas { get => personas; set => personas = value; }
        internal List<Persona> PersonasDeslizandose { get => personasDeslizandose; set => personasDeslizandose = value; }
        internal List<Persona> PersonasMostrar { get => personasMostrar; set => personasMostrar = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Final.Modelo
{
    class Persona
    {
        private int id;
        private string estado;
        private double horaLlegada;
        private double esperaEnCola;
        private double finTirada;

        public Persona(int id, string estado, double horaLlegada, double esperaEnCola, double finTirada)
        {
            this.id = id;
            this.estado = estado;
            this.horaLlegada = horaLlegada;
            this.esperaEnCola = esperaEnCola;
            this.finTirada = finTirada;
        }

        public Persona(int id, double finTirada) //alfombra disponible, no hace cola
        {
            this.id = id;
            this.estado = "D";
            this.horaLlegada = -1;
            this.esperaEnCola = -1;
            this.finTirada = finTirada;
        }

        public Persona(double horaLlegada, int id) //alfombra suspendida, hace cola
        {
            this.id = id;
            this.estado = "ET";
            this.horaLlegada = horaLlegada;
            this.esperaEnCola = -1;
            this.finTirada = -1;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
        public double HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public double EsperaEnCola { get => esperaEnCola; set => esperaEnCola = value; }
        public double FinTirada { get => finTirada; set => finTirada = value; }
    }
}

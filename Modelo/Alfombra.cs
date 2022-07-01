using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Final.Modelo
{
    class Alfombra
    {
        private string estado;

        public Alfombra()
        {
            this.estado = "Disponible";
        }

        public Alfombra(String estado)
        {
            this.estado = estado;
        }

        public string Estado { get => estado; set => estado = value; }
    }
}

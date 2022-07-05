using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Final.Modelo
{
    class RungeKutta
    {
        private double h;
        private DataTable tabla;
        private double tiempo;
        private double longitud;

        public RungeKutta()
        {
            this.h = 0.01;
        }

        public void integracionNumerica()
        {
            Fila fila = new Fila();
            crearTabla();

            fila.TiempoSiguiente = 0;
            fila.VarDependienteSiguiente = 0; //X

            do
            {
                fila.Tiempo = fila.TiempoSiguiente;
                fila.VarDependiente = fila.VarDependienteSiguiente;
                fila.K1 = Math.Truncate(100000 * ecuacionDiferencial(fila.VarDependiente)) / 100000;
                fila.K2 = Math.Truncate(100000 * ecuacionDiferencial(fila.VarDependiente + h / 2 * fila.K1)) / 100000;
                fila.K3 = Math.Truncate(100000 * ecuacionDiferencial(fila.VarDependiente + h / 2 * fila.K2)) / 100000;
                fila.K4 = Math.Truncate(100000 * ecuacionDiferencial(fila.VarDependiente + h * fila.K3)) / 100000;
                fila.TiempoSiguiente = Math.Round(fila.Tiempo + h, 2);
                fila.VarDependienteSiguiente = Math.Truncate(100000 * (fila.VarDependiente + (h / 6) * (fila.K1 + 2 * fila.K2 + 2 * fila.K3 + fila.K4))) / 100000;

                agregarFilaTabla(fila);

            } while (fila.VarDependiente <= 100);

            this.tiempo = fila.Tiempo;
            this.longitud = fila.VarDependiente;
        }

        public double ecuacionDiferencial(double y)
        {
            return 0.5 * Math.Pow(y, 2) - 0.2 * y + 5;
        }

        private void crearTabla()
        {
            string[] columnas = new string[] { "t", "X", "K1", "K2", "K3", "K4", "t(i+1)", "X(t+i)" };
            this.tabla = new DataTable();
            
            for (int i = 0; i < columnas.Length; i++)
            {
                this.tabla.Columns.Add(columnas[i]);
            }
        }

        private void agregarFilaTabla(Fila fila)
        { 
            this.tabla.Rows.Add(fila.Tiempo, fila.VarDependiente, fila.K1, fila.K2, fila.K3, fila.K4, fila.TiempoSiguiente, fila.VarDependienteSiguiente);
        }

        public DataTable Tabla { get => tabla; set => tabla = value; }
        public double Tiempo { get => tiempo; set => tiempo = value; }
        public double Longitud { get => longitud; set => longitud = value; }

        internal class Fila
        {
            private double tiempo;
            private double varDependiente;
            private double k1;
            private double k2;
            private double k3;
            private double k4;
            private double tiempoSiguiente;
            private double varDependienteSiguiente;

            public double Tiempo { get => tiempo; set => tiempo = value; }
            public double VarDependiente { get => varDependiente; set => varDependiente = value; }
            public double K1 { get => k1; set => k1 = value; }
            public double K2 { get => k2; set => k2 = value; }
            public double K3 { get => k3; set => k3 = value; }
            public double K4 { get => k4; set => k4 = value; }
            public double TiempoSiguiente { get => tiempoSiguiente; set => tiempoSiguiente = value; }
            public double VarDependienteSiguiente { get => varDependienteSiguiente; set => varDependienteSiguiente = value; }
        }
    }
}

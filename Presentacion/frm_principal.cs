using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_Final.Presentacion
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private bool validarParametros()
        {
            if (nud_cant_simulaciones.Value == 0)
            {
                MessageBox.Show("La cantidad de simulaciones a generar debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_mostrar_desde.Value > nud_cant_simulaciones.Value)
            {
                MessageBox.Show("El minuto a partir del cual mostrar debe ser menor a la cantidad de minutos de simulación.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_b.Value <= nud_a.Value)
            {
                MessageBox.Show("Verifique el intervalo [A; B] correspondiente al tiempo entre llegadas de personas. 'B' debe ser mayor a 'A'.", "Generación de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_tiempo_entre_susp.Value == 0)
            {
                MessageBox.Show("El tiempo entre suspensiones debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_duracion_susp.Value == 0)
            {
                MessageBox.Show("El tiempo de duración de la suspensión debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            validarParametros();
        }
    }
}

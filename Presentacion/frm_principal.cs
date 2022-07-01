using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico_Final.Modelo;

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
            if (nud_total_minutos.Value == 0)
            {
                MessageBox.Show("La cantidad de simulaciones a generar debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_minuto_desde.Value > nud_total_minutos.Value)
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
            if (nud_duracion_limp.Value == 0)
            {
                MessageBox.Show("El tiempo de duración de la suspensión debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void numActive(object sender, EventArgs e)
        {
            NumericUpDown clickedNumeric = (NumericUpDown)sender;
            clickedNumeric.Select(0, clickedNumeric.Text.Length);
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            validarParametros();
            Simulacion simulacion = new Simulacion();
            simulacion.realizarSimulacion((int)nud_total_minutos.Value, (int)nud_minuto_desde.Value, (int)nud_total_filas.Value, (double)nud_a.Value, (double)nud_b.Value, (int)nud_tiempo_entre_susp.Value, (int)nud_tiempo_entre_limp.Value, (int)nud_duracion_limp.Value);
            dgv_simulacion.DataSource = simulacion.Tabla;
            dgv_simulacion.Columns[0].Frozen = true;
            dgv_simulacion.Columns[1].Frozen = true;

            /*
            for (int i = 0; i < dgv_simulacion.Rows.Count; i++)
            {
                dgv_simulacion.Rows[i].Cells[3].Style.BackColor = Color.Red;
            }
            */

        }
    }
}

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
                MessageBox.Show("Revise el intervalo [A; B] correspondiente al tiempo entre llegadas de personas. 'B' debe ser mayor a 'A'.", "Generación de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_tiempo_entre_susp.Value == 0)
            {
                MessageBox.Show("El tiempo entre suspensiones debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_tiempo_entre_limp.Value == 0)
            {
                MessageBox.Show("El tiempo entre limpiezas debe ser mayor a 0.", "Generación de Simulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nud_duracion_limp.Value >= nud_tiempo_entre_limp.Value)
            {
                MessageBox.Show("La duración de la limpieza debe ser menor al tiempo entre limpiezas.", "Generación de Valores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void activarParametros(bool activar)
        {
            nud_total_minutos.Enabled = activar;
            nud_minuto_desde.Enabled = activar;
            nud_total_filas.Enabled = activar;
            nud_a.Enabled = activar;
            nud_b.Enabled = activar;
            nud_tiempo_entre_susp.Enabled = activar;
            nud_tiempo_entre_limp.Enabled = activar;
            nud_duracion_limp.Enabled = activar;
            btn_generar.Enabled = activar;
            btn_restablecer.Enabled = !activar;
            gb_metricas.Visible = !activar;
            
            if (activar)
            {
                dgv_simulacion.Columns.Clear();
                tab_rk.Show();
                dgv_runge_kutta.Columns.Clear();
                lbl_longitud.Text = "-";
                lbl_tiempo.Text = "-";
            }
        }

        private void numActive(object sender, EventArgs e)
        {
            NumericUpDown clickedNumeric = (NumericUpDown)sender;
            clickedNumeric.Select(0, clickedNumeric.Text.Length);
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (validarParametros())
            {
                Simulacion simulacion = new Simulacion();
                simulacion.realizarSimulacion((int)nud_total_minutos.Value, (int)nud_minuto_desde.Value, (int)nud_total_filas.Value, (double)nud_a.Value, (double)nud_b.Value, (int)nud_tiempo_entre_susp.Value, (int)nud_tiempo_entre_limp.Value, (int)nud_duracion_limp.Value);
                dgv_simulacion.DataSource = simulacion.Tabla;
                activarParametros(false);

                //metricas
                lbl_cola_max.Text = simulacion.ColaMaxima.ToString();
                lbl_espera_max.Text = (Math.Truncate(1000 * simulacion.EsperaMaximaCola) / 1000).ToString() + " min";

                //tabla runge kutta
                dgv_runge_kutta.DataSource = simulacion.RungeKutta.Tabla;
                lbl_longitud.Text = (Math.Truncate(100 * simulacion.RungeKutta.Longitud) / 100).ToString() + " mts";
                lbl_tiempo.Text = simulacion.TiempoTirada.ToString() + "  min";
                
                //formateo de tabla
                dgv_simulacion.Columns[0].Frozen = true;
                dgv_simulacion.Columns[1].Frozen = true;
                dgv_simulacion.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_simulacion.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv_simulacion.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_simulacion.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_simulacion.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                foreach (DataGridViewColumn dgvc in dgv_simulacion.Columns)
                    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

                tab_rk.Show();
                dgv_runge_kutta.Rows[dgv_runge_kutta.Rows.Count-1].Cells[0].Style.BackColor = Color.LightGreen;
                dgv_runge_kutta.Rows[dgv_runge_kutta.Rows.Count - 1].Cells[1].Style.BackColor = Color.LightGreen;

                /*
                //ajustar las columnas de personas de acuerdo al contenido
                for (int i = 15; i < dgv_simulacion.Columns.Count; i++)
                {
                    dgv_simulacion.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }*/
            }
        }

        private void btn_restablecer_Click(object sender, EventArgs e)
        {
            activarParametros(true);
        }
    }
}

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
    public partial class frm_pruebas : Form
    {
        public frm_pruebas()
        {
            InitializeComponent();
        }

        private void frm_pruebas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RungeKutta rungeKutta = new RungeKutta();
            rungeKutta.integracionNumerica();
            dgv_runge_kutta.DataSource = rungeKutta.Tabla;
        }
    }
}

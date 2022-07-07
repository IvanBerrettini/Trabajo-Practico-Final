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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string palabra = "holas".PadRight(10, 'A');
            Console.WriteLine(palabra + "|");
            string palabra2 = "holas     ";
            Console.WriteLine(palabra2 + "|");
        }
    }
}

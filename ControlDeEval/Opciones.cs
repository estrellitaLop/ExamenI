using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeEval
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmControl promedio = new frmControl();
            promedio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmControl2 promedioProgramnacion = new frmControl2();
            promedioProgramnacion.ShowDialog();
           
        }

    }
}

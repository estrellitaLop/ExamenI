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
    public partial class frmControl2 : Form
    {
        public frmControl2()
        {
            InitializeComponent();
        }
        PromedioProgramacion prome = new();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar() == "")
            {


                prome.Nombre = txtNombre.Text;
                prome.Eval1 = double.Parse(txtEva1.Text);
                prome.Eval2 = double.Parse(txtEva2.Text);
                prome.Eval3 = double.Parse(txtEva3.Text);
                prome.NotaActi = double.Parse(txtActi.Text);



                ListViewItem fila = new ListViewItem(txtNombre.Text);

                fila.SubItems.Add(prome.Eval1.ToString("0.00"));
                fila.SubItems.Add(prome.Eval2.ToString("0.00"));
                fila.SubItems.Add(prome.Eval3.ToString("0.00"));
                fila.SubItems.Add(prome.NotaActi.ToString("0.00"));
                lstDetalle.Items.Add(fila);



                Limpiar();

            }
            else
            {
                MessageBox.Show(Validar(), "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void Limpiar()
        {
            
        }

        private string Validar()
        {
            throw new NotImplementedException();
        }
    }
}

using Modelo;
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
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }


       

        Promedio prome = new();

        private void btnRegistrar_Click(object sender, EventArgs e)
          {
            if(Validar() == "")
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
            txtNombre.Clear();
            txtEva1.Clear();
            txtEva2.Clear();
            txtEva3.Clear();
            txtActi.Clear();
        }

        private string Validar()
        {

            if (txtNombre.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
       
            else if (double.Parse(txtEva1.Text) < 0 || double.Parse(txtEva1.Text) > 25)
            {
                return "La nota no puede ser menor a 0 o mayor a 25";
            }
            else if (double.Parse(txtEva2.Text) < 0 || double.Parse(txtEva2.Text) > 25)
            {
                return "La nota no puede ser menor a 0 o mayor a 25";
            }
            else if (double.Parse(txtEva3.Text) < 0 || double.Parse(txtEva3.Text) > 25)
            {
                return "La nota no puede ser menor a 0 o mayor a 25";
            }
            else if (double.Parse(txtActi.Text) < 0 || double.Parse(txtActi.Text) > 25)
            {
                return "La nota no puede ser menor a 0 o mayor a 25";
            }




            return "";
        }
    }

        

      
    
}

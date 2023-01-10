using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana abierta, termine de trabajar allí...");
                    return;
                }
            }
            Form1 Ventana = new Form1();    //creamos un objeto
            Ventana.ShowDialog(); //mostramos la ventana creada en formato "dialogo". Si quiero ir a la ventana anterior y hacer clic no me deja
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                { 
                    MessageBox.Show("Ya existe una ventana abierta, termine de trabajar allí...");
                    return;
                }
            }


            Form1 Ventana = new Form1();
            Ventana.MdiParent = this; //para indicar que esta es la ventana padre. Tambien en propiedades le ponemos "ismdiConteiner"=true
            Ventana.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form       //la clase Form es propia del Framework, que te permite hacer la ventana con un par de características
    {
        public Form1()      //constructor de la clase
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HOLA MUNDO");
            string texto = txtNombre.Text;      //Lee el texto del obejto "caja de texto" y lo guarda en la variable texto
            lblSaludar.Text = "Hola " + texto;  //el objeto "lblSaludar" tiene get y set por lo que le concateno la salida

        }
    

      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Gracias por usar la app");
        }
    }
}

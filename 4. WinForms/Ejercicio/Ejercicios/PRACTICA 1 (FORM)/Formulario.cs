using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_1__FORM_
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau..Chau..");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Clic, Atención");
            //this.BackColor = Color.Blue;
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if(click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void lblNombre_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombre.BackColor = Color.Cyan;                      
            lblNombre.Cursor = Cursors.Hand;
        }

        private void lblNombre_MouseLeave(object sender, EventArgs e)
        {
            lblNombre.BackColor = System.Drawing.SystemColors.Control;
            lblNombre.Cursor = Cursors.Arrow;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNombre_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNombre.Text.Length + " Caracteres");
        }
    }
}

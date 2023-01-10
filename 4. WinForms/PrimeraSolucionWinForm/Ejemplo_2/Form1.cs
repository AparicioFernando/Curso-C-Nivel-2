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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem=txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre=txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario: es como un if en una sola linea. La estructura es: ? "": "". De esta manera no molesta con el tipo de dato
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtSquibs.Checked)
                tipo = "Squibs";
            else
                tipo = "Wizard";

            string colorFavorito=cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito=numNumeroFavorito.Value.ToString();

            MessageBox.Show("Nombre: " + nombre +" / Fecha Nacimiento" + fecha+ " / Chocolate: "+chocolate+ "/ Tipo: "+tipo+" / Color favorito: "+colorFavorito+ " / Numero Favorito: "+numeroFavorito);
        }

        private void lwElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }   
}

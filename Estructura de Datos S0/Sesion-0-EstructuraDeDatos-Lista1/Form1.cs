using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_Datos_VERANO
{
    public partial class Form1 : Form
    {
        Lista mylist = new Lista();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           listBoxDatos.Items.Clear();
            mylist.Insertar(int.Parse(txtNum.Text));
            mylist.Mostrar(listBoxDatos);
            txtNum.Clear();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listBoxDatos.Items.Clear();
            mylist.Eliminar(int.Parse(txtNum.Text));
            mylist.Mostrar(listBoxDatos);
            txtNum.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num = int.Parse(txtNum.Text);
            if (mylist.Buscar(num)== false)
            {
                MessageBox.Show($"El numero {num} no existe");
            }
            else
            {
                MessageBox.Show($"El numero {num} existe");
            }
            txtNum.Clear();
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            mylist.Ascendente();
            listBoxDatos.Items.Clear();
            mylist.Mostrar(listBoxDatos);
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            mylist.Descendente();
            listBoxDatos.Items.Clear();
            mylist.Mostrar(listBoxDatos);
        }
    }
}

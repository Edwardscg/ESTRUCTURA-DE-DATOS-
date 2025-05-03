using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion4_EstructuraDeDatos_ListaCircularDoble {
    public partial class Form1: Form {
        ListaDoble mylist = new ListaDoble();
        public Form1() {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender,EventArgs e) {
            mylist.Insertar(int.Parse(txtNum.Text));
            listBoxDatos.Items.Clear();
            mylist.Listar(listBoxDatos);
            txtNum.Clear();
        }

        private void btnBuscar_Click(object sender,EventArgs e) {

            int num = int.Parse(txtNum.Text);
            if(mylist.Buscar(num)!=null) {
                MessageBox.Show($"El numero {num} existe.");
            } else {
                MessageBox.Show($"El numero {num} no existe.");
            }
        }

        private void btnModificar_Click(object sender,EventArgs e) {
            mylist.Modificar(int.Parse(txtNum.Text), int.Parse(txtModificar.Text));
            listBoxDatos.Items.Clear();
            mylist.Listar(listBoxDatos);
            txtModificar.Clear();
            txtNum.Clear();
        }

        private void btnEliminar_Click(object sender,EventArgs e) {
            mylist.Eliminar(int.Parse(txtNum.Text));
            txtNum.Clear();
        }
    }
}

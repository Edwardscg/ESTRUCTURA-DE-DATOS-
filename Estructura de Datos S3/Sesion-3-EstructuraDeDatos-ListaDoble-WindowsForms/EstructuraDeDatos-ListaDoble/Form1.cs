using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_ListaDoble {
    public partial class Form1: Form {
        Lista list = new Lista();
        public Form1() {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender,EventArgs e) {
            list.Insertar(int.Parse(txtNum.Text));
            listBoxDatos.Items.Clear();
            list.Mostrar(listBoxDatos);
            txtNum.Clear();
        }

        private void btnBuscar_Click(object sender,EventArgs e) {
            list.Buscar(int.Parse(txtNum.Text));
            txtNum.Clear();
        }

        private void btnModificar_Click(object sender,EventArgs e) {
            list.Modificar(int.Parse(txtNum.Text), int.Parse(txtModificar.Text));
            listBoxDatos.Items.Clear();
            list.Mostrar(listBoxDatos);
            txtNum.Clear();
            txtModificar.Clear();
        }

        private void btnEliminar_Click(object sender,EventArgs e) {
            list.Eliminar(int.Parse(txtNum.Text));
            listBoxDatos.Items.Clear();
            list.Mostrar(listBoxDatos);
            txtNum.Clear();
        }
    }
}

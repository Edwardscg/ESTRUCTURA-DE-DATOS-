using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas {
    public partial class Form1: Form {
        Pila p = new Pila();
        public Form1() {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender,EventArgs e) {
            listBoxDatos.Items.Clear();
            p.Push(txtIngreso.Text);
            p.Mostrar(listBoxDatos);
        }

        private void btnDesapilar_Click(object sender,EventArgs e) {
            string nom = p.Pop();
            if (nom!=null) {
                MessageBox.Show("Desapilado: ", nom);
                listBoxDatos.Items.Clear();
                p.Mostrar(listBoxDatos);
            }
        }

        private void btnVistazo_Click(object sender,EventArgs e) {
            p.Peek();
            MessageBox.Show("Cima: " + p.Peek());
        }

        private void btnNumElemen_Click(object sender,EventArgs e) {
            MessageBox.Show("# ELEMENTOS: "+ p.Contar());
        }

        private void btnLimpiar_Click(object sender,EventArgs e) {
            p.Clear();
            listBoxDatos.Items.Clear();
        }
    }
}

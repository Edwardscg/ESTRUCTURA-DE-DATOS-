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

namespace Sesion_6_EstructuraDeDatos_Colas {
    public partial class Form1: Form {
        Cola micola = new Cola();
        int dato;
        public Form1() {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender,EventArgs e) {
            
            


            if (micola.ValidarTexto(txtInput.Text)) {
                micola.Enqueue(txtInput.Text.Trim());
                listBoxDatos.Items.Clear();
                micola.Mostrar(listBoxDatos);
            } else {
                MessageBox.Show("SOLO SE PERMITE TEXTO");
            }


                //int vrd = micola.ValidarTexto(dato);
                //if (vrd<=1) {
                //    micola.Enqueue(dato);
                //    listBoxDatos.Items.Clear();
                //    micola.Mostrar(listBoxDatos);
                //} else {
                //    MessageBox.Show("SOLO SE PERMITEN LETRAS");
                //}


                //foreach(char c in dato) {
                //    if (char.IsLetter(c)) {

                //        micola.Enqueue(dato);
                //        listBoxDatos.Items.Clear();
                //        micola.Mostrar(listBoxDatos);
                //        break;
                //    } else {
                //        MessageBox.Show("SOLO SE PERMITEN LETRAS");
                //    }
                //}


                //micola.Enqueue(txtInput.Text);
                //listBoxDatos.Items.Clear();
                //micola.Mostrar(listBoxDatos);
                txtInput.Clear();
        }

        private void btnDesencolar_Click(object sender,EventArgs e) {
            if (micola.Dequeue()!=null) {
                MessageBox.Show("DESAPILADO CORRECTAMENTE");
                listBoxDatos.Items.Clear();
                micola.Mostrar(listBoxDatos);

            } else {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
        }

        private void btnContarElementos_Click(object sender,EventArgs e) {
            dato=micola.Cont();
            MessageBox.Show($"HAY {dato} ELEMENTOS EN LA COLA");
        }

        private void btnDestruir_Click(object sender,EventArgs e) {
            micola.Destruir();
            listBoxDatos.Items.Clear();
            MessageBox.Show("LA COLA FUE ELIMINADA");
        }

        private void btnVistazo_Click(object sender,EventArgs e) {
            string prim = micola.Peek();
            if (prim!=null) {
                MessageBox.Show("Primero: " + prim);

            } else {
                MessageBox.Show("LA COLA ESTA VACIA");
            }
        }
    }
}

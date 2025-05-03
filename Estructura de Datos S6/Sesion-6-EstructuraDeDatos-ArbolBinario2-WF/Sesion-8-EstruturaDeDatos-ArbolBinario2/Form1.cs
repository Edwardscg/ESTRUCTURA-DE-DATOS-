using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_8_EstruturaDeDatos_ArbolBinario2 {
    public partial class Form1: Form {
        Arbol arb = new Arbol();
        Nodo raiz;
        public Form1() {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender,EventArgs e) {
            
            if(int.TryParse(txtInput.Text, out int num)) {

                if (raiz==null) {
                    raiz=arb.Insertar(null,num);
                } else {
                    arb.Insertar(raiz,num);
                }
                treeView1.Nodes.Clear();
                arb.Mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
            } else {
                MessageBox.Show("*** INGRESE UN NUMERO ENTERO VALIDO ***");
            }
            txtInput.Clear();
        }

        private void btnBuscar_Click(object sender,EventArgs e) {
            if(int.TryParse(txtInput.Text, out int num)) {
                if (arb.Buscar(raiz, num)!=null) {
                    MessageBox.Show($"*** EL NUMERO {num} EXISTE ***");
                } else {
                    MessageBox.Show($"*** EL NUMERO {num} NO EXISTE  ***");
                }
            } else {
                MessageBox.Show("*** INGRESE UN NUMERO ENTERO VALIDO ***");
            }
        }

        private void btnRecorrido_Click(object sender,EventArgs e) {
            if (raiz!=null) {
                txtPreOrden.Clear();
                txtInOrden.Clear();
                txtPostOrden.Clear();
                arb.PreOrden(raiz,txtPreOrden);
                arb.EnOrden(raiz,txtInOrden);
                arb.PostOrden(raiz,txtPostOrden);
            } else {
                MessageBox.Show("*** ARBOL VACIO ***");
            }
        }
    }
}

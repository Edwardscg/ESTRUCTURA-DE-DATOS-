using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_10_EstructuraDeDatos_ArbolBinario4 {
    public partial class Form1: Form {
        Arbol arb = new Arbol();
        Nodo raiz;
        public Form1() {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender,EventArgs e) {
            if(int.TryParse(txtInput.Text, out int num)){
                if (raiz==null) {
                    raiz=arb.Insertar(null,num);
                } else {
                    arb.Insertar(raiz,num);
                    
                }
                treeViewArbol.Nodes.Clear();
                arb.Mostrar(raiz, treeViewArbol, null);
                treeViewArbol.ExpandAll();
                txtInput.Clear();
            } else {
                MessageBox.Show("*** INGRESE EL VALOR CORRECTO ***");
            }
        }

        private void btnBuscar_Click(object sender,EventArgs e) {
            if (int.TryParse(txtInput.Text,out int num)) {
                int nivel = arb.BuscarNivel(raiz, num);

                if (nivel!=-1) {
                    MessageBox.Show($"EL NUMERO {num} ESTA EN EL NIVEL {nivel+1}");
                } else {
                    MessageBox.Show($"*** EL NUMERO {num} NO SE ENCUENTRA ***");
                }
            } else {
                MessageBox.Show("*** INGRESE EL VALOR CORRECTO ***");
            }

        }

        private void btnRecorrido_Click(object sender,EventArgs e) {
            txtPreOrden.Clear();
            txtInOrden.Clear();
            txtPostOrden.Clear();

            arb.Pre(raiz,txtPreOrden);
            arb.Ino(raiz,txtInOrden);
            arb.Post(raiz,txtPostOrden);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_7_EstructuraDeDatos_ArbolBinario {
    public partial class Form1: Form {
        Arbol a = new Arbol();
        Nodo raiz;
        Nodo seleccionado;
        public Form1() {
            InitializeComponent();
        }

        private void btnRaiz_Click(object sender,EventArgs e) {
            try {
                int num = int.Parse(txtInput.Text);
                if(num >=0 && num<=20) {
                    raiz=a.Insertar(null,int.Parse(txtInput.Text));
                    treeView1.Nodes.Clear();
                    a.Mostrar(raiz,treeView1,null);
                } else {
                    MessageBox.Show("*** SOLO SE PERMITEN NUMEROS ENTRE 1 - 20 ***");
                }
                txtInput.Clear();

            }
            catch(Exception ex) {
                MessageBox.Show("*** SOLO SE PERMITEN NUMEROS ENTEROS ***");
            }
        }

        private void btnRama_Click(object sender,EventArgs e) {
            if (raiz!=null) {

                if (int.TryParse(txtInput.Text,out int num)&&num>=0&&num<=20) {
                    if (rdbtnLeft.Checked==true||rdbtnRigth.Checked==true) {
                        if (seleccionado!=null) {


                            if (rdbtnLeft.Checked==true) {
                                seleccionado.izquierda=a.Insertar(seleccionado.izquierda,int.Parse(txtInput.Text));
                            }
                            if (rdbtnRigth.Checked==true) {
                                seleccionado.derecha=a.Insertar(seleccionado.derecha,int.Parse(txtInput.Text));
                            }

                            treeView1.Nodes.Clear();
                            a.Mostrar(raiz,treeView1,null);
                            treeView1.ExpandAll();
                            txtInput.Clear();
                            rdbtnLeft.Checked=false;
                            rdbtnRigth.Checked=false;
                        } else {
                            MessageBox.Show("*** SELECCIONE UN NODO ***");
                        }

                    } else {
                        MessageBox.Show("*** SELECCIONE IZQUIERDA O DERECHA ***");
                    }
                } else {
                    MessageBox.Show("*** SELECCIONE UN NODO ***");
                }
                
            } else {
                MessageBox.Show("*** PRIMERO INSERTE UNA RAIZ ***");
            }
        }

        private void treeView1_AfterSelect(object sender,TreeViewEventArgs e) {
            seleccionado=(Nodo)e.Node.Tag;
        }

        private void btnAltura_Click(object sender,EventArgs e) {
            int altura = a.Altura(raiz);
            MessageBox.Show($"*** Altura: {altura} ***");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_13_EstructuraDeDatos_Floyd_WF {
    public partial class Form1: Form {
        Grafo g = new Grafo();
        public Form1() {
           
            InitializeComponent();
        }

        private void btnMatrizCosto_Click(object sender,EventArgs e) {
            richTextBox2.Clear();
            g.Insertar();
            g.ImprimirMatrizCosto(richTextBox2);
        }

        private void btnFloyd_Click(object sender,EventArgs e) {
            richTextBox1.Clear();
            g.ImprimirFloydMarshall(richTextBox1);

        }
    }
}

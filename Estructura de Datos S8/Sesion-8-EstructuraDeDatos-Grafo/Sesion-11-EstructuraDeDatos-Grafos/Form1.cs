using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_11_EstructuraDeDatos_Grafos {
    public partial class Form1: Form {
        Grafo g = new Grafo();
        public Form1() {
            InitializeComponent();
        }

        private void btnMaAd_Click(object sender,EventArgs e) {
            richTextBoxDatos.Clear();
            g.Insertar();
            g.ImprimirMatriz(richTextBoxDatos);
        }

        private void btnAmplitud_Click(object sender,EventArgs e) {
            txtAmplitud.Clear();
            g.BSF(txtAmplitud);
        }

        private void btnProfundidad_Click(object sender,EventArgs e) {
            txtProfundidad.Clear();
            g.DFS(txtProfundidad);
        }

        private void btnOrdCro_Click(object sender,EventArgs e) {
            txtOrdTop.Clear();
            g.OrdenTopo(txtOrdTop);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_11_EstructuraDeDatos_Grafos {
    internal class Grafo {
        private int[,] matrizAdyacencia;
     
        public Grafo() {
            matrizAdyacencia=new int[7,7];
        }

        public void Insertar() {
            matrizAdyacencia[0,1]= 1;
            matrizAdyacencia[0,2]=1;
            matrizAdyacencia[0,3]=1;
            matrizAdyacencia[1,3]=1;
            matrizAdyacencia[1,4]=1;
            matrizAdyacencia[2,5]=1;
            matrizAdyacencia[3,5]=1;
            matrizAdyacencia[3,2]=1;
            matrizAdyacencia[3,6]=1;
            matrizAdyacencia[4,3]=1;
            matrizAdyacencia[4,6]=1;
            matrizAdyacencia[6,5]=1;
        }

        public void ImprimirMatriz(RichTextBox rich) {
            for(int i=0;i<7;i++) {
                for(int j = 0;j<7;j++) {
                    rich.Text+=matrizAdyacencia[i,j]+"\t";
                    
                }
                rich.Text+="\n";
            } 
        }

        public void BSF (TextBox text) {
            int nodoInicio = 0;
            bool[] vistado = new bool[7];
            Queue<int> cola = new Queue<int>();


            vistado[nodoInicio]=true;
            cola.Enqueue(nodoInicio);

            while (cola.Count()!=0) {
                int nodoActual = cola.Dequeue();
                text.Text+=nodoActual+" ";

                for(int i=0;i<7;i++) {
                    if (matrizAdyacencia[nodoActual,i]==1 && !vistado[i]) {
                        vistado[i]=true;
                        cola.Enqueue(i);
                    }
                }
            }
        }

        public void DFS(TextBox text) {
            int nodoInicio = 0;
            bool[] vistado = new bool[7];
            Stack<int> pila = new Stack<int>();

            pila.Push(nodoInicio);

            while(pila.Count()!=0) {
                int nodoActual = pila.Pop();

                if (!vistado[nodoActual]) {
                    vistado[nodoActual]=true;
                    text.Text+=nodoActual+" ";

                    for (int i=6;i>=0;i--) {
                        if (matrizAdyacencia[nodoActual,i]==1&&!vistado[i]) {
                            pila.Push(i);
                        }
                    }
                }
            }
        }

        public void DFS2(int nodo, bool[] visitado, Stack<int> pila) {
            visitado[nodo]=true;

            for(int i = 0;i<7;i++) {
                if (matrizAdyacencia[nodo,i]==1&&!visitado[i]) {
                    DFS2(i, visitado, pila);
                }
            }
            pila.Push(nodo);
        }


        public void OrdenTopo(TextBox text) {
            Stack<int> pila = new Stack<int>();
            bool[] vistado = new bool[7];

            for (int i=0;i<7;i++) {
                if (!vistado[i]) {
                    DFS2(i,vistado,pila);
                }
            }

            while (pila.Count!=0) {
                text.Text+=pila.Pop()+" ";
            }
        }
    }
}

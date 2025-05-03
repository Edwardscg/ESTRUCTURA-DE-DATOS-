using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_13_EstructuraDeDatos_Floyd_WF {
    internal class Grafo {
        private int[,] matrizCosto;
        private int numVertices;

        public Grafo() {
            numVertices=5;
            matrizCosto=new int[numVertices,numVertices];
        }

        public void Insertar() {
            matrizCosto[0,1]=5;
            matrizCosto[0,2]=3;
            matrizCosto[1,3]=8;
            matrizCosto[3,4]=2;
            matrizCosto[2,4]=4;
            matrizCosto[1,4]=10;
        }

        public void ImprimirMatrizCosto(RichTextBox rich) {
            for(int i=0; i<numVertices;i++) {
                for(int j=0;j<numVertices;j++) {
                    rich.Text+=matrizCosto[i,j]+"\t";
                }
                rich.Text+="\n";
            }
        }

        public void ImprimirFloydMarshall(RichTextBox rich) {
            int[,] matrizFloyd = new int[numVertices,numVertices];

            for(int i = 0;i<numVertices;i++) {
                for (int j=0;j<numVertices;j++) {
                    if (matrizCosto[i,j]!=0) {
                        matrizFloyd[i,j] = matrizCosto[i,j];
                    } else if (i==j){
                        matrizFloyd[i,j] = 0;
                    } else {
                        matrizFloyd[i,j] = int.MaxValue;
                    }
                }    
            }

            for (int k = 0;k<numVertices;k++) {
                for (int i = 0;i<numVertices;i++) {
                    for (int j = 0;j<numVertices;j++) {
                        if (matrizFloyd[i,k]!=int.MaxValue&&matrizFloyd[k,j]!=int.MaxValue) {
                            int nuevoCosto = matrizFloyd[i,k]+matrizCosto[k,j];

                            if (nuevoCosto<matrizFloyd[i,j]) {
                                matrizFloyd[i,j]=nuevoCosto;
                            }
                        }
                    }
                }
            }


            for (int i = 0;i<numVertices;i++) {
                for (int j = 0;j<numVertices;j++) {
                    if (matrizFloyd[i,j]==int.MaxValue) {
                        rich.Text+="∞"+"\t";
                    } else {
                        rich.Text+=matrizFloyd[i,j]+"\t";
                    }
                    
                }
                rich.Text+="\n";
            }
        }

        

    }
}

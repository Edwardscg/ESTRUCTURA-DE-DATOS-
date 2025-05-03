namespace Sesion_9_EstructuraDeDatos_ArbolBinario3 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNmAXIMO = new System.Windows.Forms.Button();
            this.BTNmINIMO = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.treeViewArbol = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(63, 195);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(153, 56);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARBOL BINARIO DE BUSQUEDA";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(294, 112);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(213, 33);
            this.txtInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "INGRESAR NUMERO:";
            // 
            // BTNmAXIMO
            // 
            this.BTNmAXIMO.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmAXIMO.Location = new System.Drawing.Point(63, 489);
            this.BTNmAXIMO.Name = "BTNmAXIMO";
            this.BTNmAXIMO.Size = new System.Drawing.Size(153, 56);
            this.BTNmAXIMO.TabIndex = 4;
            this.BTNmAXIMO.Text = "Maximo";
            this.BTNmAXIMO.UseVisualStyleBackColor = true;
            this.BTNmAXIMO.Click += new System.EventHandler(this.BTNmAXIMO_Click);
            // 
            // BTNmINIMO
            // 
            this.BTNmINIMO.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmINIMO.Location = new System.Drawing.Point(63, 388);
            this.BTNmINIMO.Name = "BTNmINIMO";
            this.BTNmINIMO.Size = new System.Drawing.Size(153, 56);
            this.BTNmINIMO.TabIndex = 5;
            this.BTNmINIMO.Text = "Minimo";
            this.BTNmINIMO.UseVisualStyleBackColor = true;
            this.BTNmINIMO.Click += new System.EventHandler(this.BTNmINIMO_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(63, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 56);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // treeViewArbol
            // 
            this.treeViewArbol.Location = new System.Drawing.Point(261, 195);
            this.treeViewArbol.Name = "treeViewArbol";
            this.treeViewArbol.Size = new System.Drawing.Size(373, 440);
            this.treeViewArbol.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 687);
            this.Controls.Add(this.treeViewArbol);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BTNmINIMO);
            this.Controls.Add(this.BTNmAXIMO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNmAXIMO;
        private System.Windows.Forms.Button BTNmINIMO;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TreeView treeViewArbol;
    }
}


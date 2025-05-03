namespace Sesion_10_EstructuraDeDatos_ArbolBinario4 {
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
            this.txtPreOrden = new System.Windows.Forms.TextBox();
            this.treeViewArbol = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostOrden = new System.Windows.Forms.TextBox();
            this.txtInOrden = new System.Windows.Forms.TextBox();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(70, 184);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(142, 52);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARBOL BINARIO DE BUSQUEDA";
            // 
            // txtPreOrden
            // 
            this.txtPreOrden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreOrden.Location = new System.Drawing.Point(290, 687);
            this.txtPreOrden.Name = "txtPreOrden";
            this.txtPreOrden.Size = new System.Drawing.Size(249, 33);
            this.txtPreOrden.TabIndex = 2;
            // 
            // treeViewArbol
            // 
            this.treeViewArbol.Location = new System.Drawing.Point(264, 194);
            this.treeViewArbol.Name = "treeViewArbol";
            this.treeViewArbol.Size = new System.Drawing.Size(347, 401);
            this.treeViewArbol.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 684);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pre Orden:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "In Orden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 756);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Post Orden:";
            // 
            // txtPostOrden
            // 
            this.txtPostOrden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostOrden.Location = new System.Drawing.Point(290, 759);
            this.txtPostOrden.Name = "txtPostOrden";
            this.txtPostOrden.Size = new System.Drawing.Size(249, 33);
            this.txtPostOrden.TabIndex = 8;
            // 
            // txtInOrden
            // 
            this.txtInOrden.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInOrden.Location = new System.Drawing.Point(290, 723);
            this.txtInOrden.Name = "txtInOrden";
            this.txtInOrden.Size = new System.Drawing.Size(249, 33);
            this.txtInOrden.TabIndex = 9;
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(70, 543);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(142, 52);
            this.btnAltura.TabIndex = 10;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            // 
            // btnMaximo
            // 
            this.btnMaximo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximo.Location = new System.Drawing.Point(70, 472);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(142, 52);
            this.btnMaximo.TabIndex = 11;
            this.btnMaximo.Text = "Maximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            // 
            // btnMinimo
            // 
            this.btnMinimo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimo.Location = new System.Drawing.Point(70, 403);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(142, 52);
            this.btnMinimo.TabIndex = 12;
            this.btnMinimo.Text = "Minimo";
            this.btnMinimo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(70, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 52);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(70, 261);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(142, 52);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(274, 107);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(249, 33);
            this.txtInput.TabIndex = 15;
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrido.Location = new System.Drawing.Point(70, 614);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(142, 52);
            this.btnRecorrido.TabIndex = 16;
            this.btnRecorrido.Text = "Recorrido";
            this.btnRecorrido.UseVisualStyleBackColor = true;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 824);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnMinimo);
            this.Controls.Add(this.btnMaximo);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.txtInOrden);
            this.Controls.Add(this.txtPostOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewArbol);
            this.Controls.Add(this.txtPreOrden);
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
        private System.Windows.Forms.TextBox txtPreOrden;
        private System.Windows.Forms.TreeView treeViewArbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostOrden;
        private System.Windows.Forms.TextBox txtInOrden;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnRecorrido;
    }
}


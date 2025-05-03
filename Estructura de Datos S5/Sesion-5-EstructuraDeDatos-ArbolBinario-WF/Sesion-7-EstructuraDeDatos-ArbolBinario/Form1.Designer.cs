namespace Sesion_7_EstructuraDeDatos_ArbolBinario {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnRama = new System.Windows.Forms.Button();
            this.rdbtnRigth = new System.Windows.Forms.RadioButton();
            this.rdbtnLeft = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbol Binario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Numero:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(272, 191);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(360, 468);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(217, 126);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(230, 20);
            this.txtInput.TabIndex = 3;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(44, 191);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(166, 55);
            this.btnRaiz.TabIndex = 4;
            this.btnRaiz.Text = "Insertar Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(44, 517);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(166, 55);
            this.btnAltura.TabIndex = 5;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnRama
            // 
            this.btnRama.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRama.Location = new System.Drawing.Point(44, 280);
            this.btnRama.Name = "btnRama";
            this.btnRama.Size = new System.Drawing.Size(166, 55);
            this.btnRama.TabIndex = 6;
            this.btnRama.Text = "Insertar Rama";
            this.btnRama.UseVisualStyleBackColor = true;
            this.btnRama.Click += new System.EventHandler(this.btnRama_Click);
            // 
            // rdbtnRigth
            // 
            this.rdbtnRigth.AutoSize = true;
            this.rdbtnRigth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnRigth.Location = new System.Drawing.Point(67, 381);
            this.rdbtnRigth.Name = "rdbtnRigth";
            this.rdbtnRigth.Size = new System.Drawing.Size(119, 28);
            this.rdbtnRigth.TabIndex = 7;
            this.rdbtnRigth.TabStop = true;
            this.rdbtnRigth.Text = "Derecha";
            this.rdbtnRigth.UseVisualStyleBackColor = true;
            // 
            // rdbtnLeft
            // 
            this.rdbtnLeft.AutoSize = true;
            this.rdbtnLeft.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLeft.Location = new System.Drawing.Point(67, 439);
            this.rdbtnLeft.Name = "rdbtnLeft";
            this.rdbtnLeft.Size = new System.Drawing.Size(120, 28);
            this.rdbtnLeft.TabIndex = 8;
            this.rdbtnLeft.TabStop = true;
            this.rdbtnLeft.Text = "Izquierda";
            this.rdbtnLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 705);
            this.Controls.Add(this.rdbtnLeft);
            this.Controls.Add(this.rdbtnRigth);
            this.Controls.Add(this.btnRama);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnRama;
        private System.Windows.Forms.RadioButton rdbtnRigth;
        private System.Windows.Forms.RadioButton rdbtnLeft;
    }
}


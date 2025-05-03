namespace Sesion_11_EstructuraDeDatos_Grafos {
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
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDatos = new System.Windows.Forms.RichTextBox();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.btnOrdCro = new System.Windows.Forms.Button();
            this.txtAmplitud = new System.Windows.Forms.TextBox();
            this.txtOrdTop = new System.Windows.Forms.TextBox();
            this.txtProfundidad = new System.Windows.Forms.TextBox();
            this.btnMaAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmplitud.Location = new System.Drawing.Point(12, 516);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(271, 39);
            this.btnAmplitud.TabIndex = 0;
            this.btnAmplitud.Text = "BFS - AMPLITUD:";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // richTextBoxDatos
            // 
            this.richTextBoxDatos.Location = new System.Drawing.Point(40, 149);
            this.richTextBoxDatos.Name = "richTextBoxDatos";
            this.richTextBoxDatos.Size = new System.Drawing.Size(677, 338);
            this.richTextBoxDatos.TabIndex = 2;
            this.richTextBoxDatos.Text = "";
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidad.Location = new System.Drawing.Point(12, 583);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(271, 39);
            this.btnProfundidad.TabIndex = 4;
            this.btnProfundidad.Text = "DFS - PROFUNDIDAD:";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // btnOrdCro
            // 
            this.btnOrdCro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdCro.Location = new System.Drawing.Point(12, 648);
            this.btnOrdCro.Name = "btnOrdCro";
            this.btnOrdCro.Size = new System.Drawing.Size(271, 39);
            this.btnOrdCro.TabIndex = 5;
            this.btnOrdCro.Text = "ORDEN TOPOLOGICO:";
            this.btnOrdCro.UseVisualStyleBackColor = true;
            this.btnOrdCro.Click += new System.EventHandler(this.btnOrdCro_Click);
            // 
            // txtAmplitud
            // 
            this.txtAmplitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmplitud.Location = new System.Drawing.Point(294, 524);
            this.txtAmplitud.Name = "txtAmplitud";
            this.txtAmplitud.Size = new System.Drawing.Size(423, 31);
            this.txtAmplitud.TabIndex = 6;
            // 
            // txtOrdTop
            // 
            this.txtOrdTop.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdTop.Location = new System.Drawing.Point(294, 656);
            this.txtOrdTop.Name = "txtOrdTop";
            this.txtOrdTop.Size = new System.Drawing.Size(423, 31);
            this.txtOrdTop.TabIndex = 7;
            // 
            // txtProfundidad
            // 
            this.txtProfundidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfundidad.Location = new System.Drawing.Point(294, 591);
            this.txtProfundidad.Name = "txtProfundidad";
            this.txtProfundidad.Size = new System.Drawing.Size(423, 31);
            this.txtProfundidad.TabIndex = 8;
            // 
            // btnMaAd
            // 
            this.btnMaAd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaAd.Location = new System.Drawing.Point(249, 95);
            this.btnMaAd.Name = "btnMaAd";
            this.btnMaAd.Size = new System.Drawing.Size(271, 39);
            this.btnMaAd.TabIndex = 9;
            this.btnMaAd.Text = "MATRIZ DE ADYACENCIA";
            this.btnMaAd.UseVisualStyleBackColor = true;
            this.btnMaAd.Click += new System.EventHandler(this.btnMaAd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 711);
            this.Controls.Add(this.btnMaAd);
            this.Controls.Add(this.txtProfundidad);
            this.Controls.Add(this.txtOrdTop);
            this.Controls.Add(this.txtAmplitud);
            this.Controls.Add(this.btnOrdCro);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.richTextBoxDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAmplitud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDatos;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.Button btnOrdCro;
        private System.Windows.Forms.TextBox txtAmplitud;
        private System.Windows.Forms.TextBox txtOrdTop;
        private System.Windows.Forms.TextBox txtProfundidad;
        private System.Windows.Forms.Button btnMaAd;
    }
}


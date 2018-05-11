namespace ProyectoFinalProgra2.Formularios.Parqueo
{
    partial class IngresoCarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresarParqueo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Parqueo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(100, 41);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(250, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(19, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresarParqueo
            // 
            this.btnIngresarParqueo.Location = new System.Drawing.Point(274, 272);
            this.btnIngresarParqueo.Name = "btnIngresarParqueo";
            this.btnIngresarParqueo.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarParqueo.TabIndex = 4;
            this.btnIngresarParqueo.Text = "Ingresar";
            this.btnIngresarParqueo.UseVisualStyleBackColor = true;
            this.btnIngresarParqueo.Click += new System.EventHandler(this.btnIngresarParqueo_Click);
            // 
            // IngresoCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 307);
            this.Controls.Add(this.btnIngresarParqueo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresoCarro";
            this.Text = "IngresoCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresarParqueo;
    }
}
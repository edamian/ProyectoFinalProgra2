namespace ProyectoFinalProgra2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearParqueoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarParqueoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosToolStripMenuItem,
            this.parqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearParqueoToolStripMenuItem,
            this.editarParqueoToolStripMenuItem,
            this.ingresoCarroToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.carrosToolStripMenuItem.Text = "Parqueos";
            // 
            // parqueToolStripMenuItem
            // 
            this.parqueToolStripMenuItem.Name = "parqueToolStripMenuItem";
            this.parqueToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.parqueToolStripMenuItem.Text = "Facturacion";
            this.parqueToolStripMenuItem.Click += new System.EventHandler(this.parqueToolStripMenuItem_Click);
            // 
            // crearParqueoToolStripMenuItem
            // 
            this.crearParqueoToolStripMenuItem.Name = "crearParqueoToolStripMenuItem";
            this.crearParqueoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearParqueoToolStripMenuItem.Text = "Crear parqueo";
            this.crearParqueoToolStripMenuItem.Click += new System.EventHandler(this.crearParqueoToolStripMenuItem_Click);
            // 
            // editarParqueoToolStripMenuItem
            // 
            this.editarParqueoToolStripMenuItem.Name = "editarParqueoToolStripMenuItem";
            this.editarParqueoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarParqueoToolStripMenuItem.Text = "Editar parqueo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ingresoCarroToolStripMenuItem
            // 
            this.ingresoCarroToolStripMenuItem.Name = "ingresoCarroToolStripMenuItem";
            this.ingresoCarroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ingresoCarroToolStripMenuItem.Text = "Ingreso carro";
            this.ingresoCarroToolStripMenuItem.Click += new System.EventHandler(this.ingresoCarroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 820);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearParqueoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarParqueoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCarroToolStripMenuItem;
    }
}


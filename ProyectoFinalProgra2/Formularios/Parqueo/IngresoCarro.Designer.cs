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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxVehiculos = new System.Windows.Forms.GroupBox();
            this.panelVehiculos = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxCamiones = new System.Windows.Forms.GroupBox();
            this.panelCamiones = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxMotos = new System.Windows.Forms.GroupBox();
            this.panelMotos = new System.Windows.Forms.TableLayoutPanel();
            this.cboxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpBoxVehiculos.SuspendLayout();
            this.grpBoxCamiones.SuspendLayout();
            this.grpBoxMotos.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(109, 76);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(264, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(701, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresarParqueo
            // 
            this.btnIngresarParqueo.Location = new System.Drawing.Point(471, 69);
            this.btnIngresarParqueo.Name = "btnIngresarParqueo";
            this.btnIngresarParqueo.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarParqueo.TabIndex = 4;
            this.btnIngresarParqueo.Text = "Ingresar";
            this.btnIngresarParqueo.UseVisualStyleBackColor = true;
            this.btnIngresarParqueo.Click += new System.EventHandler(this.btnIngresarParqueo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.grpBoxVehiculos);
            this.panel1.Controls.Add(this.grpBoxCamiones);
            this.panel1.Controls.Add(this.grpBoxMotos);
            this.panel1.Location = new System.Drawing.Point(16, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 500);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Liberar parqueo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBoxVehiculos
            // 
            this.grpBoxVehiculos.Controls.Add(this.panelVehiculos);
            this.grpBoxVehiculos.Location = new System.Drawing.Point(487, 26);
            this.grpBoxVehiculos.Name = "grpBoxVehiculos";
            this.grpBoxVehiculos.Size = new System.Drawing.Size(475, 398);
            this.grpBoxVehiculos.TabIndex = 2;
            this.grpBoxVehiculos.TabStop = false;
            this.grpBoxVehiculos.Text = "Vehiculos";
            // 
            // panelVehiculos
            // 
            this.panelVehiculos.AutoScroll = true;
            this.panelVehiculos.ColumnCount = 2;
            this.panelVehiculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelVehiculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelVehiculos.Location = new System.Drawing.Point(9, 18);
            this.panelVehiculos.MaximumSize = new System.Drawing.Size(475, 398);
            this.panelVehiculos.Name = "panelVehiculos";
            this.panelVehiculos.RowCount = 2;
            this.panelVehiculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelVehiculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelVehiculos.Size = new System.Drawing.Size(465, 378);
            this.panelVehiculos.TabIndex = 0;
            // 
            // grpBoxCamiones
            // 
            this.grpBoxCamiones.Controls.Add(this.panelCamiones);
            this.grpBoxCamiones.Location = new System.Drawing.Point(20, 248);
            this.grpBoxCamiones.Name = "grpBoxCamiones";
            this.grpBoxCamiones.Size = new System.Drawing.Size(432, 193);
            this.grpBoxCamiones.TabIndex = 1;
            this.grpBoxCamiones.TabStop = false;
            this.grpBoxCamiones.Text = "Caminoes";
            // 
            // panelCamiones
            // 
            this.panelCamiones.AutoScroll = true;
            this.panelCamiones.ColumnCount = 2;
            this.panelCamiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCamiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCamiones.Location = new System.Drawing.Point(5, 16);
            this.panelCamiones.MaximumSize = new System.Drawing.Size(432, 193);
            this.panelCamiones.Name = "panelCamiones";
            this.panelCamiones.RowCount = 2;
            this.panelCamiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCamiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCamiones.Size = new System.Drawing.Size(416, 159);
            this.panelCamiones.TabIndex = 0;
            // 
            // grpBoxMotos
            // 
            this.grpBoxMotos.Controls.Add(this.panelMotos);
            this.grpBoxMotos.Location = new System.Drawing.Point(20, 26);
            this.grpBoxMotos.Name = "grpBoxMotos";
            this.grpBoxMotos.Size = new System.Drawing.Size(432, 186);
            this.grpBoxMotos.TabIndex = 0;
            this.grpBoxMotos.TabStop = false;
            this.grpBoxMotos.Text = "Motocicletas";
            // 
            // panelMotos
            // 
            this.panelMotos.AutoScroll = true;
            this.panelMotos.ColumnCount = 2;
            this.panelMotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMotos.Location = new System.Drawing.Point(5, 17);
            this.panelMotos.MaximumSize = new System.Drawing.Size(432, 186);
            this.panelMotos.Name = "panelMotos";
            this.panelMotos.RowCount = 2;
            this.panelMotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMotos.Size = new System.Drawing.Size(417, 159);
            this.panelMotos.TabIndex = 0;
            // 
            // cboxTipoVehiculo
            // 
            this.cboxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxTipoVehiculo.FormattingEnabled = true;
            this.cboxTipoVehiculo.Items.AddRange(new object[] {
            "Motocicleta",
            "Camion",
            "Vehiculo"});
            this.cboxTipoVehiculo.Location = new System.Drawing.Point(109, 103);
            this.cboxTipoVehiculo.Name = "cboxTipoVehiculo";
            this.cboxTipoVehiculo.Size = new System.Drawing.Size(264, 21);
            this.cboxTipoVehiculo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = " Tipo vehiculo";
            // 
            // IngresoCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxTipoVehiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIngresarParqueo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "IngresoCarro";
            this.Text = "IngresoCarro";
            this.Load += new System.EventHandler(this.IngresoCarro_Load);
            this.panel1.ResumeLayout(false);
            this.grpBoxVehiculos.ResumeLayout(false);
            this.grpBoxCamiones.ResumeLayout(false);
            this.grpBoxMotos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresarParqueo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxVehiculos;
        private System.Windows.Forms.GroupBox grpBoxCamiones;
        private System.Windows.Forms.GroupBox grpBoxMotos;
        private System.Windows.Forms.TableLayoutPanel panelMotos;
        private System.Windows.Forms.TableLayoutPanel panelCamiones;
        private System.Windows.Forms.TableLayoutPanel panelVehiculos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboxTipoVehiculo;
        private System.Windows.Forms.Label label3;
    }
}
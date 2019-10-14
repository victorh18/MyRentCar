namespace MyRentCar.UI.Formularios.Reportes
{
    partial class frmReporteRentas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.grbVehiculo = new System.Windows.Forms.GroupBox();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.lblNumeroPlaca = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cbxCombustible = new System.Windows.Forms.ComboBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.grbDatos.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(526, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTE DE RENTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtEmpleado);
            this.grbDatos.Controls.Add(this.txtCliente);
            this.grbDatos.Controls.Add(this.lblEmpleado);
            this.grbDatos.Controls.Add(this.lblCliente);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbDatos.Location = new System.Drawing.Point(13, 57);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(525, 73);
            this.grbDatos.TabIndex = 1;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos Consultas";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmpleado.Location = new System.Drawing.Point(289, 43);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(228, 20);
            this.txtEmpleado.TabIndex = 3;
            this.txtEmpleado.DoubleClick += new System.EventHandler(this.TxtEmpleado_DoubleClick);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txtCliente.Location = new System.Drawing.Point(15, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(216, 20);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.DoubleClick += new System.EventHandler(this.TxtCliente_DoubleClick);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmpleado.Location = new System.Drawing.Point(286, 26);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCliente.Location = new System.Drawing.Point(16, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(110, 338);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(319, 43);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "GENERAR";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grbFecha
            // 
            this.grbFecha.Controls.Add(this.dateTimePicker2);
            this.grbFecha.Controls.Add(this.dateTimePicker1);
            this.grbFecha.Controls.Add(this.lblHasta);
            this.grbFecha.Controls.Add(this.lblFechaDesde);
            this.grbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbFecha.Location = new System.Drawing.Point(12, 136);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(526, 68);
            this.grbFecha.TabIndex = 3;
            this.grbFecha.TabStop = false;
            this.grbFecha.Text = "Fechas";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(290, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHasta.Location = new System.Drawing.Point(287, 22);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Click += new System.EventHandler(this.LblHasta_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFechaDesde.Location = new System.Drawing.Point(13, 22);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Desde:";
            this.lblFechaDesde.Click += new System.EventHandler(this.LblFechaDesde_Click);
            // 
            // grbVehiculo
            // 
            this.grbVehiculo.Controls.Add(this.txtNumeroPlaca);
            this.grbVehiculo.Controls.Add(this.lblNumeroPlaca);
            this.grbVehiculo.Controls.Add(this.txtVehiculo);
            this.grbVehiculo.Controls.Add(this.lblVehiculo);
            this.grbVehiculo.Controls.Add(this.cbxCombustible);
            this.grbVehiculo.Controls.Add(this.lblCombustible);
            this.grbVehiculo.Controls.Add(this.cbxTipoVehiculo);
            this.grbVehiculo.Controls.Add(this.lblTipoVehiculo);
            this.grbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVehiculo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbVehiculo.Location = new System.Drawing.Point(12, 210);
            this.grbVehiculo.Name = "grbVehiculo";
            this.grbVehiculo.Size = new System.Drawing.Size(526, 122);
            this.grbVehiculo.TabIndex = 4;
            this.grbVehiculo.TabStop = false;
            this.grbVehiculo.Text = "Vehiculo:";
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPlaca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroPlaca.Location = new System.Drawing.Point(290, 91);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(228, 20);
            this.txtNumeroPlaca.TabIndex = 7;
            this.txtNumeroPlaca.TextChanged += new System.EventHandler(this.TxtNumeroPlaca_TextChanged);
            this.txtNumeroPlaca.DoubleClick += new System.EventHandler(this.TxtNumeroPlaca_DoubleClick);
            // 
            // lblNumeroPlaca
            // 
            this.lblNumeroPlaca.AutoSize = true;
            this.lblNumeroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPlaca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroPlaca.Location = new System.Drawing.Point(290, 74);
            this.lblNumeroPlaca.Name = "lblNumeroPlaca";
            this.lblNumeroPlaca.Size = new System.Drawing.Size(54, 13);
            this.lblNumeroPlaca.TabIndex = 6;
            this.lblNumeroPlaca.Text = "No. Placa";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtVehiculo.Location = new System.Drawing.Point(16, 91);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(213, 20);
            this.txtVehiculo.TabIndex = 5;
            this.txtVehiculo.TextChanged += new System.EventHandler(this.TxtVehiculo_TextChanged);
            this.txtVehiculo.DoubleClick += new System.EventHandler(this.TxtVehiculo_DoubleClick);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVehiculo.Location = new System.Drawing.Point(16, 74);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // cbxCombustible
            // 
            this.cbxCombustible.FormattingEnabled = true;
            this.cbxCombustible.Location = new System.Drawing.Point(290, 36);
            this.cbxCombustible.Name = "cbxCombustible";
            this.cbxCombustible.Size = new System.Drawing.Size(228, 21);
            this.cbxCombustible.TabIndex = 3;
            this.cbxCombustible.SelectionChangeCommitted += new System.EventHandler(this.CbxCombustible_SelectionChangeCommitted);
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCombustible.Location = new System.Drawing.Point(287, 20);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(67, 13);
            this.lblCombustible.TabIndex = 2;
            this.lblCombustible.Text = "Combustible:";
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(16, 36);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(213, 21);
            this.cbxTipoVehiculo.TabIndex = 1;
            this.cbxTipoVehiculo.SelectionChangeCommitted += new System.EventHandler(this.CbxTipoVehiculo_SelectionChangeCommitted);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(16, 20);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(77, 13);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo Vehículo:";
            // 
            // frmReporteRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 393);
            this.Controls.Add(this.grbVehiculo);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReporteRentas";
            this.Text = "Reporte de Rentas";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbVehiculo.ResumeLayout(false);
            this.grbVehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.GroupBox grbVehiculo;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.Label lblNumeroPlaca;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cbxCombustible;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
    }
}
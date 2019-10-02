namespace MyRentCar.UI.Formularios
{
    partial class frmRentas
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
            this.components = new System.ComponentModel.Container();
            this.tlspRentas = new System.Windows.Forms.ToolStrip();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosRenta = new System.Windows.Forms.GroupBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.lblMontoDia = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPlacaVehiculo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtNumeroRenta = new System.Windows.Forms.TextBox();
            this.lblNumeroRenta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.rentaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.nudMontoPorDia = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadDias = new System.Windows.Forms.NumericUpDown();
            this.tlspRentas.SuspendLayout();
            this.grbDatosRenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPorDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).BeginInit();
            this.SuspendLayout();
            // 
            // tlspRentas
            // 
            this.tlspRentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tlspRentas.Location = new System.Drawing.Point(0, 0);
            this.tlspRentas.Name = "tlspRentas";
            this.tlspRentas.Size = new System.Drawing.Size(1071, 25);
            this.tlspRentas.TabIndex = 0;
            this.tlspRentas.Text = "toolStrip1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(928, 53);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRO DE RENTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDatosRenta
            // 
            this.grbDatosRenta.Controls.Add(this.nudCantidadDias);
            this.grbDatosRenta.Controls.Add(this.nudMontoPorDia);
            this.grbDatosRenta.Controls.Add(this.dtpFechaDevolucion);
            this.grbDatosRenta.Controls.Add(this.dtpFechaRenta);
            this.grbDatosRenta.Controls.Add(this.txtVehiculo);
            this.grbDatosRenta.Controls.Add(this.lblVehiculo);
            this.grbDatosRenta.Controls.Add(this.chkEstado);
            this.grbDatosRenta.Controls.Add(this.txtCliente);
            this.grbDatosRenta.Controls.Add(this.txtPlacaVehiculo);
            this.grbDatosRenta.Controls.Add(this.txtEmpleado);
            this.grbDatosRenta.Controls.Add(this.txtComentario);
            this.grbDatosRenta.Controls.Add(this.lblComentario);
            this.grbDatosRenta.Controls.Add(this.lblCantidadDias);
            this.grbDatosRenta.Controls.Add(this.lblMontoDia);
            this.grbDatosRenta.Controls.Add(this.lblFechaDevolucion);
            this.grbDatosRenta.Controls.Add(this.lblFechaRenta);
            this.grbDatosRenta.Controls.Add(this.lblCliente);
            this.grbDatosRenta.Controls.Add(this.lblPlacaVehiculo);
            this.grbDatosRenta.Controls.Add(this.lblEmpleado);
            this.grbDatosRenta.Controls.Add(this.txtNumeroRenta);
            this.grbDatosRenta.Controls.Add(this.lblNumeroRenta);
            this.grbDatosRenta.Location = new System.Drawing.Point(17, 86);
            this.grbDatosRenta.Name = "grbDatosRenta";
            this.grbDatosRenta.Size = new System.Drawing.Size(1042, 224);
            this.grbDatosRenta.TabIndex = 2;
            this.grbDatosRenta.TabStop = false;
            this.grbDatosRenta.Text = "Datos Renta";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(868, 106);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 18;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txtCliente.Location = new System.Drawing.Point(825, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(163, 20);
            this.txtCliente.TabIndex = 16;
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(418, 43);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.ReadOnly = true;
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(167, 20);
            this.txtPlacaVehiculo.TabIndex = 15;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmpleado.Location = new System.Drawing.Point(215, 43);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(174, 20);
            this.txtEmpleado.TabIndex = 12;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(19, 154);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(1017, 64);
            this.txtComentario.TabIndex = 10;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(16, 138);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 13);
            this.lblComentario.TabIndex = 9;
            this.lblComentario.Text = "Comentario:";
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Location = new System.Drawing.Point(617, 87);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(93, 13);
            this.lblCantidadDias.TabIndex = 8;
            this.lblCantidadDias.Text = "Cantidad de Días:";
            // 
            // lblMontoDia
            // 
            this.lblMontoDia.AutoSize = true;
            this.lblMontoDia.Location = new System.Drawing.Point(415, 87);
            this.lblMontoDia.Name = "lblMontoDia";
            this.lblMontoDia.Size = new System.Drawing.Size(79, 13);
            this.lblMontoDia.TabIndex = 7;
            this.lblMontoDia.Text = "Monto por Día:";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(212, 87);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(97, 13);
            this.lblFechaDevolucion.TabIndex = 6;
            this.lblFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Location = new System.Drawing.Point(19, 87);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(72, 13);
            this.lblFechaRenta.TabIndex = 5;
            this.lblFechaRenta.Text = "Fecha Renta:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(822, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(415, 26);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(83, 13);
            this.lblPlacaVehiculo.TabIndex = 3;
            this.lblPlacaVehiculo.Text = "Placa Vehículo:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(212, 26);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // txtNumeroRenta
            // 
            this.txtNumeroRenta.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroRenta.Location = new System.Drawing.Point(22, 42);
            this.txtNumeroRenta.Name = "txtNumeroRenta";
            this.txtNumeroRenta.ReadOnly = true;
            this.txtNumeroRenta.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroRenta.TabIndex = 1;
            // 
            // lblNumeroRenta
            // 
            this.lblNumeroRenta.AutoSize = true;
            this.lblNumeroRenta.Location = new System.Drawing.Point(19, 26);
            this.lblNumeroRenta.Name = "lblNumeroRenta";
            this.lblNumeroRenta.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroRenta.TabIndex = 0;
            this.lblNumeroRenta.Text = "No. Renta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroRentaDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.vehiculoDataGridViewTextBoxColumn,
            this.placaVehiculoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn,
            this.estadoRentaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentaDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(17, 323);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(879, 20);
            this.txtBusqueda.TabIndex = 19;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtVehiculo.Location = new System.Drawing.Point(620, 42);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(167, 20);
            this.txtVehiculo.TabIndex = 20;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(617, 25);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculo.TabIndex = 19;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::MyRentCar.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MyRentCar.Properties.Resources.Guardar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::MyRentCar.Properties.Resources.Cancelar;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // rentaDTOBindingSource
            // 
            this.rentaDTOBindingSource.DataSource = typeof(MyRentCar.Utilitarios.DTOs.RentaDTO);
            // 
            // numeroRentaDataGridViewTextBoxColumn
            // 
            this.numeroRentaDataGridViewTextBoxColumn.DataPropertyName = "NumeroRenta";
            this.numeroRentaDataGridViewTextBoxColumn.HeaderText = "NO. RENTA";
            this.numeroRentaDataGridViewTextBoxColumn.Name = "numeroRentaDataGridViewTextBoxColumn";
            this.numeroRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRentaDataGridViewTextBoxColumn
            // 
            this.fechaRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "FECHA RENTA";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            this.fechaRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            this.vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.HeaderText = "VEHÍCULO";
            this.vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            this.vehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaVehiculoDataGridViewTextBoxColumn
            // 
            this.placaVehiculoDataGridViewTextBoxColumn.DataPropertyName = "PlacaVehiculo";
            this.placaVehiculoDataGridViewTextBoxColumn.HeaderText = "NO. PLACA";
            this.placaVehiculoDataGridViewTextBoxColumn.Name = "placaVehiculoDataGridViewTextBoxColumn";
            this.placaVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "EMPLEADO";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.empleadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // estadoRentaDataGridViewTextBoxColumn
            // 
            this.estadoRentaDataGridViewTextBoxColumn.DataPropertyName = "EstadoRenta";
            this.estadoRentaDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadoRentaDataGridViewTextBoxColumn.Name = "estadoRentaDataGridViewTextBoxColumn";
            this.estadoRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtpFechaRenta
            // 
            this.dtpFechaRenta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaRenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRenta.Location = new System.Drawing.Point(22, 103);
            this.dtpFechaRenta.Name = "dtpFechaRenta";
            this.dtpFechaRenta.Size = new System.Drawing.Size(173, 20);
            this.dtpFechaRenta.TabIndex = 21;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(215, 103);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(174, 20);
            this.dtpFechaDevolucion.TabIndex = 22;
            // 
            // nudMontoPorDia
            // 
            this.nudMontoPorDia.Location = new System.Drawing.Point(418, 103);
            this.nudMontoPorDia.Name = "nudMontoPorDia";
            this.nudMontoPorDia.Size = new System.Drawing.Size(167, 20);
            this.nudMontoPorDia.TabIndex = 23;
            // 
            // nudCantidadDias
            // 
            this.nudCantidadDias.Location = new System.Drawing.Point(620, 106);
            this.nudCantidadDias.Name = "nudCantidadDias";
            this.nudCantidadDias.Size = new System.Drawing.Size(167, 20);
            this.nudCantidadDias.TabIndex = 24;
            // 
            // frmRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 585);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbDatosRenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tlspRentas);
            this.Name = "frmRentas";
            this.Text = "Registro de Rentas";
            this.tlspRentas.ResumeLayout(false);
            this.tlspRentas.PerformLayout();
            this.grbDatosRenta.ResumeLayout(false);
            this.grbDatosRenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPorDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlspRentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbDatosRenta;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblCantidadDias;
        private System.Windows.Forms.Label lblMontoDia;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblFechaRenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPlacaVehiculo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtNumeroRenta;
        private System.Windows.Forms.Label lblNumeroRenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rentaDTOBindingSource;
        private System.Windows.Forms.DateTimePicker dtpFechaRenta;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.NumericUpDown nudCantidadDias;
        private System.Windows.Forms.NumericUpDown nudMontoPorDia;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlspRentas = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosRenta = new System.Windows.Forms.GroupBox();
            this.nudCantidadDias = new System.Windows.Forms.NumericUpDown();
            this.nudMontoPorDia = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
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
            this.rentaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.numeroRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlspRentas.SuspendLayout();
            this.grbDatosRenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPorDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlspRentas
            // 
            this.tlspRentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbEliminar});
            this.tlspRentas.Location = new System.Drawing.Point(0, 0);
            this.tlspRentas.Name = "tlspRentas";
            this.tlspRentas.Size = new System.Drawing.Size(1071, 25);
            this.tlspRentas.TabIndex = 0;
            this.tlspRentas.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::MyRentCar.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::MyRentCar.Properties.Resources.Guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "toolStripButton2";
            this.tsbGuardar.Click += new System.EventHandler(this.TsbGuardar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::MyRentCar.Properties.Resources.Cancelar;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1046, 53);
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
            this.grbDatosRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosRenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbDatosRenta.Location = new System.Drawing.Point(17, 86);
            this.grbDatosRenta.Name = "grbDatosRenta";
            this.grbDatosRenta.Size = new System.Drawing.Size(1042, 224);
            this.grbDatosRenta.TabIndex = 2;
            this.grbDatosRenta.TabStop = false;
            this.grbDatosRenta.Text = "Datos Renta";
            // 
            // nudCantidadDias
            // 
            this.nudCantidadDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadDias.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nudCantidadDias.Location = new System.Drawing.Point(631, 102);
            this.nudCantidadDias.Name = "nudCantidadDias";
            this.nudCantidadDias.Size = new System.Drawing.Size(203, 20);
            this.nudCantidadDias.TabIndex = 24;
            // 
            // nudMontoPorDia
            // 
            this.nudMontoPorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMontoPorDia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nudMontoPorDia.Location = new System.Drawing.Point(423, 103);
            this.nudMontoPorDia.Name = "nudMontoPorDia";
            this.nudMontoPorDia.Size = new System.Drawing.Size(187, 20);
            this.nudMontoPorDia.TabIndex = 23;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(215, 103);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(190, 20);
            this.dtpFechaDevolucion.TabIndex = 22;
            // 
            // dtpFechaRenta
            // 
            this.dtpFechaRenta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRenta.Location = new System.Drawing.Point(22, 103);
            this.dtpFechaRenta.Name = "dtpFechaRenta";
            this.dtpFechaRenta.Size = new System.Drawing.Size(173, 20);
            this.dtpFechaRenta.TabIndex = 21;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtVehiculo.Location = new System.Drawing.Point(631, 42);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(203, 20);
            this.txtVehiculo.TabIndex = 20;
            this.txtVehiculo.DoubleClick += new System.EventHandler(this.TxtVehiculo_DoubleClick);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVehiculo.Location = new System.Drawing.Point(628, 25);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculo.TabIndex = 19;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkEstado.Location = new System.Drawing.Point(898, 105);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 18;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtCliente.Location = new System.Drawing.Point(855, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(181, 20);
            this.txtCliente.TabIndex = 16;
            this.txtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            this.txtCliente.DoubleClick += new System.EventHandler(this.TxtCliente_DoubleClick);
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlacaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(423, 42);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.ReadOnly = true;
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(187, 20);
            this.txtPlacaVehiculo.TabIndex = 15;
            this.txtPlacaVehiculo.TextChanged += new System.EventHandler(this.TxtPlacaVehiculo_TextChanged);
            this.txtPlacaVehiculo.DoubleClick += new System.EventHandler(this.TxtPlacaVehiculo_DoubleClick);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmpleado.Location = new System.Drawing.Point(215, 42);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(190, 20);
            this.txtEmpleado.TabIndex = 12;
            this.txtEmpleado.DoubleClick += new System.EventHandler(this.TxtEmpleado_DoubleClick);
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtComentario.Location = new System.Drawing.Point(19, 154);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(1017, 64);
            this.txtComentario.TabIndex = 10;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblComentario.Location = new System.Drawing.Point(16, 138);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 13);
            this.lblComentario.TabIndex = 9;
            this.lblComentario.Text = "Comentario:";
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDias.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCantidadDias.Location = new System.Drawing.Point(628, 87);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(93, 13);
            this.lblCantidadDias.TabIndex = 8;
            this.lblCantidadDias.Text = "Cantidad de Días:";
            // 
            // lblMontoDia
            // 
            this.lblMontoDia.AutoSize = true;
            this.lblMontoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMontoDia.Location = new System.Drawing.Point(420, 86);
            this.lblMontoDia.Name = "lblMontoDia";
            this.lblMontoDia.Size = new System.Drawing.Size(79, 13);
            this.lblMontoDia.TabIndex = 7;
            this.lblMontoDia.Text = "Monto por Día:";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(212, 87);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(97, 13);
            this.lblFechaDevolucion.TabIndex = 6;
            this.lblFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFechaRenta.Location = new System.Drawing.Point(19, 87);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(72, 13);
            this.lblFechaRenta.TabIndex = 5;
            this.lblFechaRenta.Text = "Fecha Renta:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCliente.Location = new System.Drawing.Point(852, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(420, 25);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(83, 13);
            this.lblPlacaVehiculo.TabIndex = 3;
            this.lblPlacaVehiculo.Text = "Placa Vehículo:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmpleado.Location = new System.Drawing.Point(212, 26);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(57, 13);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // txtNumeroRenta
            // 
            this.txtNumeroRenta.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroRenta.Location = new System.Drawing.Point(22, 42);
            this.txtNumeroRenta.Name = "txtNumeroRenta";
            this.txtNumeroRenta.ReadOnly = true;
            this.txtNumeroRenta.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroRenta.TabIndex = 1;
            // 
            // lblNumeroRenta
            // 
            this.lblNumeroRenta.AutoSize = true;
            this.lblNumeroRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroRenta.Location = new System.Drawing.Point(19, 26);
            this.lblNumeroRenta.Name = "lblNumeroRenta";
            this.lblNumeroRenta.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroRenta.TabIndex = 0;
            this.lblNumeroRenta.Text = "No. Renta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroRentaDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.vehiculoDataGridViewTextBoxColumn,
            this.placaVehiculoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentaDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // rentaDTOBindingSource
            // 
            this.rentaDTOBindingSource.DataSource = typeof(MyRentCar.Utilitarios.DTOs.RentaDTO);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(17, 323);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(1036, 20);
            this.txtBusqueda.TabIndex = 19;
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
            this.vehiculoDataGridViewTextBoxColumn.Width = 200;
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
            this.clienteDataGridViewTextBoxColumn.Width = 250;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "EMPLEADO";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.empleadoDataGridViewTextBoxColumn.Width = 250;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRentas";
            this.Text = "Registro de Rentas";
            this.tlspRentas.ResumeLayout(false);
            this.tlspRentas.PerformLayout();
            this.grbDatosRenta.ResumeLayout(false);
            this.grbDatosRenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPorDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDTOBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rentaDTOBindingSource;
        private System.Windows.Forms.DateTimePicker dtpFechaRenta;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.NumericUpDown nudCantidadDias;
        private System.Windows.Forms.NumericUpDown nudMontoPorDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
    }
}
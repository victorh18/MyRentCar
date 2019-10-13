namespace MyRentCar.UI.Formularios
{
    partial class frmInspecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsInspeccion = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.cbxTipoInspeccion = new System.Windows.Forms.ComboBox();
            this.txtNumeroInspeccion = new System.Windows.Forms.TextBox();
            this.lblNumeroInspeccion = new System.Windows.Forms.Label();
            this.txtNumeroRenta = new System.Windows.Forms.TextBox();
            this.lblNumeroRenta = new System.Windows.Forms.Label();
            this.dtpFechaInspeccion = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.lblTipoInspeccion = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblPlacaVehiculo = new System.Windows.Forms.Label();
            this.grbDatosInspeccion = new System.Windows.Forms.GroupBox();
            this.nudCantidadCombustible = new System.Windows.Forms.NumericUpDown();
            this.chkGomaTraseraDerecha = new System.Windows.Forms.CheckBox();
            this.chkGomaFronteraDerecha = new System.Windows.Forms.CheckBox();
            this.chkGomaTraseraIzquierda = new System.Windows.Forms.CheckBox();
            this.chkGomaFronteraIzquierda = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCantidadCombustible = new System.Windows.Forms.Label();
            this.chkTieneRoturasCristal = new System.Windows.Forms.CheckBox();
            this.chkTieneGato = new System.Windows.Forms.CheckBox();
            this.chkTieneRayadura = new System.Windows.Forms.CheckBox();
            this.chkTieneGomaRepuesto = new System.Windows.Forms.CheckBox();
            this.dgvConsultaInspecciones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoInspeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspeccionesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tsInspeccion.SuspendLayout();
            this.grbDatosGenerales.SuspendLayout();
            this.grbDatosInspeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCombustible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaInspecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionesDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsInspeccion
            // 
            this.tsInspeccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbEliminar});
            this.tsInspeccion.Location = new System.Drawing.Point(0, 0);
            this.tsInspeccion.Name = "tsInspeccion";
            this.tsInspeccion.Size = new System.Drawing.Size(953, 25);
            this.tsInspeccion.TabIndex = 0;
            this.tsInspeccion.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::MyRentCar.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::MyRentCar.Properties.Resources.Guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.TsbGuardar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::MyRentCar.Properties.Resources.Cancelar;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.TsbEliminar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(928, 53);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRO DE INSPECCIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.cbxTipoInspeccion);
            this.grbDatosGenerales.Controls.Add(this.txtNumeroInspeccion);
            this.grbDatosGenerales.Controls.Add(this.lblNumeroInspeccion);
            this.grbDatosGenerales.Controls.Add(this.txtNumeroRenta);
            this.grbDatosGenerales.Controls.Add(this.lblNumeroRenta);
            this.grbDatosGenerales.Controls.Add(this.dtpFechaInspeccion);
            this.grbDatosGenerales.Controls.Add(this.lblFecha);
            this.grbDatosGenerales.Controls.Add(this.chkEstado);
            this.grbDatosGenerales.Controls.Add(this.txtEmpleado);
            this.grbDatosGenerales.Controls.Add(this.txtCliente);
            this.grbDatosGenerales.Controls.Add(this.txtVehiculo);
            this.grbDatosGenerales.Controls.Add(this.txtPlacaVehiculo);
            this.grbDatosGenerales.Controls.Add(this.lblTipoInspeccion);
            this.grbDatosGenerales.Controls.Add(this.lblEmpleado);
            this.grbDatosGenerales.Controls.Add(this.lblCliente);
            this.grbDatosGenerales.Controls.Add(this.lblVehiculo);
            this.grbDatosGenerales.Controls.Add(this.lblPlacaVehiculo);
            this.grbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosGenerales.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbDatosGenerales.Location = new System.Drawing.Point(13, 86);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(928, 135);
            this.grbDatosGenerales.TabIndex = 2;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Generales";
            // 
            // cbxTipoInspeccion
            // 
            this.cbxTipoInspeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoInspeccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbxTipoInspeccion.FormattingEnabled = true;
            this.cbxTipoInspeccion.Location = new System.Drawing.Point(18, 87);
            this.cbxTipoInspeccion.Name = "cbxTipoInspeccion";
            this.cbxTipoInspeccion.Size = new System.Drawing.Size(201, 21);
            this.cbxTipoInspeccion.TabIndex = 19;
            // 
            // txtNumeroInspeccion
            // 
            this.txtNumeroInspeccion.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroInspeccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroInspeccion.Location = new System.Drawing.Point(18, 41);
            this.txtNumeroInspeccion.Name = "txtNumeroInspeccion";
            this.txtNumeroInspeccion.Size = new System.Drawing.Size(201, 20);
            this.txtNumeroInspeccion.TabIndex = 18;
            // 
            // lblNumeroInspeccion
            // 
            this.lblNumeroInspeccion.AutoSize = true;
            this.lblNumeroInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroInspeccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroInspeccion.Location = new System.Drawing.Point(15, 25);
            this.lblNumeroInspeccion.Name = "lblNumeroInspeccion";
            this.lblNumeroInspeccion.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroInspeccion.TabIndex = 17;
            this.lblNumeroInspeccion.Text = "No. Inspeccion";
            // 
            // txtNumeroRenta
            // 
            this.txtNumeroRenta.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroRenta.Location = new System.Drawing.Point(248, 41);
            this.txtNumeroRenta.Name = "txtNumeroRenta";
            this.txtNumeroRenta.Size = new System.Drawing.Size(201, 20);
            this.txtNumeroRenta.TabIndex = 16;
            this.txtNumeroRenta.TextChanged += new System.EventHandler(this.TxtNumeroRenta_TextChanged);
            this.txtNumeroRenta.DoubleClick += new System.EventHandler(this.TxtNumeroRenta_DoubleClick);
            // 
            // lblNumeroRenta
            // 
            this.lblNumeroRenta.AutoSize = true;
            this.lblNumeroRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroRenta.Location = new System.Drawing.Point(245, 25);
            this.lblNumeroRenta.Name = "lblNumeroRenta";
            this.lblNumeroRenta.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroRenta.TabIndex = 15;
            this.lblNumeroRenta.Text = "No. Renta";
            // 
            // dtpFechaInspeccion
            // 
            this.dtpFechaInspeccion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInspeccion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInspeccion.Location = new System.Drawing.Point(716, 89);
            this.dtpFechaInspeccion.Name = "dtpFechaInspeccion";
            this.dtpFechaInspeccion.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaInspeccion.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFecha.Location = new System.Drawing.Point(713, 73);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha Inspección:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkEstado.Location = new System.Drawing.Point(857, 91);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 12;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmpleado.Location = new System.Drawing.Point(482, 89);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(206, 20);
            this.txtEmpleado.TabIndex = 10;
            this.txtEmpleado.DoubleClick += new System.EventHandler(this.TxtEmpleado_DoubleClick);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtCliente.Location = new System.Drawing.Point(248, 89);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(201, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtVehiculo.Location = new System.Drawing.Point(716, 41);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(201, 20);
            this.txtVehiculo.TabIndex = 7;
            this.txtVehiculo.DoubleClick += new System.EventHandler(this.TxtVehiculo_DoubleClick);
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlacaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(482, 41);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(206, 20);
            this.txtPlacaVehiculo.TabIndex = 6;
            this.txtPlacaVehiculo.DoubleClick += new System.EventHandler(this.TxtPlacaVehiculo_DoubleClick);
            // 
            // lblTipoInspeccion
            // 
            this.lblTipoInspeccion.AutoSize = true;
            this.lblTipoInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInspeccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTipoInspeccion.Location = new System.Drawing.Point(15, 73);
            this.lblTipoInspeccion.Name = "lblTipoInspeccion";
            this.lblTipoInspeccion.Size = new System.Drawing.Size(86, 13);
            this.lblTipoInspeccion.TabIndex = 5;
            this.lblTipoInspeccion.Text = "Tipo Inspección:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmpleado.Location = new System.Drawing.Point(482, 73);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(97, 13);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Nombre Empleado:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCliente.Location = new System.Drawing.Point(245, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre Cliente:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblVehiculo.Location = new System.Drawing.Point(713, 25);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculo.TabIndex = 1;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVehiculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(479, 25);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(83, 13);
            this.lblPlacaVehiculo.TabIndex = 0;
            this.lblPlacaVehiculo.Text = "Placa Vehículo:";
            // 
            // grbDatosInspeccion
            // 
            this.grbDatosInspeccion.Controls.Add(this.nudCantidadCombustible);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaTraseraDerecha);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaFronteraDerecha);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaTraseraIzquierda);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaFronteraIzquierda);
            this.grbDatosInspeccion.Controls.Add(this.txtObservaciones);
            this.grbDatosInspeccion.Controls.Add(this.lblObservaciones);
            this.grbDatosInspeccion.Controls.Add(this.lblCantidadCombustible);
            this.grbDatosInspeccion.Controls.Add(this.chkTieneRoturasCristal);
            this.grbDatosInspeccion.Controls.Add(this.chkTieneGato);
            this.grbDatosInspeccion.Controls.Add(this.chkTieneRayadura);
            this.grbDatosInspeccion.Controls.Add(this.chkTieneGomaRepuesto);
            this.grbDatosInspeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosInspeccion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbDatosInspeccion.Location = new System.Drawing.Point(17, 237);
            this.grbDatosInspeccion.Name = "grbDatosInspeccion";
            this.grbDatosInspeccion.Size = new System.Drawing.Size(924, 147);
            this.grbDatosInspeccion.TabIndex = 3;
            this.grbDatosInspeccion.TabStop = false;
            this.grbDatosInspeccion.Text = "Datos Inspección";
            // 
            // nudCantidadCombustible
            // 
            this.nudCantidadCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadCombustible.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nudCantidadCombustible.Location = new System.Drawing.Point(14, 45);
            this.nudCantidadCombustible.Name = "nudCantidadCombustible";
            this.nudCantidadCombustible.Size = new System.Drawing.Size(201, 20);
            this.nudCantidadCombustible.TabIndex = 15;
            // 
            // chkGomaTraseraDerecha
            // 
            this.chkGomaTraseraDerecha.AutoSize = true;
            this.chkGomaTraseraDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGomaTraseraDerecha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkGomaTraseraDerecha.Location = new System.Drawing.Point(493, 67);
            this.chkGomaTraseraDerecha.Name = "chkGomaTraseraDerecha";
            this.chkGomaTraseraDerecha.Size = new System.Drawing.Size(137, 17);
            this.chkGomaTraseraDerecha.TabIndex = 14;
            this.chkGomaTraseraDerecha.Text = "Goma Trasera Derecha";
            this.chkGomaTraseraDerecha.UseVisualStyleBackColor = true;
            // 
            // chkGomaFronteraDerecha
            // 
            this.chkGomaFronteraDerecha.AutoSize = true;
            this.chkGomaFronteraDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGomaFronteraDerecha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkGomaFronteraDerecha.Location = new System.Drawing.Point(493, 45);
            this.chkGomaFronteraDerecha.Name = "chkGomaFronteraDerecha";
            this.chkGomaFronteraDerecha.Size = new System.Drawing.Size(140, 17);
            this.chkGomaFronteraDerecha.TabIndex = 13;
            this.chkGomaFronteraDerecha.Text = "Goma Frontera Derecha";
            this.chkGomaFronteraDerecha.UseVisualStyleBackColor = true;
            // 
            // chkGomaTraseraIzquierda
            // 
            this.chkGomaTraseraIzquierda.AutoSize = true;
            this.chkGomaTraseraIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGomaTraseraIzquierda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkGomaTraseraIzquierda.Location = new System.Drawing.Point(295, 67);
            this.chkGomaTraseraIzquierda.Name = "chkGomaTraseraIzquierda";
            this.chkGomaTraseraIzquierda.Size = new System.Drawing.Size(139, 17);
            this.chkGomaTraseraIzquierda.TabIndex = 12;
            this.chkGomaTraseraIzquierda.Text = "Goma Trasera Izquierda";
            this.chkGomaTraseraIzquierda.UseVisualStyleBackColor = true;
            // 
            // chkGomaFronteraIzquierda
            // 
            this.chkGomaFronteraIzquierda.AutoSize = true;
            this.chkGomaFronteraIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGomaFronteraIzquierda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkGomaFronteraIzquierda.Location = new System.Drawing.Point(295, 43);
            this.chkGomaFronteraIzquierda.Name = "chkGomaFronteraIzquierda";
            this.chkGomaFronteraIzquierda.Size = new System.Drawing.Size(142, 17);
            this.chkGomaFronteraIzquierda.TabIndex = 11;
            this.chkGomaFronteraIzquierda.Text = "Goma Frontera Izquierda";
            this.chkGomaFronteraIzquierda.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtObservaciones.Location = new System.Drawing.Point(14, 99);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(705, 33);
            this.txtObservaciones.TabIndex = 10;
            this.txtObservaciones.TextChanged += new System.EventHandler(this.TxtObservaciones_TextChanged);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblObservaciones.Location = new System.Drawing.Point(11, 83);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblCantidadCombustible
            // 
            this.lblCantidadCombustible.AutoSize = true;
            this.lblCantidadCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCombustible.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCantidadCombustible.Location = new System.Drawing.Point(11, 29);
            this.lblCantidadCombustible.Name = "lblCantidadCombustible";
            this.lblCantidadCombustible.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadCombustible.TabIndex = 5;
            this.lblCantidadCombustible.Text = "Cantidad Combustible:";
            // 
            // chkTieneRoturasCristal
            // 
            this.chkTieneRoturasCristal.AutoSize = true;
            this.chkTieneRoturasCristal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTieneRoturasCristal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkTieneRoturasCristal.Location = new System.Drawing.Point(764, 115);
            this.chkTieneRoturasCristal.Name = "chkTieneRoturasCristal";
            this.chkTieneRoturasCristal.Size = new System.Drawing.Size(124, 17);
            this.chkTieneRoturasCristal.TabIndex = 3;
            this.chkTieneRoturasCristal.Text = "Tiene Roturas Cristal";
            this.chkTieneRoturasCristal.UseVisualStyleBackColor = true;
            // 
            // chkTieneGato
            // 
            this.chkTieneGato.AutoSize = true;
            this.chkTieneGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTieneGato.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkTieneGato.Location = new System.Drawing.Point(764, 92);
            this.chkTieneGato.Name = "chkTieneGato";
            this.chkTieneGato.Size = new System.Drawing.Size(79, 17);
            this.chkTieneGato.TabIndex = 2;
            this.chkTieneGato.Text = "Tiene Gato";
            this.chkTieneGato.UseVisualStyleBackColor = true;
            // 
            // chkTieneRayadura
            // 
            this.chkTieneRayadura.AutoSize = true;
            this.chkTieneRayadura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTieneRayadura.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkTieneRayadura.Location = new System.Drawing.Point(764, 69);
            this.chkTieneRayadura.Name = "chkTieneRayadura";
            this.chkTieneRayadura.Size = new System.Drawing.Size(102, 17);
            this.chkTieneRayadura.TabIndex = 1;
            this.chkTieneRayadura.Text = "Tiene Rayadura";
            this.chkTieneRayadura.UseVisualStyleBackColor = true;
            // 
            // chkTieneGomaRepuesto
            // 
            this.chkTieneGomaRepuesto.AutoSize = true;
            this.chkTieneGomaRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTieneGomaRepuesto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkTieneGomaRepuesto.Location = new System.Drawing.Point(764, 45);
            this.chkTieneGomaRepuesto.Name = "chkTieneGomaRepuesto";
            this.chkTieneGomaRepuesto.Size = new System.Drawing.Size(133, 17);
            this.chkTieneGomaRepuesto.TabIndex = 0;
            this.chkTieneGomaRepuesto.Text = "Tiene Goma Repuesto";
            this.chkTieneGomaRepuesto.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaInspecciones
            // 
            this.dgvConsultaInspecciones.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaInspecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaInspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaInspecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroRentaDataGridViewTextBoxColumn,
            this.placaVehiculoDataGridViewTextBoxColumn,
            this.modeloVehiculoDataGridViewTextBoxColumn,
            this.tipoInspeccionDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn});
            this.dgvConsultaInspecciones.DataSource = this.inspeccionesDTOBindingSource;
            this.dgvConsultaInspecciones.Location = new System.Drawing.Point(13, 426);
            this.dgvConsultaInspecciones.Name = "dgvConsultaInspecciones";
            this.dgvConsultaInspecciones.Size = new System.Drawing.Size(928, 147);
            this.dgvConsultaInspecciones.TabIndex = 4;
            this.dgvConsultaInspecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultaInspecciones_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "NO. INSPECCIÓN";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroRentaDataGridViewTextBoxColumn
            // 
            this.numeroRentaDataGridViewTextBoxColumn.DataPropertyName = "NumeroRenta";
            this.numeroRentaDataGridViewTextBoxColumn.HeaderText = "NO. RENTA";
            this.numeroRentaDataGridViewTextBoxColumn.Name = "numeroRentaDataGridViewTextBoxColumn";
            this.numeroRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaVehiculoDataGridViewTextBoxColumn
            // 
            this.placaVehiculoDataGridViewTextBoxColumn.DataPropertyName = "PlacaVehiculo";
            this.placaVehiculoDataGridViewTextBoxColumn.HeaderText = "PLACA VEHÍCULO";
            this.placaVehiculoDataGridViewTextBoxColumn.Name = "placaVehiculoDataGridViewTextBoxColumn";
            this.placaVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloVehiculoDataGridViewTextBoxColumn
            // 
            this.modeloVehiculoDataGridViewTextBoxColumn.DataPropertyName = "ModeloVehiculo";
            this.modeloVehiculoDataGridViewTextBoxColumn.HeaderText = "VEHÍCULO";
            this.modeloVehiculoDataGridViewTextBoxColumn.Name = "modeloVehiculoDataGridViewTextBoxColumn";
            this.modeloVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloVehiculoDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoInspeccionDataGridViewTextBoxColumn
            // 
            this.tipoInspeccionDataGridViewTextBoxColumn.DataPropertyName = "TipoInspeccion";
            this.tipoInspeccionDataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tipoInspeccionDataGridViewTextBoxColumn.Name = "tipoInspeccionDataGridViewTextBoxColumn";
            this.tipoInspeccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "CLIENTE";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "EMPLEADO";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // inspeccionesDTOBindingSource
            // 
            this.inspeccionesDTOBindingSource.DataSource = typeof(MyRentCar.Utilitarios.DTOs.InspeccionesDTO);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 400);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(929, 20);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // frmInspecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 585);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvConsultaInspecciones);
            this.Controls.Add(this.grbDatosInspeccion);
            this.Controls.Add(this.grbDatosGenerales);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tsInspeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInspecciones";
            this.Text = "Registro de Inspecciones";
            this.Load += new System.EventHandler(this.FrmInspecciones_Load);
            this.tsInspeccion.ResumeLayout(false);
            this.tsInspeccion.PerformLayout();
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            this.grbDatosInspeccion.ResumeLayout(false);
            this.grbDatosInspeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCombustible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaInspecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionesDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsInspeccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtpFechaInspeccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.Label lblTipoInspeccion;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblPlacaVehiculo;
        private System.Windows.Forms.GroupBox grbDatosInspeccion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblCantidadCombustible;
        private System.Windows.Forms.CheckBox chkTieneRoturasCristal;
        private System.Windows.Forms.CheckBox chkTieneGato;
        private System.Windows.Forms.CheckBox chkTieneRayadura;
        private System.Windows.Forms.CheckBox chkTieneGomaRepuesto;
        private System.Windows.Forms.CheckBox chkGomaTraseraDerecha;
        private System.Windows.Forms.CheckBox chkGomaFronteraDerecha;
        private System.Windows.Forms.CheckBox chkGomaTraseraIzquierda;
        private System.Windows.Forms.CheckBox chkGomaFronteraIzquierda;
        private System.Windows.Forms.DataGridView dgvConsultaInspecciones;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtNumeroRenta;
        private System.Windows.Forms.Label lblNumeroRenta;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.TextBox txtNumeroInspeccion;
        private System.Windows.Forms.Label lblNumeroInspeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoInspeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inspeccionesDTOBindingSource;
        private System.Windows.Forms.ComboBox cbxTipoInspeccion;
        private System.Windows.Forms.NumericUpDown nudCantidadCombustible;
    }
}
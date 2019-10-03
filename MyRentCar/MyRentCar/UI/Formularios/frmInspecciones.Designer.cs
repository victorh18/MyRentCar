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
            this.tsInspeccion = new System.Windows.Forms.ToolStrip();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtNumeroRenta = new System.Windows.Forms.TextBox();
            this.lblNumeroRenta = new System.Windows.Forms.Label();
            this.dtpFechaInspeccion = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtInspeccion = new System.Windows.Forms.TextBox();
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
            this.chkGomaTraseraDerecha = new System.Windows.Forms.CheckBox();
            this.chkGomaFronteraDerecha = new System.Windows.Forms.CheckBox();
            this.chkGomaTraseraIzquierda = new System.Windows.Forms.CheckBox();
            this.chkGomaFronteraIzquierda = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCantidadCombustible = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.chkTieneRoturasCristal = new System.Windows.Forms.CheckBox();
            this.chkTieneGato = new System.Windows.Forms.CheckBox();
            this.TchkTieneRayadura = new System.Windows.Forms.CheckBox();
            this.ckhTieneGomaRepuesto = new System.Windows.Forms.CheckBox();
            this.dgvConsultaInspecciones = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.lblNumeroInspeccion = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.tsInspeccion.SuspendLayout();
            this.grbDatosGenerales.SuspendLayout();
            this.grbDatosInspeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaInspecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tsInspeccion
            // 
            this.tsInspeccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tsInspeccion.Location = new System.Drawing.Point(0, 0);
            this.tsInspeccion.Name = "tsInspeccion";
            this.tsInspeccion.Size = new System.Drawing.Size(953, 25);
            this.tsInspeccion.TabIndex = 0;
            this.tsInspeccion.Text = "toolStrip1";
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
            this.grbDatosGenerales.Controls.Add(this.txt);
            this.grbDatosGenerales.Controls.Add(this.lblNumeroInspeccion);
            this.grbDatosGenerales.Controls.Add(this.txtNumeroRenta);
            this.grbDatosGenerales.Controls.Add(this.lblNumeroRenta);
            this.grbDatosGenerales.Controls.Add(this.dtpFechaInspeccion);
            this.grbDatosGenerales.Controls.Add(this.lblFecha);
            this.grbDatosGenerales.Controls.Add(this.chkEstado);
            this.grbDatosGenerales.Controls.Add(this.txtInspeccion);
            this.grbDatosGenerales.Controls.Add(this.txtEmpleado);
            this.grbDatosGenerales.Controls.Add(this.txtCliente);
            this.grbDatosGenerales.Controls.Add(this.txtVehiculo);
            this.grbDatosGenerales.Controls.Add(this.txtPlacaVehiculo);
            this.grbDatosGenerales.Controls.Add(this.lblTipoInspeccion);
            this.grbDatosGenerales.Controls.Add(this.lblEmpleado);
            this.grbDatosGenerales.Controls.Add(this.lblCliente);
            this.grbDatosGenerales.Controls.Add(this.lblVehiculo);
            this.grbDatosGenerales.Controls.Add(this.lblPlacaVehiculo);
            this.grbDatosGenerales.Location = new System.Drawing.Point(13, 86);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(928, 135);
            this.grbDatosGenerales.TabIndex = 2;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Generales";
            // 
            // txtNumeroRenta
            // 
            this.txtNumeroRenta.Location = new System.Drawing.Point(716, 89);
            this.txtNumeroRenta.Name = "txtNumeroRenta";
            this.txtNumeroRenta.Size = new System.Drawing.Size(110, 20);
            this.txtNumeroRenta.TabIndex = 16;
            // 
            // lblNumeroRenta
            // 
            this.lblNumeroRenta.AutoSize = true;
            this.lblNumeroRenta.Location = new System.Drawing.Point(713, 73);
            this.lblNumeroRenta.Name = "lblNumeroRenta";
            this.lblNumeroRenta.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroRenta.TabIndex = 15;
            this.lblNumeroRenta.Text = "No. Renta";
            // 
            // dtpFechaInspeccion
            // 
            this.dtpFechaInspeccion.Location = new System.Drawing.Point(716, 41);
            this.dtpFechaInspeccion.Name = "dtpFechaInspeccion";
            this.dtpFechaInspeccion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInspeccion.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(713, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha Inspección:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(845, 92);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 12;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtInspeccion
            // 
            this.txtInspeccion.Location = new System.Drawing.Point(18, 89);
            this.txtInspeccion.Name = "txtInspeccion";
            this.txtInspeccion.Size = new System.Drawing.Size(201, 20);
            this.txtInspeccion.TabIndex = 11;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(482, 89);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(206, 20);
            this.txtEmpleado.TabIndex = 10;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(248, 89);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(201, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtVehiculo.Location = new System.Drawing.Point(482, 41);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(201, 20);
            this.txtVehiculo.TabIndex = 7;
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(248, 41);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(201, 20);
            this.txtPlacaVehiculo.TabIndex = 6;
            // 
            // lblTipoInspeccion
            // 
            this.lblTipoInspeccion.AutoSize = true;
            this.lblTipoInspeccion.Location = new System.Drawing.Point(15, 73);
            this.lblTipoInspeccion.Name = "lblTipoInspeccion";
            this.lblTipoInspeccion.Size = new System.Drawing.Size(86, 13);
            this.lblTipoInspeccion.TabIndex = 5;
            this.lblTipoInspeccion.Text = "Tipo Inspección:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(482, 73);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(97, 13);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Nombre Empleado:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(245, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre Cliente:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(479, 25);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculo.TabIndex = 1;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(245, 25);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(83, 13);
            this.lblPlacaVehiculo.TabIndex = 0;
            this.lblPlacaVehiculo.Text = "Placa Vehículo:";
            // 
            // grbDatosInspeccion
            // 
            this.grbDatosInspeccion.Controls.Add(this.chkGomaTraseraDerecha);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaFronteraDerecha);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaTraseraIzquierda);
            this.grbDatosInspeccion.Controls.Add(this.chkGomaFronteraIzquierda);
            this.grbDatosInspeccion.Controls.Add(this.txtObservaciones);
            this.grbDatosInspeccion.Controls.Add(this.lblObservaciones);
            this.grbDatosInspeccion.Controls.Add(this.lblCantidadCombustible);
            this.grbDatosInspeccion.Controls.Add(this.maskedTextBox1);
            this.grbDatosInspeccion.Controls.Add(this.chkTieneRoturasCristal);
            this.grbDatosInspeccion.Controls.Add(this.chkTieneGato);
            this.grbDatosInspeccion.Controls.Add(this.TchkTieneRayadura);
            this.grbDatosInspeccion.Controls.Add(this.ckhTieneGomaRepuesto);
            this.grbDatosInspeccion.Location = new System.Drawing.Point(17, 237);
            this.grbDatosInspeccion.Name = "grbDatosInspeccion";
            this.grbDatosInspeccion.Size = new System.Drawing.Size(924, 147);
            this.grbDatosInspeccion.TabIndex = 3;
            this.grbDatosInspeccion.TabStop = false;
            this.grbDatosInspeccion.Text = "Datos Inspección";
            // 
            // chkGomaTraseraDerecha
            // 
            this.chkGomaTraseraDerecha.AutoSize = true;
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
            this.chkGomaFronteraIzquierda.Location = new System.Drawing.Point(295, 43);
            this.chkGomaFronteraIzquierda.Name = "chkGomaFronteraIzquierda";
            this.chkGomaFronteraIzquierda.Size = new System.Drawing.Size(142, 17);
            this.chkGomaFronteraIzquierda.TabIndex = 11;
            this.chkGomaFronteraIzquierda.Text = "Goma Frontera Izquierda";
            this.chkGomaFronteraIzquierda.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(14, 99);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(705, 33);
            this.txtObservaciones.TabIndex = 10;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(11, 83);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblCantidadCombustible
            // 
            this.lblCantidadCombustible.AutoSize = true;
            this.lblCantidadCombustible.Location = new System.Drawing.Point(11, 29);
            this.lblCantidadCombustible.Name = "lblCantidadCombustible";
            this.lblCantidadCombustible.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadCombustible.TabIndex = 5;
            this.lblCantidadCombustible.Text = "Cantidad Combustible:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 45);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // chkTieneRoturasCristal
            // 
            this.chkTieneRoturasCristal.AutoSize = true;
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
            this.chkTieneGato.Location = new System.Drawing.Point(764, 92);
            this.chkTieneGato.Name = "chkTieneGato";
            this.chkTieneGato.Size = new System.Drawing.Size(79, 17);
            this.chkTieneGato.TabIndex = 2;
            this.chkTieneGato.Text = "Tiene Gato";
            this.chkTieneGato.UseVisualStyleBackColor = true;
            // 
            // TchkTieneRayadura
            // 
            this.TchkTieneRayadura.AutoSize = true;
            this.TchkTieneRayadura.Location = new System.Drawing.Point(764, 69);
            this.TchkTieneRayadura.Name = "TchkTieneRayadura";
            this.TchkTieneRayadura.Size = new System.Drawing.Size(102, 17);
            this.TchkTieneRayadura.TabIndex = 1;
            this.TchkTieneRayadura.Text = "Tiene Rayadura";
            this.TchkTieneRayadura.UseVisualStyleBackColor = true;
            // 
            // ckhTieneGomaRepuesto
            // 
            this.ckhTieneGomaRepuesto.AutoSize = true;
            this.ckhTieneGomaRepuesto.Location = new System.Drawing.Point(764, 45);
            this.ckhTieneGomaRepuesto.Name = "ckhTieneGomaRepuesto";
            this.ckhTieneGomaRepuesto.Size = new System.Drawing.Size(133, 17);
            this.ckhTieneGomaRepuesto.TabIndex = 0;
            this.ckhTieneGomaRepuesto.Text = "Tiene Goma Repuesto";
            this.ckhTieneGomaRepuesto.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaInspecciones
            // 
            this.dgvConsultaInspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaInspecciones.Location = new System.Drawing.Point(13, 426);
            this.dgvConsultaInspecciones.Name = "dgvConsultaInspecciones";
            this.dgvConsultaInspecciones.Size = new System.Drawing.Size(928, 147);
            this.dgvConsultaInspecciones.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(893, 20);
            this.textBox1.TabIndex = 8;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::MyRentCar.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
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
            // lblNumeroInspeccion
            // 
            this.lblNumeroInspeccion.AutoSize = true;
            this.lblNumeroInspeccion.Location = new System.Drawing.Point(15, 25);
            this.lblNumeroInspeccion.Name = "lblNumeroInspeccion";
            this.lblNumeroInspeccion.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroInspeccion.TabIndex = 17;
            this.lblNumeroInspeccion.Text = "No. Inspeccion";
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.SystemColors.Info;
            this.txt.Location = new System.Drawing.Point(18, 41);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(201, 20);
            this.txt.TabIndex = 18;
            // 
            // frmInspecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 585);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvConsultaInspecciones);
            this.Controls.Add(this.grbDatosInspeccion);
            this.Controls.Add(this.grbDatosGenerales);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tsInspeccion);
            this.Name = "frmInspecciones";
            this.Text = "Registro de Inspecciones";
            this.tsInspeccion.ResumeLayout(false);
            this.tsInspeccion.PerformLayout();
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            this.grbDatosInspeccion.ResumeLayout(false);
            this.grbDatosInspeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaInspecciones)).EndInit();
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
        private System.Windows.Forms.TextBox txtInspeccion;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox chkTieneRoturasCristal;
        private System.Windows.Forms.CheckBox chkTieneGato;
        private System.Windows.Forms.CheckBox TchkTieneRayadura;
        private System.Windows.Forms.CheckBox ckhTieneGomaRepuesto;
        private System.Windows.Forms.CheckBox chkGomaTraseraDerecha;
        private System.Windows.Forms.CheckBox chkGomaFronteraDerecha;
        private System.Windows.Forms.CheckBox chkGomaTraseraIzquierda;
        private System.Windows.Forms.CheckBox chkGomaFronteraIzquierda;
        private System.Windows.Forms.DataGridView dgvConsultaInspecciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumeroRenta;
        private System.Windows.Forms.Label lblNumeroRenta;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label lblNumeroInspeccion;
    }
}
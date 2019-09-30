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
            this.tlspRentas = new System.Windows.Forms.ToolStrip();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbDatosRenta = new System.Windows.Forms.GroupBox();
            this.lblNumeroRenta = new System.Windows.Forms.Label();
            this.txtNumeroRenta = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblPlacaVehiculo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblMontoDia = new System.Windows.Forms.Label();
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtFechaRenta = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
            this.txtMontoPorDias = new System.Windows.Forms.TextBox();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDiasRenta = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.grbDatosRenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlspRentas
            // 
            this.tlspRentas.Location = new System.Drawing.Point(0, 0);
            this.tlspRentas.Name = "tlspRentas";
            this.tlspRentas.Size = new System.Drawing.Size(953, 25);
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
            this.grbDatosRenta.Controls.Add(this.chkEstado);
            this.grbDatosRenta.Controls.Add(this.txtDiasRenta);
            this.grbDatosRenta.Controls.Add(this.txtCliente);
            this.grbDatosRenta.Controls.Add(this.txtPlacaVehiculo);
            this.grbDatosRenta.Controls.Add(this.txtMontoPorDias);
            this.grbDatosRenta.Controls.Add(this.txtFechaDevolucion);
            this.grbDatosRenta.Controls.Add(this.txtEmpleado);
            this.grbDatosRenta.Controls.Add(this.txtFechaRenta);
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
            this.grbDatosRenta.Size = new System.Drawing.Size(924, 224);
            this.grbDatosRenta.TabIndex = 2;
            this.grbDatosRenta.TabStop = false;
            this.grbDatosRenta.Text = "Datos Renta";
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
            // txtNumeroRenta
            // 
            this.txtNumeroRenta.Location = new System.Drawing.Point(22, 42);
            this.txtNumeroRenta.Name = "txtNumeroRenta";
            this.txtNumeroRenta.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroRenta.TabIndex = 1;
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
            // lblPlacaVehiculo
            // 
            this.lblPlacaVehiculo.AutoSize = true;
            this.lblPlacaVehiculo.Location = new System.Drawing.Point(415, 26);
            this.lblPlacaVehiculo.Name = "lblPlacaVehiculo";
            this.lblPlacaVehiculo.Size = new System.Drawing.Size(83, 13);
            this.lblPlacaVehiculo.TabIndex = 3;
            this.lblPlacaVehiculo.Text = "Placa Vehículo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(617, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
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
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(212, 87);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(97, 13);
            this.lblFechaDevolucion.TabIndex = 6;
            this.lblFechaDevolucion.Text = "Fecha Devolución:";
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
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Location = new System.Drawing.Point(617, 87);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(93, 13);
            this.lblCantidadDias.TabIndex = 8;
            this.lblCantidadDias.Text = "Cantidad de Días:";
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
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(19, 154);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(899, 64);
            this.txtComentario.TabIndex = 10;
            // 
            // txtFechaRenta
            // 
            this.txtFechaRenta.Location = new System.Drawing.Point(22, 103);
            this.txtFechaRenta.Name = "txtFechaRenta";
            this.txtFechaRenta.Size = new System.Drawing.Size(170, 20);
            this.txtFechaRenta.TabIndex = 11;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(215, 43);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(174, 20);
            this.txtEmpleado.TabIndex = 12;
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Location = new System.Drawing.Point(215, 103);
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.Size = new System.Drawing.Size(174, 20);
            this.txtFechaDevolucion.TabIndex = 13;
            // 
            // txtMontoPorDias
            // 
            this.txtMontoPorDias.Location = new System.Drawing.Point(418, 103);
            this.txtMontoPorDias.Name = "txtMontoPorDias";
            this.txtMontoPorDias.Size = new System.Drawing.Size(167, 20);
            this.txtMontoPorDias.TabIndex = 14;
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(418, 43);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(167, 20);
            this.txtPlacaVehiculo.TabIndex = 15;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(620, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(163, 20);
            this.txtCliente.TabIndex = 16;
            // 
            // txtDiasRenta
            // 
            this.txtDiasRenta.Location = new System.Drawing.Point(620, 103);
            this.txtDiasRenta.Name = "txtDiasRenta";
            this.txtDiasRenta.Size = new System.Drawing.Size(163, 20);
            this.txtDiasRenta.TabIndex = 17;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(823, 74);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 18;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(17, 323);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(879, 20);
            this.txtBusqueda.TabIndex = 19;
            // 
            // frmRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 585);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbDatosRenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tlspRentas);
            this.Name = "frmRentas";
            this.Text = "Registro de Rentas";
            this.grbDatosRenta.ResumeLayout(false);
            this.grbDatosRenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlspRentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbDatosRenta;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtDiasRenta;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.TextBox txtMontoPorDias;
        private System.Windows.Forms.TextBox txtFechaDevolucion;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtFechaRenta;
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
    }
}
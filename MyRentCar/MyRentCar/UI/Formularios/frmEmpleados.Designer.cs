namespace MyRentCar.UI.Formularios
{
    partial class frmEmpleados
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
            this.tsEmpleados = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.nudPorcientoComision = new System.Windows.Forms.NumericUpDown();
            this.cbxTandaLaboral = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblPorcientoComision = new System.Windows.Forms.Label();
            this.lblTandaLaboral = new System.Windows.Forms.Label();
            this.clblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tandaLaboralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.tsEmpleados.SuspendLayout();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcientoComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsEmpleados
            // 
            this.tsEmpleados.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsEmpleados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tsEmpleados.Location = new System.Drawing.Point(0, 0);
            this.tsEmpleados.Name = "tsEmpleados";
            this.tsEmpleados.Size = new System.Drawing.Size(912, 31);
            this.tsEmpleados.TabIndex = 0;
            this.tsEmpleados.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::MyRentCar.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(28, 28);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MyRentCar.Properties.Resources.Guardar;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Guardar";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::MyRentCar.Properties.Resources.Cancelar;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE EMPLEADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtCedula);
            this.grbCliente.Controls.Add(this.dtpFechaIngreso);
            this.grbCliente.Controls.Add(this.nudPorcientoComision);
            this.grbCliente.Controls.Add(this.cbxTandaLaboral);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.chkEstado);
            this.grbCliente.Controls.Add(this.lblFechaIngreso);
            this.grbCliente.Controls.Add(this.lblPorcientoComision);
            this.grbCliente.Controls.Add(this.lblTandaLaboral);
            this.grbCliente.Controls.Add(this.clblCedula);
            this.grbCliente.Controls.Add(this.lblNombre);
            this.grbCliente.Location = new System.Drawing.Point(13, 74);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.grbCliente.Size = new System.Drawing.Size(892, 148);
            this.grbCliente.TabIndex = 2;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(296, 42);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(258, 20);
            this.txtCedula.TabIndex = 11;
            this.txtCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(296, 96);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(258, 20);
            this.dtpFechaIngreso.TabIndex = 10;
            // 
            // nudPorcientoComision
            // 
            this.nudPorcientoComision.Location = new System.Drawing.Point(26, 96);
            this.nudPorcientoComision.Name = "nudPorcientoComision";
            this.nudPorcientoComision.Size = new System.Drawing.Size(226, 20);
            this.nudPorcientoComision.TabIndex = 9;
            // 
            // cbxTandaLaboral
            // 
            this.cbxTandaLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTandaLaboral.FormattingEnabled = true;
            this.cbxTandaLaboral.Items.AddRange(new object[] {
            "MATUTINA",
            "VESPERTINA",
            "NOCTURNA"});
            this.cbxTandaLaboral.Location = new System.Drawing.Point(591, 41);
            this.cbxTandaLaboral.Name = "cbxTandaLaboral";
            this.cbxTandaLaboral.Size = new System.Drawing.Size(238, 21);
            this.cbxTandaLaboral.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(26, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(686, 96);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(296, 79);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(78, 13);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblPorcientoComision
            // 
            this.lblPorcientoComision.AutoSize = true;
            this.lblPorcientoComision.Location = new System.Drawing.Point(23, 79);
            this.lblPorcientoComision.Name = "lblPorcientoComision";
            this.lblPorcientoComision.Size = new System.Drawing.Size(100, 13);
            this.lblPorcientoComision.TabIndex = 3;
            this.lblPorcientoComision.Text = "Porciento Comisión:";
            // 
            // lblTandaLaboral
            // 
            this.lblTandaLaboral.AutoSize = true;
            this.lblTandaLaboral.Location = new System.Drawing.Point(588, 25);
            this.lblTandaLaboral.Name = "lblTandaLaboral";
            this.lblTandaLaboral.Size = new System.Drawing.Size(79, 13);
            this.lblTandaLaboral.TabIndex = 2;
            this.lblTandaLaboral.Text = "Tanda Laboral:";
            // 
            // clblCedula
            // 
            this.clblCedula.AutoSize = true;
            this.clblCedula.Location = new System.Drawing.Point(293, 25);
            this.clblCedula.Name = "clblCedula";
            this.clblCedula.Size = new System.Drawing.Size(43, 13);
            this.clblCedula.TabIndex = 1;
            this.clblCedula.Text = "Cédula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.tandaLaboralDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvEmpleados.DataSource = this.empleadoBindingSource;
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 285);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(887, 152);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellDoubleClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 300;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "CÉDULA";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tandaLaboralDataGridViewTextBoxColumn
            // 
            this.tandaLaboralDataGridViewTextBoxColumn.DataPropertyName = "TandaLaboral";
            this.tandaLaboralDataGridViewTextBoxColumn.HeaderText = "TANDA LABORAL";
            this.tandaLaboralDataGridViewTextBoxColumn.Name = "tandaLaboralDataGridViewTextBoxColumn";
            this.tandaLaboralDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FECHA INGRESO";
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ACTIVO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(MyRentCar.Data.Modelos.Empleado);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(13, 259);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(851, 20);
            this.txtBusqueda.TabIndex = 4;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 449);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsEmpleados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmpleados";
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.tsEmpleados.ResumeLayout(false);
            this.tsEmpleados.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcientoComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.NumericUpDown nudPorcientoComision;
        private System.Windows.Forms.ComboBox cbxTandaLaboral;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblPorcientoComision;
        private System.Windows.Forms.Label lblTandaLaboral;
        private System.Windows.Forms.Label clblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tandaLaboralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.MaskedTextBox txtCedula;
    }
}
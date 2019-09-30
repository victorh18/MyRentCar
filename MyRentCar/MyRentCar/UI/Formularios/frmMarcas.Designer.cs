namespace MyRentCar.UI.Formularios
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.tsMarcas = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbMarca = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroMarca = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNumeroMarca = new System.Windows.Forms.Label();
            this.grbModelos = new System.Windows.Forms.GroupBox();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tsMarcas.SuspendLayout();
            this.grbMarca.SuspendLayout();
            this.grbModelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMarcas
            // 
            this.tsMarcas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbEliminar,
            this.tsbBuscar});
            this.tsMarcas.Location = new System.Drawing.Point(0, 0);
            this.tsMarcas.Name = "tsMarcas";
            this.tsMarcas.Size = new System.Drawing.Size(916, 25);
            this.tsMarcas.TabIndex = 0;
            this.tsMarcas.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Nuevo";
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
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = global::MyRentCar.Properties.Resources.Buscar;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.TsbBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(896, 53);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRO DE MARCAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // grbMarca
            // 
            this.grbMarca.Controls.Add(this.txtDescripcion);
            this.grbMarca.Controls.Add(this.txtNumeroMarca);
            this.grbMarca.Controls.Add(this.chkEstado);
            this.grbMarca.Controls.Add(this.lblDescripcion);
            this.grbMarca.Controls.Add(this.lblNumeroMarca);
            this.grbMarca.Location = new System.Drawing.Point(16, 82);
            this.grbMarca.Name = "grbMarca";
            this.grbMarca.Size = new System.Drawing.Size(888, 74);
            this.grbMarca.TabIndex = 2;
            this.grbMarca.TabStop = false;
            this.grbMarca.Text = "Datos Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(277, 36);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(364, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtNumeroMarca
            // 
            this.txtNumeroMarca.Location = new System.Drawing.Point(10, 36);
            this.txtNumeroMarca.Name = "txtNumeroMarca";
            this.txtNumeroMarca.ReadOnly = true;
            this.txtNumeroMarca.Size = new System.Drawing.Size(198, 20);
            this.txtNumeroMarca.TabIndex = 3;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(738, 36);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(274, 20);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNumeroMarca
            // 
            this.lblNumeroMarca.AutoSize = true;
            this.lblNumeroMarca.Location = new System.Drawing.Point(7, 20);
            this.lblNumeroMarca.Name = "lblNumeroMarca";
            this.lblNumeroMarca.Size = new System.Drawing.Size(60, 13);
            this.lblNumeroMarca.TabIndex = 0;
            this.lblNumeroMarca.Text = "No. Marca:";
            // 
            // grbModelos
            // 
            this.grbModelos.Controls.Add(this.dgvModelos);
            this.grbModelos.Location = new System.Drawing.Point(16, 189);
            this.grbModelos.Name = "grbModelos";
            this.grbModelos.Size = new System.Drawing.Size(888, 276);
            this.grbModelos.TabIndex = 3;
            this.grbModelos.TabStop = false;
            this.grbModelos.Text = "Modelos";
            // 
            // dgvModelos
            // 
            this.dgvModelos.AutoGenerateColumns = false;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.TipoVehiculo});
            this.dgvModelos.DataSource = this.modeloBindingSource;
            this.dgvModelos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvModelos.Location = new System.Drawing.Point(10, 20);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.Size = new System.Drawing.Size(872, 250);
            this.dgvModelos.TabIndex = 0;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "TipoVehiculo";
            this.dataGridViewComboBoxColumn1.HeaderText = "TIPO VEHICULO";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // tipoVehiculoBindingSource
            // 
            this.tipoVehiculoBindingSource.DataSource = typeof(MyRentCar.Data.Modelos.TipoVehiculo);
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(MyRentCar.Data.Modelos.Modelo);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "NO. MODELO";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 420;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.DataPropertyName = "IdTipoVehiculo";
            this.TipoVehiculo.DataSource = this.tipoVehiculoBindingSource;
            this.TipoVehiculo.DisplayMember = "Descripcion";
            this.TipoVehiculo.HeaderText = "TIPO VEHICULO";
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.ValueMember = "Id";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 477);
            this.Controls.Add(this.grbModelos);
            this.Controls.Add(this.grbMarca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tsMarcas);
            this.Name = "frmMarcas";
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.FrmMarcas_Load);
            this.tsMarcas.ResumeLayout(false);
            this.tsMarcas.PerformLayout();
            this.grbMarca.ResumeLayout(false);
            this.grbMarca.PerformLayout();
            this.grbModelos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMarcas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumeroMarca;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNumeroMarca;
        private System.Windows.Forms.GroupBox grbModelos;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.BindingSource tipoVehiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    }
}
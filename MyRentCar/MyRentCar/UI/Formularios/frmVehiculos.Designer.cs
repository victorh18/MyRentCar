namespace MyRentCar.UI.Formularios
{
    partial class frmVehiculos
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
            this.grbMarca = new System.Windows.Forms.GroupBox();
            this.cbxCombustible = new System.Windows.Forms.ComboBox();
            this.txtNumeroChasis = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblNumeroPlaca = new System.Windows.Forms.Label();
            this.lblNumeroMotor = new System.Windows.Forms.Label();
            this.lblNumeroChasis = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tsVehiculos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbMarca.SuspendLayout();
            this.tsVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMarca
            // 
            this.grbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMarca.Controls.Add(this.cbxCombustible);
            this.grbMarca.Controls.Add(this.txtNumeroChasis);
            this.grbMarca.Controls.Add(this.txtDescripcion);
            this.grbMarca.Controls.Add(this.txtNumeroMotor);
            this.grbMarca.Controls.Add(this.txtNumeroPlaca);
            this.grbMarca.Controls.Add(this.txtModelo);
            this.grbMarca.Controls.Add(this.txtMarca);
            this.grbMarca.Controls.Add(this.chkEstado);
            this.grbMarca.Controls.Add(this.lblCombustible);
            this.grbMarca.Controls.Add(this.lblNumeroPlaca);
            this.grbMarca.Controls.Add(this.lblNumeroMotor);
            this.grbMarca.Controls.Add(this.lblNumeroChasis);
            this.grbMarca.Controls.Add(this.lblDescripcion);
            this.grbMarca.Controls.Add(this.lblModelo);
            this.grbMarca.Controls.Add(this.lblMarca);
            this.grbMarca.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbMarca.Location = new System.Drawing.Point(12, 90);
            this.grbMarca.Name = "grbMarca";
            this.grbMarca.Size = new System.Drawing.Size(899, 184);
            this.grbMarca.TabIndex = 1;
            this.grbMarca.TabStop = false;
            this.grbMarca.Text = "Vehículo";
            // 
            // cbxCombustible
            // 
            this.cbxCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCombustible.FormattingEnabled = true;
            this.cbxCombustible.Location = new System.Drawing.Point(546, 36);
            this.cbxCombustible.Name = "cbxCombustible";
            this.cbxCombustible.Size = new System.Drawing.Size(207, 21);
            this.cbxCombustible.TabIndex = 14;
            // 
            // txtNumeroChasis
            // 
            this.txtNumeroChasis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroChasis.Location = new System.Drawing.Point(546, 80);
            this.txtNumeroChasis.Name = "txtNumeroChasis";
            this.txtNumeroChasis.Size = new System.Drawing.Size(207, 20);
            this.txtNumeroChasis.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(10, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(883, 53);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtNumeroMotor
            // 
            this.txtNumeroMotor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroMotor.Location = new System.Drawing.Point(274, 79);
            this.txtNumeroMotor.Name = "txtNumeroMotor";
            this.txtNumeroMotor.Size = new System.Drawing.Size(222, 20);
            this.txtNumeroMotor.TabIndex = 11;
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroPlaca.Location = new System.Drawing.Point(10, 80);
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(222, 20);
            this.txtNumeroPlaca.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.BackColor = System.Drawing.SystemColors.Info;
            this.txtModelo.Location = new System.Drawing.Point(274, 37);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(222, 20);
            this.txtModelo.TabIndex = 9;
            this.txtModelo.DoubleClick += new System.EventHandler(this.TxtModelo_DoubleClick);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.BackColor = System.Drawing.SystemColors.Info;
            this.txtMarca.Location = new System.Drawing.Point(10, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(222, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // chkEstado
            // 
            this.chkEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEstado.AutoSize = true;
            this.chkEstado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkEstado.Location = new System.Drawing.Point(799, 62);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 7;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblCombustible
            // 
            this.lblCombustible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCombustible.Location = new System.Drawing.Point(543, 20);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(67, 13);
            this.lblCombustible.TabIndex = 6;
            this.lblCombustible.Text = "Combustible:";
            // 
            // lblNumeroPlaca
            // 
            this.lblNumeroPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroPlaca.AutoSize = true;
            this.lblNumeroPlaca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroPlaca.Location = new System.Drawing.Point(7, 63);
            this.lblNumeroPlaca.Name = "lblNumeroPlaca";
            this.lblNumeroPlaca.Size = new System.Drawing.Size(57, 13);
            this.lblNumeroPlaca.TabIndex = 5;
            this.lblNumeroPlaca.Text = "No. Placa:";
            // 
            // lblNumeroMotor
            // 
            this.lblNumeroMotor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroMotor.AutoSize = true;
            this.lblNumeroMotor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroMotor.Location = new System.Drawing.Point(271, 63);
            this.lblNumeroMotor.Name = "lblNumeroMotor";
            this.lblNumeroMotor.Size = new System.Drawing.Size(57, 13);
            this.lblNumeroMotor.TabIndex = 4;
            this.lblNumeroMotor.Text = "No. Motor:";
            // 
            // lblNumeroChasis
            // 
            this.lblNumeroChasis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroChasis.AutoSize = true;
            this.lblNumeroChasis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroChasis.Location = new System.Drawing.Point(543, 63);
            this.lblNumeroChasis.Name = "lblNumeroChasis";
            this.lblNumeroChasis.Size = new System.Drawing.Size(61, 13);
            this.lblNumeroChasis.TabIndex = 3;
            this.lblNumeroChasis.Text = "No. Chasis:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 108);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblModelo.Location = new System.Drawing.Point(271, 20);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMarca.Location = new System.Drawing.Point(7, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // tsVehiculos
            // 
            this.tsVehiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbEliminar});
            this.tsVehiculos.Location = new System.Drawing.Point(0, 0);
            this.tsVehiculos.Name = "tsVehiculos";
            this.tsVehiculos.Size = new System.Drawing.Size(923, 25);
            this.tsVehiculos.TabIndex = 2;
            this.tsVehiculos.Text = "toolStrip1";
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
            // dgvVehiculos
            // 
            this.dgvVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(12, 339);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(899, 173);
            this.dgvVehiculos.TabIndex = 3;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 313);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(855, 20);
            this.txtBusqueda.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(19, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(886, 53);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "REGISTRO DE VEHÍCULOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 524);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.tsVehiculos);
            this.Controls.Add(this.grbMarca);
            this.MinimumSize = new System.Drawing.Size(939, 563);
            this.Name = "frmVehiculos";
            this.Text = "Registro de vehículos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            this.grbMarca.ResumeLayout(false);
            this.grbMarca.PerformLayout();
            this.tsVehiculos.ResumeLayout(false);
            this.tsVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMarca;
        private System.Windows.Forms.ComboBox cbxCombustible;
        private System.Windows.Forms.TextBox txtNumeroChasis;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblNumeroPlaca;
        private System.Windows.Forms.Label lblNumeroMotor;
        private System.Windows.Forms.Label lblNumeroChasis;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ToolStrip tsVehiculos;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}
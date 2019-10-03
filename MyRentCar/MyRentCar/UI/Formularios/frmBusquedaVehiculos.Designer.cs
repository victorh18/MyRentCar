namespace MyRentCar.UI.Formularios
{
    partial class frmBusquedaVehiculos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.vehiculoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChasisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroMotorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(788, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BÚSQUEDA DE VEHÍCULOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.combustibleDataGridViewTextBoxColumn,
            this.numeroChasisDataGridViewTextBoxColumn,
            this.numeroMotorDataGridViewTextBoxColumn,
            this.numeroPlacaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.vehiculoDTOBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(13, 57);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(775, 381);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellDoubleClick);
            // 
            // vehiculoDTOBindingSource
            // 
            this.vehiculoDTOBindingSource.DataSource = typeof(MyRentCar.Utilitarios.DTOs.VehiculoDTO);
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // combustibleDataGridViewTextBoxColumn
            // 
            this.combustibleDataGridViewTextBoxColumn.DataPropertyName = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.HeaderText = "COMBUSTIBLE";
            this.combustibleDataGridViewTextBoxColumn.Name = "combustibleDataGridViewTextBoxColumn";
            this.combustibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroChasisDataGridViewTextBoxColumn
            // 
            this.numeroChasisDataGridViewTextBoxColumn.DataPropertyName = "NumeroChasis";
            this.numeroChasisDataGridViewTextBoxColumn.HeaderText = "NO. CHASIS";
            this.numeroChasisDataGridViewTextBoxColumn.Name = "numeroChasisDataGridViewTextBoxColumn";
            this.numeroChasisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroMotorDataGridViewTextBoxColumn
            // 
            this.numeroMotorDataGridViewTextBoxColumn.DataPropertyName = "NumeroMotor";
            this.numeroMotorDataGridViewTextBoxColumn.HeaderText = "NO. MOTOR";
            this.numeroMotorDataGridViewTextBoxColumn.Name = "numeroMotorDataGridViewTextBoxColumn";
            this.numeroMotorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroPlacaDataGridViewTextBoxColumn
            // 
            this.numeroPlacaDataGridViewTextBoxColumn.DataPropertyName = "NumeroPlaca";
            this.numeroPlacaDataGridViewTextBoxColumn.HeaderText = "NO. PLACA";
            this.numeroPlacaDataGridViewTextBoxColumn.Name = "numeroPlacaDataGridViewTextBoxColumn";
            this.numeroPlacaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmBusquedaVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBusquedaVehiculos";
            this.Text = "Búsqueda de Vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.BindingSource vehiculoDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChasisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMotorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}
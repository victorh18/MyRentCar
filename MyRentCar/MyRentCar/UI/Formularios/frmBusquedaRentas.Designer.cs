namespace MyRentCar.UI.Formularios
{
    partial class frmBusquedaRentas
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
            this.dgvRentas = new System.Windows.Forms.DataGridView();
            this.numeroRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(957, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BÚSQUEDA DE RENTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRentas
            // 
            this.dgvRentas.AllowUserToAddRows = false;
            this.dgvRentas.AllowUserToDeleteRows = false;
            this.dgvRentas.AutoGenerateColumns = false;
            this.dgvRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroRentaDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.vehiculoDataGridViewTextBoxColumn,
            this.placaVehiculoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn});
            this.dgvRentas.DataSource = this.rentaDTOBindingSource;
            this.dgvRentas.Location = new System.Drawing.Point(13, 66);
            this.dgvRentas.Name = "dgvRentas";
            this.dgvRentas.ReadOnly = true;
            this.dgvRentas.Size = new System.Drawing.Size(956, 372);
            this.dgvRentas.TabIndex = 1;
            this.dgvRentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRentas_CellContentClick);
            this.dgvRentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRentas_CellDoubleClick);
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
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            this.fechaRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            this.vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.HeaderText = "VEHÍCULO";
            this.vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            this.vehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehiculoDataGridViewTextBoxColumn.Width = 150;
            // 
            // placaVehiculoDataGridViewTextBoxColumn
            // 
            this.placaVehiculoDataGridViewTextBoxColumn.DataPropertyName = "PlacaVehiculo";
            this.placaVehiculoDataGridViewTextBoxColumn.HeaderText = "PLACA VEHICULO";
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
            // rentaDTOBindingSource
            // 
            this.rentaDTOBindingSource.DataSource = typeof(MyRentCar.Utilitarios.DTOs.RentaDTO);
            // 
            // frmBusquedaRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.dgvRentas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBusquedaRentas";
            this.Text = "Búsqueda de Rentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvRentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rentaDTOBindingSource;
    }
}
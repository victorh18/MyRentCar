namespace MyRentCar.UI.Formularios
{
    partial class frmTiposInspecciones
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
            this.dgvTiposInspecciones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipoInspeccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsTiposInspecciones = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposInspecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInspeccionBindingSource)).BeginInit();
            this.tsTiposInspecciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(788, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE TIPOS DE INSPECCIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTiposInspecciones
            // 
            this.dgvTiposInspecciones.AllowUserToAddRows = false;
            this.dgvTiposInspecciones.AllowUserToDeleteRows = false;
            this.dgvTiposInspecciones.AutoGenerateColumns = false;
            this.dgvTiposInspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposInspecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvTiposInspecciones.DataSource = this.tipoInspeccionBindingSource;
            this.dgvTiposInspecciones.Location = new System.Drawing.Point(4, 84);
            this.dgvTiposInspecciones.Name = "dgvTiposInspecciones";
            this.dgvTiposInspecciones.ReadOnly = true;
            this.dgvTiposInspecciones.Size = new System.Drawing.Size(784, 382);
            this.dgvTiposInspecciones.TabIndex = 1;
            this.dgvTiposInspecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTiposInspecciones_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "NO. TIPO";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tipoInspeccionBindingSource
            // 
            this.tipoInspeccionBindingSource.DataSource = typeof(MyRentCar.Data.Modelos.TipoInspeccion);
            // 
            // tsTiposInspecciones
            // 
            this.tsTiposInspecciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.tsTiposInspecciones.Location = new System.Drawing.Point(0, 0);
            this.tsTiposInspecciones.Name = "tsTiposInspecciones";
            this.tsTiposInspecciones.Size = new System.Drawing.Size(800, 25);
            this.tsTiposInspecciones.TabIndex = 2;
            this.tsTiposInspecciones.Text = "toolStrip1";
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
            // frmTiposInspecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.tsTiposInspecciones);
            this.Controls.Add(this.dgvTiposInspecciones);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmTiposInspecciones";
            this.Text = "Registro de Tipos de Inspecciones";
            this.Load += new System.EventHandler(this.FrmTiposInspecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposInspecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInspeccionBindingSource)).EndInit();
            this.tsTiposInspecciones.ResumeLayout(false);
            this.tsTiposInspecciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvTiposInspecciones;
        private System.Windows.Forms.ToolStrip tsTiposInspecciones;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoInspeccionBindingSource;
    }
}
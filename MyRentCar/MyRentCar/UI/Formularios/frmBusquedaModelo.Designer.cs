namespace MyRentCar.UI.Formularios
{
    partial class frmBusquedaModelo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.nombreMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoModeloDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modeloDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(889, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BÚSQUEDA DE MODELOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvModelos
            // 
            this.dgvModelos.AllowUserToAddRows = false;
            this.dgvModelos.AllowUserToDeleteRows = false;
            this.dgvModelos.AllowUserToResizeColumns = false;
            this.dgvModelos.AllowUserToResizeRows = false;
            this.dgvModelos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreMarcaDataGridViewTextBoxColumn,
            this.nombreModeloDataGridViewTextBoxColumn,
            this.estadoModeloDataGridViewCheckBoxColumn});
            this.dgvModelos.DataSource = this.modeloDTOBindingSource;
            this.dgvModelos.Location = new System.Drawing.Point(4, 85);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.Size = new System.Drawing.Size(885, 353);
            this.dgvModelos.TabIndex = 1;
            this.dgvModelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModelos_CellDoubleClick);
            // 
            // nombreMarcaDataGridViewTextBoxColumn
            // 
            this.nombreMarcaDataGridViewTextBoxColumn.DataPropertyName = "NombreMarca";
            this.nombreMarcaDataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.nombreMarcaDataGridViewTextBoxColumn.Name = "nombreMarcaDataGridViewTextBoxColumn";
            this.nombreMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMarcaDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreModeloDataGridViewTextBoxColumn
            // 
            this.nombreModeloDataGridViewTextBoxColumn.DataPropertyName = "NombreModelo";
            this.nombreModeloDataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.nombreModeloDataGridViewTextBoxColumn.Name = "nombreModeloDataGridViewTextBoxColumn";
            this.nombreModeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreModeloDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoModeloDataGridViewCheckBoxColumn
            // 
            this.estadoModeloDataGridViewCheckBoxColumn.DataPropertyName = "EstadoModelo";
            this.estadoModeloDataGridViewCheckBoxColumn.HeaderText = "ACTIVO";
            this.estadoModeloDataGridViewCheckBoxColumn.Name = "estadoModeloDataGridViewCheckBoxColumn";
            this.estadoModeloDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // modeloDTOBindingSource
            // 
            this.modeloDTOBindingSource.DataSource = typeof(MyRentCar.Utilitarios.DTOs.ModeloDTO);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(4, 59);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(885, 20);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // frmBusquedaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBusquedaModelo";
            this.Text = "frmBusquedaModelo";
            this.Load += new System.EventHandler(this.FrmBusquedaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoModeloDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource modeloDTOBindingSource;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}
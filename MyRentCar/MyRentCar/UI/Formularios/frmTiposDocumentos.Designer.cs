namespace MyRentCar.UI.Formularios
{
    partial class frmTiposDocumentos
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
            this.tsTiposDocumentos = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.dgvTiposDocumentos = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsTiposDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(867, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE TIPOS DE DOCUMENTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsTiposDocumentos
            // 
            this.tsTiposDocumentos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTiposDocumentos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.tsTiposDocumentos.Location = new System.Drawing.Point(0, 0);
            this.tsTiposDocumentos.Name = "tsTiposDocumentos";
            this.tsTiposDocumentos.Size = new System.Drawing.Size(893, 31);
            this.tsTiposDocumentos.TabIndex = 1;
            this.tsTiposDocumentos.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::MyRentCar.Properties.Resources.Guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(28, 28);
            this.tsbGuardar.Text = "toolStripButton1";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // dgvTiposDocumentos
            // 
            this.dgvTiposDocumentos.AutoGenerateColumns = false;
            this.dgvTiposDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvTiposDocumentos.DataSource = this.tipoDocumentoBindingSource;
            this.dgvTiposDocumentos.Location = new System.Drawing.Point(18, 88);
            this.dgvTiposDocumentos.Name = "dgvTiposDocumentos";
            this.dgvTiposDocumentos.RowTemplate.Height = 28;
            this.dgvTiposDocumentos.Size = new System.Drawing.Size(861, 350);
            this.dgvTiposDocumentos.TabIndex = 2;
            this.dgvTiposDocumentos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTiposDocumentos_UserDeletingRow);
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 500;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataSource = typeof(MyRentCar.Data.Modelos.TipoDocumento);
            // 
            // frmTiposDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.dgvTiposDocumentos);
            this.Controls.Add(this.tsTiposDocumentos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmTiposDocumentos";
            this.Text = "Registro de Tipos de Documentos";
            this.Load += new System.EventHandler(this.frmTiposDocumentos_Load);
            this.tsTiposDocumentos.ResumeLayout(false);
            this.tsTiposDocumentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStrip tsTiposDocumentos;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.DataGridView dgvTiposDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
    }
}
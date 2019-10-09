namespace MyRentCar.UI.Formularios
{
    partial class frmCombustibles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsCombustibles = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCombustibles = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipoCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsCombustibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombustibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCombustibleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsCombustibles
            // 
            this.tsCombustibles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.tsCombustibles.Location = new System.Drawing.Point(0, 0);
            this.tsCombustibles.Name = "tsCombustibles";
            this.tsCombustibles.Size = new System.Drawing.Size(925, 25);
            this.tsCombustibles.TabIndex = 0;
            this.tsCombustibles.Text = "toolStrip1";
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
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(896, 53);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRO DE COMBUSTIBLES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCombustibles
            // 
            this.dgvCombustibles.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCombustibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCombustibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombustibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvCombustibles.DataSource = this.tipoCombustibleBindingSource;
            this.dgvCombustibles.Location = new System.Drawing.Point(17, 86);
            this.dgvCombustibles.Name = "dgvCombustibles";
            this.dgvCombustibles.Size = new System.Drawing.Size(896, 352);
            this.dgvCombustibles.TabIndex = 2;
            this.dgvCombustibles.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvCombustibles_UserDeletingRow);
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 500;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tipoCombustibleBindingSource
            // 
            this.tipoCombustibleBindingSource.DataSource = typeof(MyRentCar.Data.Modelos.TipoCombustible);
            // 
            // frmCombustibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.dgvCombustibles);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tsCombustibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCombustibles";
            this.Text = "frmCombustibles";
            this.Load += new System.EventHandler(this.FrmCombustibles_Load);
            this.tsCombustibles.ResumeLayout(false);
            this.tsCombustibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombustibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCombustibleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCombustibles;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCombustibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoCombustibleBindingSource;
    }
}
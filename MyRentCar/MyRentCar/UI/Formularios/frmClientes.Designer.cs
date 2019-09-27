namespace MyRentCar.UI.Formularios
{
    partial class frmClientes
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nudLimiteCredito = new System.Windows.Forms.NumericUpDown();
            this.txtTarjetaCredito = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblTarjetaCredito = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1380, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1344, 82);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "REGISTRO DE CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.comboBox1);
            this.grbCliente.Controls.Add(this.nudLimiteCredito);
            this.grbCliente.Controls.Add(this.txtTarjetaCredito);
            this.grbCliente.Controls.Add(this.txtNumeroDocumento);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.chkEstado);
            this.grbCliente.Controls.Add(this.lblLimiteCredito);
            this.grbCliente.Controls.Add(this.lblTarjetaCredito);
            this.grbCliente.Controls.Add(this.lblTipoDocumento);
            this.grbCliente.Controls.Add(this.lblNumeroDocumento);
            this.grbCliente.Controls.Add(this.lblNombre);
            this.grbCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbCliente.Location = new System.Drawing.Point(24, 126);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCliente.Size = new System.Drawing.Size(1338, 183);
            this.grbCliente.TabIndex = 2;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(914, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(414, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // nudLimiteCredito
            // 
            this.nudLimiteCredito.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nudLimiteCredito.Location = new System.Drawing.Point(484, 128);
            this.nudLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudLimiteCredito.Name = "nudLimiteCredito";
            this.nudLimiteCredito.Size = new System.Drawing.Size(378, 26);
            this.nudLimiteCredito.TabIndex = 9;
            // 
            // txtTarjetaCredito
            // 
            this.txtTarjetaCredito.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTarjetaCredito.Location = new System.Drawing.Point(20, 129);
            this.txtTarjetaCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarjetaCredito.Name = "txtTarjetaCredito";
            this.txtTarjetaCredito.Size = new System.Drawing.Size(426, 26);
            this.txtTarjetaCredito.TabIndex = 8;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(484, 57);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(376, 26);
            this.txtNumeroDocumento.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNombre.Location = new System.Drawing.Point(20, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(426, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chkEstado.Location = new System.Drawing.Point(1105, 128);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(78, 24);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLimiteCredito.Location = new System.Drawing.Point(480, 103);
            this.lblLimiteCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(110, 20);
            this.lblLimiteCredito.TabIndex = 4;
            this.lblLimiteCredito.Text = "Límite Crédito:";
            // 
            // lblTarjetaCredito
            // 
            this.lblTarjetaCredito.AutoSize = true;
            this.lblTarjetaCredito.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTarjetaCredito.Location = new System.Drawing.Point(15, 103);
            this.lblTarjetaCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjetaCredito.Name = "lblTarjetaCredito";
            this.lblTarjetaCredito.Size = new System.Drawing.Size(117, 20);
            this.lblTarjetaCredito.TabIndex = 3;
            this.lblTarjetaCredito.Text = "Tarjeta Crédito:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTipoDocumento.Location = new System.Drawing.Point(909, 31);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(130, 20);
            this.lblTipoDocumento.TabIndex = 2;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            this.lblTipoDocumento.Click += new System.EventHandler(this.LblTipoDocumento_Click);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(480, 31);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(124, 20);
            this.lblNumeroDocumento.TabIndex = 1;
            this.lblNumeroDocumento.Text = "No. Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNombre.Location = new System.Drawing.Point(10, 31);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 411);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1334, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1334, 26);
            this.textBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimiteCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblTarjetaCredito;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nudLimiteCredito;
        private System.Windows.Forms.TextBox txtTarjetaCredito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
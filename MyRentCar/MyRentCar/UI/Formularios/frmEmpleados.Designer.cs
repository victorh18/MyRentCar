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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.clblCedula = new System.Windows.Forms.Label();
            this.lblTandaLaboral = new System.Windows.Forms.Label();
            this.lblPorcientoComision = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cbxTandaLaboral = new System.Windows.Forms.ComboBox();
            this.nudPorcientoComision = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcientoComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(912, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.grbCliente.Controls.Add(this.dtpFechaIngreso);
            this.grbCliente.Controls.Add(this.nudPorcientoComision);
            this.grbCliente.Controls.Add(this.cbxTandaLaboral);
            this.grbCliente.Controls.Add(this.txtCedula);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.chkEstado);
            this.grbCliente.Controls.Add(this.lblFechaIngreso);
            this.grbCliente.Controls.Add(this.lblPorcientoComision);
            this.grbCliente.Controls.Add(this.lblTandaLaboral);
            this.grbCliente.Controls.Add(this.clblCedula);
            this.grbCliente.Controls.Add(this.lblNombre);
            this.grbCliente.Location = new System.Drawing.Point(13, 74);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCliente.Size = new System.Drawing.Size(892, 148);
            this.grbCliente.TabIndex = 2;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
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
            // clblCedula
            // 
            this.clblCedula.AutoSize = true;
            this.clblCedula.Location = new System.Drawing.Point(293, 25);
            this.clblCedula.Name = "clblCedula";
            this.clblCedula.Size = new System.Drawing.Size(43, 13);
            this.clblCedula.TabIndex = 1;
            this.clblCedula.Text = "Cédula:";
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
            // lblPorcientoComision
            // 
            this.lblPorcientoComision.AutoSize = true;
            this.lblPorcientoComision.Location = new System.Drawing.Point(23, 79);
            this.lblPorcientoComision.Name = "lblPorcientoComision";
            this.lblPorcientoComision.Size = new System.Drawing.Size(100, 13);
            this.lblPorcientoComision.TabIndex = 3;
            this.lblPorcientoComision.Text = "Porciento Comisión:";
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
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(591, 97);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(26, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(296, 41);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(258, 20);
            this.txtCedula.TabIndex = 7;
            // 
            // cbxTandaLaboral
            // 
            this.cbxTandaLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTandaLaboral.FormattingEnabled = true;
            this.cbxTandaLaboral.Location = new System.Drawing.Point(591, 41);
            this.cbxTandaLaboral.Name = "cbxTandaLaboral";
            this.cbxTandaLaboral.Size = new System.Drawing.Size(238, 21);
            this.cbxTandaLaboral.TabIndex = 8;
            // 
            // nudPorcientoComision
            // 
            this.nudPorcientoComision.Location = new System.Drawing.Point(26, 96);
            this.nudPorcientoComision.Name = "nudPorcientoComision";
            this.nudPorcientoComision.Size = new System.Drawing.Size(226, 20);
            this.nudPorcientoComision.TabIndex = 9;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(296, 96);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(258, 20);
            this.dtpFechaIngreso.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 152);
            this.dataGridView1.TabIndex = 3;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcientoComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.NumericUpDown nudPorcientoComision;
        private System.Windows.Forms.ComboBox cbxTandaLaboral;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblPorcientoComision;
        private System.Windows.Forms.Label lblTandaLaboral;
        private System.Windows.Forms.Label clblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}
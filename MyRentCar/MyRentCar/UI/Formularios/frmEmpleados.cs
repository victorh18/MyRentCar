using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.Logica.Controladores;
using MyRentCar.Data.Modelos;

namespace MyRentCar.UI.Formularios
{
    public partial class frmEmpleados : Form
    {
        private EmpleadoController controller;
        private Empleado empleado;
        public frmEmpleados()
        {
            InitializeComponent();
            controller = new EmpleadoController();
            CargarEmpleadosConsulta();
            
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
        }

        private void NuevoEmpleado()
        {
            empleado = new Empleado();
            //MostrarEmpleado(empleado);
            LimpiarCampos();
            HabilitarControles(true);
        }

        private void MostrarEmpleado(Empleado _empleado)
        {
            txtNombre.Text = _empleado?.Nombre ?? "";
            txtCedula.Text = _empleado?.Cedula ?? "";
            nudPorcientoComision.Value = _empleado?.PorcientoComision ?? 0;
            cbxTandaLaboral.SelectedText = _empleado?.TandaLaboral;
            chkEstado.Checked = _empleado?.Estado ?? false;
            dtpFechaIngreso.Value = _empleado.FechaIngreso;
        }

        private void LlenarEmpleado(Empleado _empleado)
        {
            _empleado.Nombre = txtNombre.Text;
            _empleado.Cedula = txtCedula.Text;
            _empleado.PorcientoComision = nudPorcientoComision.Value;
            _empleado.TandaLaboral = cbxTandaLaboral.Text;
            _empleado.Estado = chkEstado.Checked;
            _empleado.FechaIngreso = dtpFechaIngreso.Value;
        }

        private void HabilitarControles(bool valor)
        {
            txtNombre.Enabled = valor;
            txtCedula.Enabled = valor;
            nudPorcientoComision.Enabled = valor;
            cbxTandaLaboral.Enabled = valor;
            chkEstado.Enabled = valor;
            dtpFechaIngreso.Enabled = valor;
        }

        private void Guardar(Empleado _empleado)
        {
            controller.Guardar(_empleado);
            MessageBox.Show($"El empleado {_empleado.Nombre} ha sido guardado correctamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEmpleadosConsulta();
        }

        private void Eliminar(Empleado _empleado)
        {
            controller.Eliminar(_empleado);
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoEmpleado();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            nudPorcientoComision.Value = 0;
            cbxTandaLaboral.SelectedIndex = 0;
            chkEstado.Checked = true;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void CargarEmpleadosConsulta()
        {
            empleadoBindingSource.DataSource = controller.TraerEmpleados();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar al empleado actual?", "VERIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LlenarEmpleado(empleado);
                Guardar(empleado);

            }
        }

        private void DgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            empleado = empleadoBindingSource.Current as Empleado;
            MostrarEmpleado(empleado);
        }
    }
}

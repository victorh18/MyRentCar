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
        private List<Empleado> empleados;
        public frmEmpleados()
        {
            InitializeComponent();
            controller = new EmpleadoController();
            this.empleados = this.controller.TraerEmpleados();
            CargarEmpleadosConsulta(this.empleados);
            HabilitarControles(false);
            
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
        }

        private void NuevoEmpleado()
        {
            empleado = new Empleado();
            LimpiarCampos();
            HabilitarControles(true);
        }

        private void MostrarEmpleado(Empleado _empleado)
        {
            txtNombre.Text = _empleado?.Nombre ?? "";
            txtCedula.Text = _empleado?.Cedula ?? "";
            nudPorcientoComision.Value = _empleado?.PorcientoComision ?? 0;
            cbxTandaLaboral.SelectedItem = _empleado?.TandaLaboral;
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
            if (MessageBox.Show("¿Está seguro de que desea guardar el registro actual?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            { 
                controller.Guardar(_empleado);
                MessageBox.Show($"El empleado {_empleado.Nombre} ha sido guardado correctamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.empleados = controller.TraerEmpleados();
                CargarEmpleadosConsulta(this.empleados);

            }
            
        }

        private void Eliminar(Empleado _empleado)
        {
            if (this.empleado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado antes de eliminar.", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                controller.Eliminar(_empleado);
                this.empleados = controller.TraerEmpleados();
                this.CargarEmpleadosConsulta(this.empleados);
                MessageBox.Show("El empleado ha sido eliminado satisfactoriamente.", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
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

        private void CargarEmpleadosConsulta(List<Empleado> empleados)
        {
            empleadoBindingSource.DataSource = empleados;
        }

        private void DgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.empleado = empleadoBindingSource.Current as Empleado;
            MostrarEmpleado(this.empleado);
            HabilitarControles(true);
        }

        private bool Validar()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe digitar el nombre del empleado.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCedula.Text.Trim() == "")
            {
                MessageBox.Show("Debe digitar la cédula del empleado.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cbxTandaLaboral.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una tanda laboral.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void TsEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                LlenarEmpleado(empleado);
                Guardar(empleado);
            }
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar al empleado actual?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Eliminar(this.empleado);
                LimpiarCampos();
                HabilitarControles(false);
                this.empleado = null;
                
            }
            
        }

        private List<Empleado> Filtrar(string busqueda)
        {
            return this.empleados.Where(e => (e.Nombre + e.Cedula).Contains(busqueda)).ToList();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarEmpleadosConsulta(this.Filtrar(txtBusqueda.Text));
        }
    }
}

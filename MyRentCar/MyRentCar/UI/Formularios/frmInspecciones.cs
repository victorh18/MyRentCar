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
using MyRentCar.Utilitarios.DTOs;

namespace MyRentCar.UI.Formularios
{
    public partial class frmInspecciones : Form
    {
        private InspeccionController controller;
        private List<Inspeccion> inspecciones;
        private Inspeccion inspeccion;
        public frmInspecciones()
        {
            InitializeComponent();
            this.controller = new InspeccionController();
            this.inspecciones = this.controller.TraerInspecciones();
            LimpiarCampos();
            HabilitarControles(false);
            CargarConsultaInspecciones(this.inspecciones);
            cbxTipoInspeccion.DataSource = this.controller.TraerTiposInspeccion();
            cbxTipoInspeccion.DisplayMember = "Descripcion";
            cbxTipoInspeccion.ValueMember = "Id";
        }

        private void HabilitarControles(bool valor)
        {
            txtNumeroInspeccion.Enabled = valor;
            txtNumeroRenta.Enabled = valor;
            txtPlacaVehiculo.Enabled = valor;
            txtVehiculo.Enabled = valor;
            cbxTipoInspeccion.Enabled = valor;
            txtCliente.Enabled = valor;
            txtEmpleado.Enabled = valor;
            dtpFechaInspeccion.Enabled = valor;
            chkEstado.Enabled = valor;
            nudCantidadCombustible.Enabled = valor;
            txtObservaciones.Enabled = valor;
            chkGomaFronteraDerecha.Enabled = valor;
            chkGomaFronteraIzquierda.Enabled = valor;
            chkGomaTraseraDerecha.Enabled = valor;
            chkGomaTraseraIzquierda.Enabled = valor;
            chkTieneGato.Enabled = valor;
            chkTieneRoturasCristal.Enabled = valor;
            chkTieneRayadura.Enabled = valor;
            chkTieneGomaRepuesto.Enabled = valor;
        }

        private void LimpiarCampos()
        {
            txtNumeroInspeccion.Text = "";
            txtNumeroRenta.Text = "";
            txtPlacaVehiculo.Text = "";
            txtVehiculo.Text = "";
            cbxTipoInspeccion.SelectedItem = null;
            txtCliente.Text = "";
            txtEmpleado.Text = "";
            dtpFechaInspeccion.Value = DateTime.Now;
            chkEstado.Checked = false;
            nudCantidadCombustible.Value = 0;
            txtObservaciones.Text = "";
            chkGomaFronteraDerecha.Checked = false;
            chkGomaFronteraIzquierda.Checked = false;
            chkGomaTraseraDerecha.Checked = false;
            chkGomaTraseraIzquierda.Checked = false;
            chkTieneGato.Checked = false;
            chkTieneRoturasCristal.Checked = false;
            chkTieneRayadura.Checked = false;
            chkTieneGomaRepuesto.Checked = false;
        }

        private void MostrarInspeccion(Inspeccion _inspeccion)
        {
            txtNumeroInspeccion.Text = _inspeccion?.Id.ToString() ?? "";
            txtNumeroRenta.Text = _inspeccion?.Renta?.Id.ToString() ?? "";
            txtPlacaVehiculo.Text = _inspeccion?.Vehiculo?.NumeroPlaca ?? "";
            txtVehiculo.Text = _inspeccion?.Vehiculo?.NombreVehiculo ?? "";
            cbxTipoInspeccion.SelectedItem = _inspeccion?.TipoInspeccion;
            txtCliente.Text = _inspeccion?.Renta?.Cliente?.Nombre ?? "";
            txtEmpleado.Text = _inspeccion?.Empleado?.Nombre;
            dtpFechaInspeccion.Value = _inspeccion?.Fecha ?? DateTime.MinValue;
            chkEstado.Checked = _inspeccion?.Estado ?? false;
            nudCantidadCombustible.Value = _inspeccion?.CantidadCombustible ?? 0;
            txtObservaciones.Text = _inspeccion?.Observaciones;
            chkGomaFronteraDerecha.Checked = _inspeccion?.GomaFronteraDerecha ?? false;
            chkGomaFronteraIzquierda.Checked = _inspeccion?.GomaFronteraIzquierda ?? false;
            chkGomaTraseraDerecha.Checked = _inspeccion?.GomaTraseraDerecha ?? false;
            chkGomaTraseraIzquierda.Checked = _inspeccion?.GomaTraseraIzquierda ?? false;
            chkTieneGato.Checked = _inspeccion?.TieneGato ?? false;
            chkTieneRoturasCristal.Checked = _inspeccion?.TieneRoturasCristal ?? false;
            chkTieneRayadura.Checked = _inspeccion?.TieneRayadura ?? false;
            chkTieneGomaRepuesto.Checked = _inspeccion?.TieneGomaRepuesto ?? false;
        }

        private void LlenarInspeccion(Inspeccion _inspeccion)
        {
            _inspeccion.TipoInspeccion = cbxTipoInspeccion.SelectedItem as TipoInspeccion;
            _inspeccion.Fecha = dtpFechaInspeccion.Value;
            _inspeccion.Estado = chkEstado.Checked;
            _inspeccion.CantidadCombustible = nudCantidadCombustible.Value;
            _inspeccion.Observaciones = txtObservaciones.Text;
            _inspeccion.GomaFronteraDerecha = chkGomaFronteraDerecha.Checked;
            _inspeccion.GomaFronteraIzquierda = chkGomaFronteraIzquierda.Checked;
            _inspeccion.GomaTraseraDerecha = chkGomaTraseraDerecha.Checked;
            _inspeccion.GomaTraseraIzquierda = chkGomaTraseraIzquierda.Checked;
            _inspeccion.TieneGato = chkTieneGato.Checked;
            _inspeccion.TieneRoturasCristal = chkTieneRoturasCristal.Checked;
            _inspeccion.TieneRayadura = chkTieneRayadura.Checked;
            _inspeccion.TieneGomaRepuesto = chkTieneGomaRepuesto.Checked;

        }

        private void NuevaInspeccion()
        {
            this.inspeccion = new Inspeccion();
            HabilitarControles(true);
            LimpiarCampos();
        }

        private void Guardar(Inspeccion _inspeccion)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar esta inspección?", "GUARDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (this.Validar())
                {
                    LlenarInspeccion(this.inspeccion);
                    this.controller.Guardar(this.inspeccion);

                    MessageBox.Show("La inspección ha sido guardada exitosamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.inspecciones = this.controller.TraerInspecciones();
                    CargarConsultaInspecciones(this.inspecciones);
                }
                
            }
            
        }

        private void Eliminar(Inspeccion _inspeccion)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar la inspección actual?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (_inspeccion == null)
                {
                    MessageBox.Show("Debe seleccionar una inspección antes de eliminar.", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (controller.ExisteInspeccion(_inspeccion))
                    {
                        controller.Eliminar(_inspeccion);
                    }
                    LimpiarCampos();
                    HabilitarControles(false);
                    MessageBox.Show("La inspección ha sido eliminado exitosamente.", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.inspecciones = this.controller.TraerInspecciones();
                    this.inspeccion = null;
                    CargarConsultaInspecciones(this.inspecciones);
                }
                
            }

        }

        private void BuscarVehiculo()
        {
            frmBusquedaVehiculos f = new frmBusquedaVehiculos();
            f.ShowDialog();
            this.inspeccion.Vehiculo = this.controller.Buscar<Vehiculo>(f.Id);
            txtVehiculo.Text = this.inspeccion?.Vehiculo?.NombreVehiculo ?? "";
            txtPlacaVehiculo.Text = this.inspeccion?.Vehiculo?.NumeroPlaca ?? "";
        }

        private void BuscarEmpleado()
        {
            frmBusquedaEmpleado f = new frmBusquedaEmpleado();
            f.ShowDialog();
            this.inspeccion.Empleado = this.controller.Buscar<Empleado>(f.IdEmpleado);
            txtEmpleado.Text = this.inspeccion?.Empleado?.Nombre ?? "";
        }

        private void BuscarRenta()
        {
            frmBusquedaRentas f = new frmBusquedaRentas();
            f.ShowDialog();
            this.inspeccion.Renta = this.controller.Buscar<Renta>(f.IdRenta);
            txtNumeroRenta.Text = this.inspeccion?.Renta?.Id.ToString();
            txtCliente.Text = this.inspeccion?.Renta?.Cliente?.Nombre;
        }

        private void CargarConsultaInspecciones(List<Inspeccion> _inspecciones)
        {
            List<InspeccionesDTO> inspeccionesConsulta = new List<InspeccionesDTO>();
            foreach (Inspeccion inspeccion in _inspecciones)
            {
                inspeccionesConsulta.Add(new InspeccionesDTO(inspeccion));
            }
            this.inspeccionesDTOBindingSource.DataSource = inspeccionesConsulta;
        }

        private void FrmInspecciones_Load(object sender, EventArgs e)
        {

        }

        private void TxtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumeroRenta_DoubleClick(object sender, EventArgs e)
        {
            BuscarRenta();
        }

        private void TxtPlacaVehiculo_DoubleClick(object sender, EventArgs e)
        {
            BuscarVehiculo();
        }

        private void TxtVehiculo_DoubleClick(object sender, EventArgs e)
        {
            BuscarVehiculo();
        }

        private void TxtEmpleado_DoubleClick(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaInspeccion();
        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar(this.inspeccion);
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(this.inspeccion);
        }

        private void DgvConsultaInspecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.inspeccion = (inspeccionesDTOBindingSource.Current as InspeccionesDTO).Inspeccion;
            HabilitarControles(true);
            MostrarInspeccion(this.inspeccion);
        }

        private void TxtNumeroRenta_TextChanged(object sender, EventArgs e)
        {

        }

        private List<Inspeccion> Filtrar(string busqueda)
        {
            return this.inspecciones.Where(i => (i.Renta?.Cliente?.Nombre ?? "" + i.Empleado?.Nombre ?? "" + i.Vehiculo?.NombreVehiculo ?? "" + i.Vehiculo?.NumeroPlaca ?? "").Contains(busqueda)).ToList();
        }

        private bool Validar()
        {
            if (txtPlacaVehiculo.Text.Trim() == "" || txtVehiculo.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un vehículo válido", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cbxTipoInspeccion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de inspección válido", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtEmpleado.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un empleado válido", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarConsultaInspecciones(this.Filtrar(txtBusqueda.Text));
        }
    }
}

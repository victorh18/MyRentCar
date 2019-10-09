using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.Data.Modelos;
using MyRentCar.Logica.Controladores;
using MyRentCar.Utilitarios.Validaciones;

namespace MyRentCar.UI.Formularios
{
    public partial class frmMarcas : Form
    {
        private Marca marca;
        private MarcaController controller;
        public frmMarcas()
        {
            InitializeComponent();
            controller = new MarcaController();
            tipoVehiculoBindingSource.DataSource = controller.TraerTiposVehiculos();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtNumeroMarca.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            modeloBindingSource.DataSource = new BindingList<Modelo>(new List<Modelo>());
            
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            HabilitarControles(false);

        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaMarca();
        }
        
        private void NuevaMarca()
        {
            HabilitarControles(true);
            tsbNuevo.Enabled = false;
            this.marca = new Marca();
            LimpiarCampos();
            MostrarMarca(this.marca);
            chkEstado.Checked = true;

        }

        private void LlenarMarca(Marca _marca)
        {
            _marca.Descripcion = txtDescripcion.Text;
            _marca.Estado = chkEstado.Checked;
            List<Modelo> modelos = new List<Modelo>();
            foreach (Modelo m in modeloBindingSource.List)
            {
                if (ValidacionesModelos.ValidarModelo(m))
                {
                    modelos.Add(m);
                } 
            }
            _marca.Modelos = modelos;
        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            if (marca == null)
            {
                MessageBox.Show("Debe seleccionar o crear una nueva marca.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                return;

            }
            if (Validar())
            {
                LlenarMarca(this.marca);
                controller.Guardar(marca);
                MessageBox.Show("La marca de vehículo " + marca.Descripcion + " se ha guardado correctamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tsbNuevo.Enabled = true;
                return;
            }
            

        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaMarca f = new frmBusquedaMarca();
            f.ShowDialog();
            marca = controller.BuscarMarca(f.IdMarca);
            if (marca != null)
            {
                HabilitarControles(true);
                MostrarMarca(marca);
            }
           
        }

        private void MostrarMarca(Marca _marca)
        {
            this.txtNumeroMarca.Text = _marca.Id.ToString();
            this.txtDescripcion.Text = _marca.Descripcion;
            this.chkEstado.Checked = _marca.Estado ?? false;

            this.modeloBindingSource.DataSource = new BindingList<Modelo>(_marca.Modelos.ToList());
            this.dgvModelos.Refresh();
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            if (marca == null)
            {
                MessageBox.Show("Debe seleccionar una marca antes de eliminarla.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                return;
            }

            if (MessageBox.Show($"¿Está seguro de que desea eliminar la marca {marca?.Descripcion ?? ""}?", "CONFIRMAR ELIMINACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                LlenarMarca(marca);

                if (controller.ExisteMarca(marca))
                {
                    controller.Eliminar(marca);
                }
                LimpiarCampos();
                MessageBox.Show("La marca ha sido eliminada correctamente.", "REGISTRO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void HabilitarControles(bool valor)
        {
            txtDescripcion.Enabled = valor;
            chkEstado.Enabled = valor;
            dgvModelos.Enabled = valor;
        }

        private bool Validar()
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Tiene que digitar un nombre para la marca.", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        
    }
}

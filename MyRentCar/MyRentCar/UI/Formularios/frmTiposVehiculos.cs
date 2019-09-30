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
using MyRentCar.Utilitarios.Validaciones;

namespace MyRentCar.UI.Formularios
{
    public partial class frmTiposVehiculos : Form
    {
        private TiposVehiculosController controller;
        public frmTiposVehiculos()
        {
            InitializeComponent();
            controller = new TiposVehiculosController();

        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            foreach (TipoVehiculo tipoVehiculo in tipoVehiculoBindingSource.List)
            {
                if (ValidacionesTiposVehiculos.ValidarTipoVehiculo(tipoVehiculo))
                {
                    controller.Guardar(tipoVehiculo);
                }
            }

            MessageBox.Show("Los tipos de vehículos han sido guardados correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void FrmTiposVehiculos_Load(object sender, EventArgs e)
        {
            tipoVehiculoBindingSource.DataSource = new BindingList<TipoVehiculo>(controller.TraerTiposVehiculos());

        }

        private void DgvTiposVehiculos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void DgvTiposVehiculos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            TipoVehiculo tipoVehiculo = tipoVehiculoBindingSource.Current as TipoVehiculo;
            if (controller.ExisteTipoVehiculo(tipoVehiculo))
            {
                controller.Remover(tipoVehiculo);
            }
        }
    }
}

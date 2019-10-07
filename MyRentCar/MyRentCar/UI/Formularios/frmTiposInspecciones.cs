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
    public partial class frmTiposInspecciones : Form
    {
        private TipoInspeccionController controller;

        public frmTiposInspecciones()
        {
            InitializeComponent();
            this.controller = new TipoInspeccionController();
            this.tipoInspeccionBindingSource.DataSource = new BindingList<TipoInspeccion>(controller.TraerTiposInspecciones());
        }
        
        private void FrmTiposInspecciones_Load(object sender, EventArgs e)
        {

        }

        private void DgvTiposInspecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea guardar estas informaciones?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (TipoInspeccion tipo in tipoInspeccionBindingSource.List)
                {
                    if (ValidacionesTiposInpecciones.ValidarTipoInspecciones(tipo))
                    {
                        this.controller.Guardar(tipo);
                    }
                }

                MessageBox.Show("Los datos fueron guardados correctamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

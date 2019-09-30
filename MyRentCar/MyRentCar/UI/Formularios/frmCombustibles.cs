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
    public partial class frmCombustibles : Form
    {
        private CombustiblesController controller;
        
        public frmCombustibles()
        {
            InitializeComponent();
            controller = new CombustiblesController();
            tipoCombustibleBindingSource.DataSource = new BindingList<TipoCombustible>(controller.TraerCombustibles());
        }

        private void DgvCombustibles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            TipoCombustible combustible = tipoCombustibleBindingSource.Current as TipoCombustible;
            if (controller.ExisteCombustible(combustible))
            {
                controller.Remover(combustible);
            }
        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            foreach (TipoCombustible combustible in tipoCombustibleBindingSource.List)
            {
                if (ValidacionesCombustibles.ValidarCombustible(combustible))
                {
                    controller.Guardar(combustible);
                }
            }

            MessageBox.Show("Los tipos de combustibles fueron guardados correctamente.", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCombustibles_Load(object sender, EventArgs e)
        {

        }
    }
}

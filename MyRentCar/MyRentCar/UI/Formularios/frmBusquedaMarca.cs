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
    public partial class frmBusquedaMarca : Form
    {
        public int IdMarca;
        public MarcaController controller;
        public frmBusquedaMarca()
        {
            InitializeComponent();
            controller = new MarcaController();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmBusquedaMarca_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = controller.TraerMarcas();
        }


        private void DgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdMarca = (marcaBindingSource.Current as Marca).Id;
            this.Close();
        }
    }
}

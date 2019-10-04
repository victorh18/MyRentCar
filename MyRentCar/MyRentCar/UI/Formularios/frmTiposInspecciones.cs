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
    }
}

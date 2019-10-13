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
        private MyRentCarContext db;
        private List<Marca> marcas;
        public frmBusquedaMarca()
        {
            InitializeComponent();
            db = new MyRentCarContext();
            this.marcas = this.db.Marcas.ToList();
            this.CargarMarcas(marcas);
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void DgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdMarca = (marcaBindingSource.Current as Marca).Id;
            this.Close();
        }

        private List<Marca> Filtrar(string busqueda)
        {
            return this.marcas.Where(m => m.Descripcion.Contains(busqueda)).ToList();
        }

        private void CargarMarcas(List<Marca> _marcas)
        {
            this.marcaBindingSource.DataSource = _marcas;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            this.CargarMarcas(this.Filtrar(txtBusqueda.Text));
        }
    }
}

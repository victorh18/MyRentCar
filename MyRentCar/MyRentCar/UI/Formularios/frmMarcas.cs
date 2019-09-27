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
using System.ComponentModel;

namespace MyRentCar.UI
{
    public partial class frmMarcas : Form
    {
        BindingSource bsMarcas;
        MarcaController controller;
        public frmMarcas()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var lol = bsMarcas.List;
            Marca mm = controller.devolverMarca();
            mm.Modelos.Clear();

            foreach (Modelo l in lol)
            {
                //controller.Agregar(l);
                //MessageBox.Show(l.Descripcion);
                mm.Modelos.Add(l);
            }
            controller.Guardar();
            dgvMarcas.Refresh();
            
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            controller = new MarcaController();
            bsMarcas = new BindingSource();
            //bsMarcas.DataSource = controller.TraerMarcas();
            Marca m = controller.devolverMarca();
           // bsMarcas.DataSource = m.Modelos.ToList();
            bsMarcas.DataSource = new BindingList<Modelo>(m.Modelos.ToList());
            dgvMarcas.DataSource = bsMarcas;
            //dgvMarcas.DataSource = controller.TraerMarcas();
        }
    }
}

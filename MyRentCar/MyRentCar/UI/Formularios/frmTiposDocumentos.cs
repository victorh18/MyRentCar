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
    public partial class frmTiposDocumentos : Form
    {
        private TipoDocumentoController controller;
        public frmTiposDocumentos()
        {
            InitializeComponent();
            controller = new TipoDocumentoController();
            tipoDocumentoBindingSource.DataSource = new BindingList<TipoDocumento>(controller.TraerTiposDocumentos());
        }

        private void frmTiposDocumentos_Load(object sender, EventArgs e)
        {

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            foreach (TipoDocumento tipoDocumento in tipoDocumentoBindingSource.List)
            {
                if (ValidacionesTipoDocumento.ValidarTipoDocumento(tipoDocumento))
                {
                    controller.Guardar(tipoDocumento);
                }
                
            }
            MessageBox.Show("Los tipos de documentos han sido guardados correctamente");
        }

        private void dgvTiposDocumentos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            TipoDocumento tipoDocumento = tipoDocumentoBindingSource.Current as TipoDocumento;
            if (controller.ExisteTipoDocumento(tipoDocumento))
            {
                controller.Remover(tipoDocumento);
            }
        }
    }
}

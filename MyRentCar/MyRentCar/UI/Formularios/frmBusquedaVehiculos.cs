﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRentCar.Data.Modelos;
using MyRentCar.Utilitarios.DTOs;

namespace MyRentCar.UI.Formularios
{
    public partial class frmBusquedaVehiculos : Form
    {
        private BindingSource datosBindingSource;
        private MyRentCarContext db;
        public int Id;
        public frmBusquedaVehiculos()
        {
            InitializeComponent();
            this.datosBindingSource = new BindingSource();
            this.db = new MyRentCarContext();
            List<VehiculoDTO> vehiculosConsultas = new List<VehiculoDTO>();
            foreach (Vehiculo v in db.Vehiculos.ToList())
            {
                vehiculosConsultas.Add(new VehiculoDTO(v));
            }
            this.datosBindingSource.DataSource = vehiculosConsultas;
           // this.dgvDatos.DataSource = datosBindingSource;
        }

        private void DgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vehiculo _vehiculo = (vehiculoDTOBindingSource.Current as VehiculoDTO).Vehiculo;
            this.Id = _vehiculo.Id;
            this.Close();
        }
    }
}

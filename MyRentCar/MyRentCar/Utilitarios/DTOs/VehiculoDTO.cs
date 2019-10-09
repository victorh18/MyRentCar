using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.DTOs
{
    public class VehiculoDTO
    {
        private Vehiculo vehiculo;

        public VehiculoDTO(Vehiculo _vehiculo)
        {
            vehiculo = _vehiculo;
        }

        public string Descripcion
        {
            get
            {
                return this.vehiculo?.Descripcion ?? "";
            }
        }

        public string NumeroChasis
        {
            get
            {
                return this.vehiculo?.NumeroChasis ?? "";
            }
        }
        public string NumeroMotor
        {
            get
            {
                return this.vehiculo?.NumeroMotor ?? "";
            }
        }
        public string NumeroPlaca
        {
            get
            {
                return this.vehiculo?.NumeroPlaca ?? "";

            }
        }
        public string Modelo
        {
            get
            {
                return this.vehiculo?.Modelo?.Descripcion ?? "";
            }
        }
        public string Marca
        {
            get
            {
                return this.vehiculo?.Modelo?.Marca?.Descripcion ?? "";
            }
        }
        public string Combustible
        {
            get
            {
                return this.vehiculo?.TipoCombustible?.Descripcion ?? "";
            }
        }

        public Vehiculo Vehiculo
        {
            get
            {
                return vehiculo;
            }
        }
    }
}

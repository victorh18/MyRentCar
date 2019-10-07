using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.DTOs
{
    public class RentaDTO
    {
        private Renta renta;

        public RentaDTO(Renta _renta)
        {
            this.renta = _renta;
        }

        public int NumeroRenta
        {
            get
            {
                return renta.Id;
            }
        }

        public DateTime? FechaRenta
        {
            get
            {
                return renta.FechaRenta;
            }
        }

        public string Vehiculo
        {
            get
            {
                return renta.Vehiculo.Modelo.Marca.Descripcion + " " + renta.Vehiculo.Modelo.Descripcion;
            } 
        }

        public string PlacaVehiculo
        {
            get
            {
                return renta.Vehiculo.NumeroPlaca;
            }
        }

        public string Cliente
        {
            get
            {
                return renta.Cliente.Nombre;
            }
        }

        public string Empleado
        {
            get
            {
                return renta.Empleado.Nombre;
            }
        }

        public bool Estado
        {
            get
            {
                return renta?.Estado ?? false;
            }
        }

        public Renta Renta
        {
            get
            {
                return this.renta;
            }
        }

    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRentCar.Data.Modelos;

namespace MyRentCar.Utilitarios.DTOs
{
    public class InspeccionesDTO
    {
        private Inspeccion inspeccion;
        public InspeccionesDTO(Inspeccion _inspeccion)
        {
            this.inspeccion = _inspeccion;
        }

        public int Id
        {
            get
            {
                return inspeccion.Id;
            }
        }

        public int NumeroRenta
        {
            get
            {
                return inspeccion.IdRenta ?? 0;
            }
        }

        public string PlacaVehiculo
        {
            get
            {
                return inspeccion.Vehiculo.NumeroPlaca;
            }
        }

        public string ModeloVehiculo
        {
            get
            {
                return inspeccion?.Vehiculo?.Modelo?.Marca?.Descripcion ?? "" + " " + this.inspeccion?.Vehiculo?.Modelo?.Descripcion ?? "";
            }
        }

        public string TipoInspeccion
        {
            get
            {
                return this.inspeccion?.TipoInspeccion?.Descripcion ?? "";
            }
        }

        public string NombreCliente
        {
            get
            {
                return this.inspeccion?.Cliente?.Nombre ?? "";
            }
        }

        public string NombreEmpleado
        {
            get
            {
                return this.inspeccion?.Empleado?.Nombre ?? "";
            }
        }
    }
}

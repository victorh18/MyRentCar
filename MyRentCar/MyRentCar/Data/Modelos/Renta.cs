namespace MyRentCar.Data.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Renta
    {
        public int Id { get; set; }

        public int? IdEmpleado { get; set; }

        public int? IdVehiculo { get; set; }

        public int? IdCliente { get; set; }

        public DateTime? FechaRenta { get; set; }

        public DateTime? FechaDevolucion { get; set; }

        public decimal? MontoDia { get; set; }

        public string Comentario { get; set; }

        public int? IdEstado { get; set; }

        public virtual Cliente Clientes { get; set; }

        public virtual Empleado Empleados { get; set; }

        public virtual EstadosRentas EstadosRentas { get; set; }

        public virtual Vehiculo Vehiculos { get; set; }
    }
}

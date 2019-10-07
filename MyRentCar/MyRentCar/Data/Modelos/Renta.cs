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

        public int? DiasRenta { get; set; }

        public string Comentario { get; set; }

        public bool? Estado { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }

        public virtual ICollection<Inspeccion> Inspecciones { get; set; }
    }
}

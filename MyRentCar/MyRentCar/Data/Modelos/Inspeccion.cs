namespace MyRentCar.Data.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inspeccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspeccion()
        {
            Inspecciones1 = new HashSet<Inspeccion>();
        }

        public int Id { get; set; }

        public int? IdVehiculo { get; set; }

        public int? IdCliente { get; set; }

        public bool? TieneRayadura { get; set; }

        public int? CantidadCombustible { get; set; }

        public bool? TieneGomaRepuesto { get; set; }

        public bool? TieneRoturasCristal { get; set; }

        public string EstadoGomas { get; set; }

        public string Observaciones { get; set; }

        public DateTime? Fecha { get; set; }

        public int? IdEmpleadoInspeccion { get; set; }

        public int? Estado { get; set; }

        public int? IdTipoInspeccion { get; set; }

        public int? IdRenta { get; set; }

        public virtual Cliente Clientes { get; set; }

        public virtual Empleado Empleados { get; set; }

        public virtual TipoInspeccion TiposInspecciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspeccion> Inspecciones1 { get; set; }

        public virtual Inspeccion Inspecciones2 { get; set; }
    }
}

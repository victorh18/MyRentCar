namespace MyRentCar.Data.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            Rentas = new HashSet<Renta>();
        }

        public int Id { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public string NumeroChasis { get; set; }

        [Required]
        public string NumeroMotor { get; set; }

        [Required]
        public string NumeroPlaca { get; set; }

        public int? IdModelo { get; set; }

        public int? IdCombustible { get; set; }

        public bool? Estado { get; set; }

        public virtual Modelo Modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Renta> Rentas { get; set; }

        public virtual ICollection<Inspeccion> Inspecciones { get; set; }

        public virtual TipoCombustible TipoCombustible { get; set; }

        public string NombreVehiculo
        {
            get
            {
                return (this?.Modelo?.Marca?.Descripcion ?? "") + " " + (this?.Modelo?.Descripcion ?? "");
            } 
        }
    }
}

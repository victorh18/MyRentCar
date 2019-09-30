namespace MyRentCar.Data.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public bool? Estado { get; set; }

        public int? IdMarca { get; set; }

        public int? IdTipoVehiculo { get; set; }

        public virtual Marca Marca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }

        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}

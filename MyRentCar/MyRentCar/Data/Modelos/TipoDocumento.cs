namespace MyRentCar.Data.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TipoDocumento
    {
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}

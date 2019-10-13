namespace MyRentCar.Data.Modelos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyRentCarContext : DbContext
    {
        public MyRentCarContext()
            : base("name=MyRentCarConnectionString")
        {
            Database.SetInitializer<MyRentCarContext>(null);
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Inspeccion> Inspecciones { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }
        public virtual DbSet<Renta> Rentas { get; set; }
        public virtual DbSet<TipoCombustible> TiposCombustibles { get; set; }
        public virtual DbSet<TipoDocumento> TiposDocumentos { get; set; }
        public virtual DbSet<TipoInspeccion> TiposInspecciones { get; set; }
        public virtual DbSet<TipoVehiculo> TiposVehiculos { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modelo>().ToTable("Modelos");
            modelBuilder.Entity<TipoVehiculo>().ToTable("TiposVehiculos");
            modelBuilder.Entity<TipoCombustible>().ToTable("TiposCombustibles");
            modelBuilder.Entity<Vehiculo>().ToTable("Vehiculos");
            modelBuilder.Entity<Empleado>().ToTable("Empleados");
            modelBuilder.Entity<TipoDocumento>().ToTable("TiposDocumentos");
            modelBuilder.Entity<TipoInspeccion>().ToTable("TiposInspecciones");
            modelBuilder.Entity<Inspeccion>().ToTable("Inspecciones");

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Inspecciones)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.PorcientoComision)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Inspecciones)
                .WithOptional(e => e.Empleado)
                .HasForeignKey(e => e.IdEmpleadoInspeccion);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.Empleado)
                .HasForeignKey(e => e.IdEmpleado);

            //modelBuilder.Entity<Inspeccion>()
            //    .HasMany(e => e.Inspecciones1)
            //    .WithOptional(e => e.Inspecciones2)
            //    .HasForeignKey(e => e.IdVehiculo);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Modelos)
                .WithRequired(e => e.Marca)
                .HasForeignKey(e => e.IdMarca)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.Vehiculos)
                .WithOptional(e => e.Modelo)
                .HasForeignKey(e => e.IdModelo);

            modelBuilder.Entity<TipoCombustible>()
                .HasMany(e => e.Vehiculos)
                .WithOptional(e => e.TipoCombustible)
                .HasForeignKey(e => e.IdCombustible);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            modelBuilder.Entity<TipoInspeccion>()
                .HasMany(e => e.Inspecciones)
                .WithOptional(e => e.TipoInspeccion)
                .HasForeignKey(e => e.IdTipoInspeccion);

            modelBuilder.Entity<TipoVehiculo>()
                .HasMany(e => e.Modelos)
                .WithOptional(e => e.TipoVehiculo)
                .HasForeignKey(e => e.IdTipoVehiculo);

            modelBuilder.Entity<Vehiculo>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.Vehiculo)
                .HasForeignKey(e => e.IdVehiculo);

            modelBuilder.Entity<Vehiculo>()
                .HasMany(v => v.Inspecciones)
                .WithRequired(i => i.Vehiculo)
                .HasForeignKey(i => i.IdVehiculo);

            modelBuilder.Entity<Renta>()
                .HasMany(r => r.Inspecciones)
                .WithOptional(i => i.Renta)
                .HasForeignKey(i => i.IdRenta);
        }
    }
}

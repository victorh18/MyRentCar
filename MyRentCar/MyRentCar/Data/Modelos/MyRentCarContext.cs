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
        public virtual DbSet<EstadosRentas> EstadosRentas { get; set; }
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

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Inspecciones)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.IdCliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.IdCliente);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.PorcientoComision)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Inspecciones)
                .WithOptional(e => e.Empleados)
                .HasForeignKey(e => e.IdEmpleadoInspeccion);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.Empleados)
                .HasForeignKey(e => e.IdEmpleado);

            modelBuilder.Entity<EstadosRentas>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.EstadosRentas)
                .HasForeignKey(e => e.IdEstado);

            modelBuilder.Entity<Inspeccion>()
                .HasMany(e => e.Inspecciones1)
                .WithOptional(e => e.Inspecciones2)
                .HasForeignKey(e => e.IdVehiculo);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Modelos)
                .WithOptional(e => e.Marca)
                .HasForeignKey(e => e.IdMarca);

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.Vehiculos)
                .WithOptional(e => e.Modelo)
                .HasForeignKey(e => e.IdModelo);

            modelBuilder.Entity<TipoCombustible>()
                .HasMany(e => e.Vehiculos)
                .WithOptional(e => e.TiposCombustibles)
                .HasForeignKey(e => e.IdCombustible);

            modelBuilder.Entity<TipoDocumento>()
                .HasOptional(e => e.Clientes)
                .WithRequired(e => e.TiposDocumentos);

            modelBuilder.Entity<TipoInspeccion>()
                .HasMany(e => e.Inspecciones)
                .WithOptional(e => e.TiposInspecciones)
                .HasForeignKey(e => e.IdTipoInspeccion);

            modelBuilder.Entity<TipoVehiculo>()
                .HasMany(e => e.Modelos)
                .WithOptional(e => e.TiposVehiculos)
                .HasForeignKey(e => e.IdTipoVehiculo);

            modelBuilder.Entity<Vehiculo>()
                .HasMany(e => e.Rentas)
                .WithOptional(e => e.Vehiculos)
                .HasForeignKey(e => e.IdVehiculo);
        }
    }
}
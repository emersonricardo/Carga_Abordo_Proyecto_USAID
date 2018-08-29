namespace Carga_AbordoBD1._0.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Cargo> Cargoes { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Detalles_Pedido> Detalles_Pedido { get; set; }
        public virtual DbSet<Ejemplo> Ejemploes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Estado_Pedidos> Estado_Pedidos { get; set; }
        public virtual DbSet<Pedido> Pedidoes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Tipo_Pago> Tipo_Pago { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Area>()
                .HasMany(e => e.Empleados)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Empleados)
                .WithRequired(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Empresa_Negocio)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.DUI)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Correo_Electronico)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono_Movil)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono_Fijo)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Pedidoes)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Detalles_Pedido>()
                .Property(e => e.Precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.DUI)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.NIT)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Telefono_movil)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.telefono_fijo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Correo_Electronico)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.Pedidoes)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estado_Pedidos>()
                .Property(e => e.Nombre_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Estado_Pedidos>()
                .HasMany(e => e.Detalles_Pedido)
                .WithRequired(e => e.Estado_Pedidos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.Direccion_Envio)
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.Detalles_Pedido)
                .WithRequired(e => e.Pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Codigo_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre_Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Costo_Estandar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Precio_Listado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Cantidad_Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Detalles_Pedido)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Compañia)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Correo_Electronico)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.DUI)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Telefono_Fijo)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .Property(e => e.Telefono_Movil)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedore>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Proveedore)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Pago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Pago>()
                .HasMany(e => e.Pedidoes)
                .WithRequired(e => e.Tipo_Pago)
                .WillCascadeOnDelete(false);
        }
    }
}

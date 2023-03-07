using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoVenta.Data;

public partial class BdinventarioContext : DbContext
{
    public BdinventarioContext()
    {
    }

    public BdinventarioContext(DbContextOptions<BdinventarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Dato> Datos { get; set; }

    public virtual DbSet<DetalleEntradum> DetalleEntrada { get; set; }

    public virtual DbSet<DetalleSalidum> DetalleSalida { get; set; }

    public virtual DbSet<Entradum> Entrada { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Salidum> Salida { get; set; }

    public virtual DbSet<TipoBarra> TipoBarras { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=C:\\\\\\\\Users\\\\\\\\edyne\\\\\\\\Desktop\\\\\\\\SistemaInventario\\\\\\\\ProyectoVenta\\\\\\\\bin\\\\\\\\Debug\\\\\\\\net7.0-windows\\\\\\\\BDINVENTARIO.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("CLIENTE");

            entity.HasIndex(e => e.IdCliente, "IX_CLIENTE_IdCliente").IsUnique();

            entity.Property(e => e.NombreCompleto).IsRequired();
            entity.Property(e => e.NumeroDocumento).IsRequired();
        });

        modelBuilder.Entity<Dato>(entity =>
        {
            entity.HasKey(e => e.IdDato);

            entity.ToTable("DATOS");

            entity.Property(e => e.IdDato).ValueGeneratedNever();
            entity.Property(e => e.RazonSocial).IsRequired();
            entity.Property(e => e.Ruc).IsRequired();
        });

        modelBuilder.Entity<DetalleEntradum>(entity =>
        {
            entity.HasKey(e => e.IdDetalleEntrada);

            entity.ToTable("DETALLE_ENTRADA");

            entity.HasIndex(e => e.IdDetalleEntrada, "IX_DETALLE_ENTRADA_IdDetalleEntrada").IsUnique();

            entity.Property(e => e.AlmacenProducto).IsRequired();
            entity.Property(e => e.CodigoProducto).IsRequired();
            entity.Property(e => e.DescripcionProducto).IsRequired();
            entity.Property(e => e.LongitudProducto).IsRequired();

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.DetalleEntrada)
                .HasForeignKey(d => d.IdEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DetalleSalidum>(entity =>
        {
            entity.HasKey(e => e.IdDetalleSalida);

            entity.ToTable("DETALLE_SALIDA");

            entity.HasIndex(e => e.IdDetalleSalida, "IX_DETALLE_SALIDA_IdDetalleSalida").IsUnique();

            entity.Property(e => e.AlmacenProducto).IsRequired();
            entity.Property(e => e.CodigoProducto).IsRequired();
            entity.Property(e => e.DescripcionProducto).IsRequired();
            entity.Property(e => e.LongitudProducto).IsRequired();

            entity.HasOne(d => d.IdSalidaNavigation).WithMany(p => p.DetalleSalida)
                .HasForeignKey(d => d.IdSalida)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Entradum>(entity =>
        {
            entity.HasKey(e => e.IdEntrada);

            entity.ToTable("ENTRADA");

            entity.HasIndex(e => e.IdEntrada, "IX_ENTRADA_IdEntrada").IsUnique();

            entity.Property(e => e.CantidadProductos).IsRequired();
            entity.Property(e => e.DocumentoProveedor).IsRequired();
            entity.Property(e => e.FechaRegistro).IsRequired();
            entity.Property(e => e.NombreProveedor).IsRequired();
            entity.Property(e => e.NumeroDocumento).IsRequired();
            entity.Property(e => e.UsuarioRegistro).IsRequired();
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido);

            entity.ToTable("PEDIDOS");

            entity.Property(e => e.IdPedido).ValueGeneratedNever();
            entity.Property(e => e.NumeroDocumento).IsRequired();
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermisos);

            entity.ToTable("PERMISOS");

            entity.Property(e => e.IdPermisos).ValueGeneratedNever();
            entity.Property(e => e.Descripcion).IsRequired();
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto);

            entity.ToTable("PRODUCTO");

            entity.HasIndex(e => e.IdProducto, "IX_PRODUCTO_IdProducto").IsUnique();

            entity.Property(e => e.Almacen).HasDefaultValueSql("''");
            entity.Property(e => e.Codigo).IsRequired();
            entity.Property(e => e.Descripcion).IsRequired();
            entity.Property(e => e.PrecioCompra)
                .IsRequired()
                .HasDefaultValueSql("''");
            entity.Property(e => e.PrecioVenta)
                .IsRequired()
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor);

            entity.ToTable("PROVEEDOR");

            entity.HasIndex(e => e.IdProveedor, "IX_PROVEEDOR_IdProveedor").IsUnique();

            entity.Property(e => e.NombreCompleto).IsRequired();
            entity.Property(e => e.NumeroDocumento).IsRequired();
        });

        modelBuilder.Entity<Salidum>(entity =>
        {
            entity.HasKey(e => e.IdSalida);

            entity.ToTable("SALIDA");

            entity.HasIndex(e => e.IdSalida, "IX_SALIDA_IdSalida").IsUnique();

            entity.Property(e => e.DocumentoCliente).IsRequired();
            entity.Property(e => e.FechaRegistro).IsRequired();
            entity.Property(e => e.NombreCliente).IsRequired();
            entity.Property(e => e.NumeroDocumento).IsRequired();
            entity.Property(e => e.UsuarioRegistro).IsRequired();
        });

        modelBuilder.Entity<TipoBarra>(entity =>
        {
            entity.HasKey(e => e.IdTipoBarra);

            entity.ToTable("TIPO_BARRA");

            entity.HasIndex(e => e.IdTipoBarra, "IX_TIPO_BARRA_IdTipoBarra").IsUnique();

            entity.Property(e => e.IdTipoBarra).ValueGeneratedNever();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.IdUsuario, "IX_USUARIO_IdUsuario").IsUnique();

            entity.Property(e => e.Clave).IsRequired();
            entity.Property(e => e.NombreCompleto).IsRequired();
            entity.Property(e => e.NombreUsuario).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

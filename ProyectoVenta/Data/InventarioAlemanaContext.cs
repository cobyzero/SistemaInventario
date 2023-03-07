using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoVenta.Data;

public partial class InventarioAlemanaContext : DbContext
{
    public InventarioAlemanaContext()
    {
    }

    public InventarioAlemanaContext(DbContextOptions<InventarioAlemanaContext> options)
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
        => optionsBuilder.UseSqlServer("Server=(local);Database=InventarioAlemana;Trusted_Connection=True;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__CLIENTE__D5946642886498FE");

            entity.ToTable("CLIENTE");

            entity.HasIndex(e => e.IdCliente, "UQ__CLIENTE__D5946643DD9F61B9").IsUnique();

            entity.Property(e => e.NombreCompleto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dato>(entity =>
        {
            entity.HasKey(e => e.IdDato).HasName("PK__DATOS__F298CC9F9AF84241");

            entity.ToTable("DATOS");

            entity.Property(e => e.Direccion)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.RazonSocial)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ruc)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetalleEntradum>(entity =>
        {
            entity.HasKey(e => e.IdDetalleEntrada).HasName("PK__DETALLE___B9C7D26513FA827F");

            entity.ToTable("DETALLE_ENTRADA");

            entity.HasIndex(e => e.IdDetalleEntrada, "UQ__DETALLE___B9C7D264C8CBD35D").IsUnique();

            entity.Property(e => e.AlmacenProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongitudProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEntradaNavigation).WithMany(p => p.DetalleEntrada)
                .HasForeignKey(d => d.IdEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLE_E__IdEnt__4CA06362");
        });

        modelBuilder.Entity<DetalleSalidum>(entity =>
        {
            entity.HasKey(e => e.IdDetalleSalida).HasName("PK__DETALLE___B5F901B23ACDF867");

            entity.ToTable("DETALLE_SALIDA");

            entity.HasIndex(e => e.IdDetalleSalida, "UQ__DETALLE___B5F901B3B4199DED").IsUnique();

            entity.Property(e => e.AlmacenProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LongitudProducto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdSalidaNavigation).WithMany(p => p.DetalleSalida)
                .HasForeignKey(d => d.IdSalida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DETALLE_S__IdSal__66603565");
        });

        modelBuilder.Entity<Entradum>(entity =>
        {
            entity.HasKey(e => e.IdEntrada).HasName("PK__ENTRADA__BB164DEA7267F0DA");

            entity.ToTable("ENTRADA");

            entity.HasIndex(e => e.IdEntrada, "UQ__ENTRADA__BB164DEB6F0EA979").IsUnique();

            entity.Property(e => e.CantidadProductos)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentoProveedor)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreProveedor)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRegistro)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__PEDIDOS__9D335DC335230B53");

            entity.ToTable("PEDIDOS");

            entity.Property(e => e.CodigoProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tecnico)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermisos).HasName("PK__PERMISOS__CE7ED38D96CF1F87");

            entity.ToTable("PERMISOS");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__PRODUCTO__09889210327D04BA");

            entity.ToTable("PRODUCTO");

            entity.HasIndex(e => e.IdProducto, "UQ__PRODUCTO__0988921114CBF0B1").IsUnique();

            entity.Property(e => e.Almacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Codigo)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Longitud)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioCompra)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrecioVenta)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__PROVEEDO__E8B631AF4F5B6AEF");

            entity.ToTable("PROVEEDOR");

            entity.HasIndex(e => e.IdProveedor, "UQ__PROVEEDO__E8B631AE93CF925F").IsUnique();

            entity.Property(e => e.NombreCompleto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Salidum>(entity =>
        {
            entity.HasKey(e => e.IdSalida).HasName("PK__SALIDA__5D69EC722F1E861F");

            entity.ToTable("SALIDA");

            entity.HasIndex(e => e.IdSalida, "UQ__SALIDA__5D69EC73F7D9B1B1").IsUnique();

            entity.Property(e => e.DocumentoCliente)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("date");
            entity.Property(e => e.NombreCliente)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRegistro)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoBarra>(entity =>
        {
            entity.HasKey(e => e.IdTipoBarra).HasName("PK__TIPO_BAR__7576195FB321EC82");

            entity.ToTable("TIPO_BARRA");

            entity.HasIndex(e => e.IdTipoBarra, "UQ__TIPO_BAR__7576195E97314FA4").IsUnique();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__5B65BF970A34F64A");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.IdUsuario, "UQ__USUARIO__5B65BF967649AED0").IsUnique();

            entity.Property(e => e.Clave)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Data.tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model;

#nullable disable

namespace Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Itens { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }

        private DataExtractor de = new DataExtractor();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("ITENS");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Codigopedido)
                    .HasColumnName("CODIGOPEDIDO");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Valoritem)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VALORITEM");

                entity.HasOne(d => d.CodigopedidoNavigation)
                    .WithMany(p => p.Itens)
                    .HasForeignKey(d => d.Codigopedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ITENS_FK")
                    .IsRequired();

                entity.HasData(de.getItens("../Data/ExtracaoItens.txt"));
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("PEDIDOS");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Datapedido)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAPEDIDO");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength(true);

                entity.Property(e => e.Valorpedido)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VALORPEDIDO");

                entity.HasData(de.getPedidos("../Data/ExtracaoPedidos.txt"));

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

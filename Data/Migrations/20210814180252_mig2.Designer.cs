// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210814180252_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Item", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int")
                        .HasColumnName("CODIGO");

                    b.Property<int>("Codigopedido")
                        .HasColumnType("int")
                        .HasColumnName("CODIGOPEDIDO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DESCRICAO");

                    b.Property<decimal>("Valoritem")
                        .HasColumnType("numeric(13,2)")
                        .HasColumnName("VALORITEM");

                    b.HasKey("Codigo");

                    b.HasIndex("Codigopedido");

                    b.ToTable("ITENS");
                });

            modelBuilder.Entity("Model.Pedido", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int")
                        .HasColumnName("CODIGO");

                    b.Property<DateTime>("Datapedido")
                        .HasColumnType("datetime")
                        .HasColumnName("DATAPEDIDO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("STATUS")
                        .IsFixedLength(true);

                    b.Property<decimal>("Valorpedido")
                        .HasColumnType("numeric(13,2)")
                        .HasColumnName("VALORPEDIDO");

                    b.HasKey("Codigo");

                    b.ToTable("PEDIDOS");
                });

            modelBuilder.Entity("Model.Item", b =>
                {
                    b.HasOne("Model.Pedido", "CodigopedidoNavigation")
                        .WithMany("Itens")
                        .HasForeignKey("Codigopedido")
                        .HasConstraintName("ITENS_FK")
                        .IsRequired();

                    b.Navigation("CodigopedidoNavigation");
                });

            modelBuilder.Entity("Model.Pedido", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}

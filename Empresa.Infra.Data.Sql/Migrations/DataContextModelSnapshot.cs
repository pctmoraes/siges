﻿// <auto-generated />
using System;
using Empresa.Infra.Data.Sql.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Empresa.Infra.Data.Sql.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Empresa.Domain.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Cnpj")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Municipio")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomeEmpresarial")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Porte")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("SituacaoCadastral")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Empresa.Domain.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("PrecoDeCompra")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("PrecoDeVenda")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Quantidade");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Empresa.Domain.Entities.LinhasPedido", b =>
                {
                    b.Property<int>("LinhasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(80)");

                    b.Property<int>("Desconto");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(80)");

                    b.Property<int>("ItemId");

                    b.Property<int>("PedidoId");

                    b.Property<decimal>("Preco")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("Quantidade");

                    b.Property<decimal>("ValorTotal")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("LinhasId");

                    b.HasIndex("ItemId");

                    b.HasIndex("PedidoId");

                    b.ToTable("LinhasPedidos");
                });

            modelBuilder.Entity("Empresa.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDaEntrega");

                    b.Property<DateTime>("DataDoPedido");

                    b.Property<int>("Desconto");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("ValorComDesconto")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(6,2)");

                    b.Property<decimal>("ValorSemDesconto")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Empresa.Domain.Entities.LinhasPedido", b =>
                {
                    b.HasOne("Empresa.Domain.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Empresa.Domain.Entities.Pedido")
                        .WithMany("LinhasPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

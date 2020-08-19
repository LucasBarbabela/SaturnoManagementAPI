﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaturnoManagementAPI.Configuração;

namespace SaturnoManagementAPI.Migrations
{
    [DbContext(typeof(ERPContext))]
    partial class ERPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasMaxLength(6);

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<double>("PrecoCompra")
                        .HasColumnType("float");

                    b.Property<int?>("TransacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransacaoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Transacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Permissao")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("TipoTransacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Cliente", b =>
                {
                    b.HasOne("SaturnoManagementAPI.Tabelas.Produto", null)
                        .WithMany("ClienteComprado")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Endereco", b =>
                {
                    b.HasOne("SaturnoManagementAPI.Tabelas.Cliente", null)
                        .WithMany("Endereco")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Produto", b =>
                {
                    b.HasOne("SaturnoManagementAPI.Tabelas.Transacao", null)
                        .WithMany("Produtos")
                        .HasForeignKey("TransacaoId");
                });

            modelBuilder.Entity("SaturnoManagementAPI.Tabelas.Transacao", b =>
                {
                    b.HasOne("SaturnoManagementAPI.Tabelas.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}
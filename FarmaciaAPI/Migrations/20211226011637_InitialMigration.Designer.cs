// <auto-generated />
using System;
using FarmaciaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FarmaciaAPI.Migrations
{
    [DbContext(typeof(FarmaciaDBContext))]
    [Migration("20211226011637_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FarmaciaAPI.Data.Entities.LaboratoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MakeOrders")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("FarmaciaAPI.Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LaboratoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Presentation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("TherapeuticAction")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LaboratoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FarmaciaAPI.Data.Entities.ProductEntity", b =>
                {
                    b.HasOne("FarmaciaAPI.Data.Entities.LaboratoryEntity", "Laboratory")
                        .WithMany("Products")
                        .HasForeignKey("LaboratoryId");

                    b.Navigation("Laboratory");
                });

            modelBuilder.Entity("FarmaciaAPI.Data.Entities.LaboratoryEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAdminV2.Models;

#nullable disable

namespace RestAdminV2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RestAdminV2.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("RestAdminV2.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("RestAdminV2.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("LogoURL")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("logo_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nit");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("company");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateInvoice")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("number");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("table_id");

                    b.Property<double>("Total")
                        .HasColumnType("double")
                        .HasColumnName("total");

                    b.HasKey("Id");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("RestAdminV2.Models.Kitchen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasMaxLength(155)
                        .HasColumnType("varchar(155)")
                        .HasColumnName("observations");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("table_id");

                    b.HasKey("Id");

                    b.ToTable("kitchen");
                });

            modelBuilder.Entity("RestAdminV2.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("category");

                    b.Property<double>("Cost")
                        .HasColumnType("double")
                        .HasColumnName("cost");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("image_url");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("KitchenId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PreInvoiceId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("KitchenId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PreInvoiceId");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("RestAdminV2.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasMaxLength(155)
                        .HasColumnType("varchar(155)")
                        .HasColumnName("observations");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("table_id");

                    b.HasKey("Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("RestAdminV2.Models.PreInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateInvoice")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("number");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasMaxLength(155)
                        .HasColumnType("varchar(155)")
                        .HasColumnName("observations");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("table_id");

                    b.Property<double>("Total")
                        .HasColumnType("double")
                        .HasColumnName("total");

                    b.HasKey("Id");

                    b.ToTable("pre_invoices");
                });

            modelBuilder.Entity("RestAdminV2.Models.Tables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("state");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("RestAdminV2.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("phone");

                    b.Property<string>("Roles")
                        .HasColumnType("longtext")
                        .HasColumnName("roles");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("RestAdminV2.Models.Menu", b =>
                {
                    b.HasOne("RestAdminV2.Models.Invoice", null)
                        .WithMany("Items")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("RestAdminV2.Models.Kitchen", null)
                        .WithMany("Items")
                        .HasForeignKey("KitchenId");

                    b.HasOne("RestAdminV2.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("RestAdminV2.Models.PreInvoice", null)
                        .WithMany("Items")
                        .HasForeignKey("PreInvoiceId");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RestAdminV2.Models.Kitchen", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RestAdminV2.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RestAdminV2.Models.PreInvoice", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}

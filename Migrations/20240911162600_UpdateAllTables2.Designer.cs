﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAdminV2.Models;

#nullable disable

namespace RestAdminV2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240911162600_UpdateAllTables2")]
    partial class UpdateAllTables2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bebidas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comidas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Postres"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Entradas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Domicilios"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cra 50a 36 90",
                            Name = "Juliana Carvajal",
                            Phone = "3242144893"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cra 50a 23-17",
                            Name = "Alejandro Echavarria",
                            Phone = "3004001077"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cra 50 40 90",
                            Email = "administracionilforno@ilforno.com",
                            LogoURL = "https://images.rappi.com/restaurants_logo/il-forno-logo1-1568819470999.png",
                            Name = "Il Forno",
                            Nit = "49879684184",
                            Phone = "3242144893"
                        });
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

                    b.Property<int>("TableId")
                        .HasColumnType("int")
                        .HasColumnName("table_id");

                    b.HasKey("Id");

                    b.ToTable("kitchen");
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

                    b.Property<int>("TablesId")
                        .HasColumnType("int")
                        .HasColumnName("tables_id");

                    b.HasKey("Id");

                    b.HasIndex("TablesId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("order_products");
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

            modelBuilder.Entity("RestAdminV2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<double>("Cost")
                        .HasColumnType("double")
                        .HasColumnName("cost");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("image_url");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<int?>("PreInvoiceId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("PreInvoiceId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Cost = 2100.0,
                            ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641772/j1sfl0ooipp2lfnaznbx.jpg",
                            Name = "Coca cola 400ml",
                            Price = 3500.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Cost = 9000.0,
                            ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641834/oeicuuwbem09deuyizwp.jpg",
                            Name = "Hamburguesa",
                            Price = 18000.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Cost = 12000.0,
                            ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725641861/ix9ooxdajnvxijwq7bwv.jpg",
                            Name = "Pizza Peperoni",
                            Price = 22000.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Cost = 3500.0,
                            ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669032/zoc4meht10bhophsaz7z.jpg",
                            Name = "Postobon 1.5lt",
                            Price = 7000.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Cost = 2500.0,
                            ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669102/wtymyqe8qug10utjrhmj.jpg",
                            Name = "Michelada clasica",
                            Price = 5000.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Cost = 3500.0,
                            ImageURL = "https://res.cloudinary.com/dfdvjpaja/image/upload/v1725669255/kg6sllhrux2qs3wogknz.jpg",
                            Name = "Michelada cereza",
                            Price = 7000.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Cost = 5000.0,
                            ImageURL = "https://assets.unileversolutions.com/recipes-v2/219942.jpg",
                            Name = "Bruschetta",
                            Price = 12000.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Cost = 12000.0,
                            ImageURL = "https://www.jocooks.com/wp-content/uploads/2022/04/tacos-al-pastor-feature-1.jpg",
                            Name = "Tacos al Pastor",
                            Price = 25000.0
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            Cost = 3500.0,
                            ImageURL = "https://www.elespectador.com/resizer/tyGJPN_YmWpagQFeXq_YYOxAKjY=/arc-anglerfish-arc2-prod-elespectador/public/2AVD5Z6Y2ZFWHETPQGCPLMNK4A.jpg",
                            Name = "Ceviche",
                            Price = 7000.0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Cost = 3500.0,
                            ImageURL = "https://escuelamundopastel.com/wp-content/uploads/2018/11/ORGANIZACI%C3%93N-DE-EVENTOS-10.png",
                            Name = "Cheesecake",
                            Price = 7000.0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Cost = 3500.0,
                            ImageURL = "https://badun.nestle.es/imgserver/v1/80/1290x742/ac5fa47c04dd-brownie-de-chocolate-negro.jpg",
                            Name = "Brownie",
                            Price = 6000.0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Cost = 3500.0,
                            ImageURL = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/6BE1C69C-69FB-4957-96EA-D76159076661/Derivates/BA406212-38AE-4EA0-B4D5-591514C21C2D.jpg",
                            Name = "Tiramisu",
                            Price = 7000.0
                        });
                });

            modelBuilder.Entity("RestAdminV2.Models.Role", b =>
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

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mesero"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Administrador"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cajero"
                        });
                });

            modelBuilder.Entity("RestAdminV2.Models.Tables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("name");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.ToTable("tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mesa 1",
                            State = "Cocinando"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mesa 2",
                            State = "Por Facturar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mesa 3",
                            State = "Ocupada"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mesa 4",
                            State = "Disponible"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mesa 5",
                            State = "Disponible"
                        });
                });

            modelBuilder.Entity("RestAdminV2.Models.User", b =>
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

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cra 50 40 90",
                            Email = "erik@elmejor.com",
                            Name = "Erik Uribe",
                            Password = "riwi1234",
                            Phone = "3242144893",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cra 50a 36 90",
                            Email = "aechavarriaj@gmail.com",
                            Name = "Alejandro Echavarria",
                            Password = "Susana1901",
                            Phone = "3004001077",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cra 59a 66 57",
                            Email = "alejomi192005@gmail.com",
                            Name = "Alejandro Castrillón",
                            Password = "21354",
                            Phone = "333245884",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 4,
                            Address = "Cra 45 67 89",
                            Email = "Alejandro@gmail.com",
                            Name = "Alejandro Londoño",
                            Password = "12345678",
                            Phone = "3123456789",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 5,
                            Address = "Cra 40 50 60",
                            Email = "kev@gmail.com",
                            Name = "Kevin Alvarez",
                            Password = "987654321",
                            Phone = "3132145678",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 6,
                            Address = "Cra 55 33 44",
                            Email = "laura.jimenez@restadmin.com",
                            Name = "Laura Jimenez",
                            Password = "laura2024",
                            Phone = "3221234567",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 7,
                            Address = "Cra 60 35 78",
                            Email = "carlos.mejia@restadmin.com",
                            Name = "Carlos Mejia",
                            Password = "admin2024",
                            Phone = "3209876543",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 8,
                            Address = "Cra 42 55 88",
                            Email = "diana.lopez@restadmin.com",
                            Name = "Diana Lopez",
                            Password = "cashier2024",
                            Phone = "3111239876",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("RestAdminV2.Models.Order", b =>
                {
                    b.HasOne("RestAdminV2.Models.Tables", "Tables")
                        .WithMany()
                        .HasForeignKey("TablesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestAdminV2.Models.OrderProduct", b =>
                {
                    b.HasOne("RestAdminV2.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RestAdminV2.Models.Product", b =>
                {
                    b.HasOne("RestAdminV2.Models.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestAdminV2.Models.Invoice", null)
                        .WithMany("Items")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("RestAdminV2.Models.PreInvoice", null)
                        .WithMany("Items")
                        .HasForeignKey("PreInvoiceId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RestAdminV2.Models.User", b =>
                {
                    b.HasOne("RestAdminV2.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RestAdminV2.Models.Invoice", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RestAdminV2.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("RestAdminV2.Models.PreInvoice", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}

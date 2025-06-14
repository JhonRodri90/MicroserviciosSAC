﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250603235320_primermigracion")]
    partial class primermigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Colaboradores", b =>
                {
                    b.Property<int>("col_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("col_id"));

                    b.Property<int?>("Colaborador_Lidercol_id")
                        .HasColumnType("int");

                    b.Property<int?>("Tipos_Colaboradorestc_id")
                        .HasColumnType("int");

                    b.Property<int?>("Tipos_Usuariostu_id")
                        .HasColumnType("int");

                    b.Property<bool>("col_activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("col_apellido")
                        .HasColumnType("longtext");

                    b.Property<int?>("col_col_id_lider")
                        .HasColumnType("int");

                    b.Property<string>("col_email")
                        .HasColumnType("longtext");

                    b.Property<string>("col_identificacion")
                        .HasColumnType("longtext");

                    b.Property<string>("col_nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("col_tc_id")
                        .HasColumnType("int");

                    b.Property<string>("col_telefono")
                        .HasColumnType("longtext");

                    b.Property<int>("col_tu_id")
                        .HasColumnType("int");

                    b.HasKey("col_id");

                    b.HasIndex("Colaborador_Lidercol_id");

                    b.HasIndex("Tipos_Colaboradorestc_id");

                    b.HasIndex("Tipos_Usuariostu_id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("Core.Entities.Estados_Solicitudes", b =>
                {
                    b.Property<int>("es_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("es_id"));

                    b.Property<string>("es_nombre_estado")
                        .HasColumnType("longtext");

                    b.HasKey("es_id");

                    b.ToTable("Estados_Solicitudes");
                });

            modelBuilder.Entity("Core.Entities.Historicos_Solicitudes", b =>
                {
                    b.Property<int>("hs_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("hs_id"));

                    b.Property<int?>("Colaboradorescol_id")
                        .HasColumnType("int");

                    b.Property<int?>("Estados_Solicitudeses_id")
                        .HasColumnType("int");

                    b.Property<int?>("Solicitudesso_id")
                        .HasColumnType("int");

                    b.Property<int?>("hs_col_id")
                        .HasColumnType("int");

                    b.Property<string>("hs_detalle")
                        .HasColumnType("longtext");

                    b.Property<int>("hs_es_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("hs_fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("hs_so_id")
                        .HasColumnType("int");

                    b.HasKey("hs_id");

                    b.HasIndex("Colaboradorescol_id");

                    b.HasIndex("Estados_Solicitudeses_id");

                    b.HasIndex("Solicitudesso_id");

                    b.ToTable("Historicos_Solicitudes");
                });

            modelBuilder.Entity("Core.Entities.Solicitudes", b =>
                {
                    b.Property<int>("so_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("so_id"));

                    b.Property<int?>("Colaboradorescol_id")
                        .HasColumnType("int");

                    b.Property<int?>("Estados_Solicitudeses_id")
                        .HasColumnType("int");

                    b.Property<int?>("SolicitudApelacionso_id")
                        .HasColumnType("int");

                    b.Property<int?>("Tipos_Solicitudests_id")
                        .HasColumnType("int");

                    b.Property<int?>("Usuariosus_id")
                        .HasColumnType("int");

                    b.Property<int?>("so_col_id")
                        .HasColumnType("int");

                    b.Property<int?>("so_col_id_colaborador_modificacion")
                        .HasColumnType("int");

                    b.Property<string>("so_descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("so_es_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("so_fecha_creacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("so_fecha_modificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("so_numero_solicitud")
                        .HasColumnType("longtext");

                    b.Property<string>("so_observaciones")
                        .HasColumnType("longtext");

                    b.Property<string>("so_respuesta")
                        .HasColumnType("longtext");

                    b.Property<int?>("so_so_id")
                        .HasColumnType("int");

                    b.Property<int>("so_ts_id")
                        .HasColumnType("int");

                    b.Property<string>("so_url_image")
                        .HasColumnType("longtext");

                    b.Property<int>("so_us_id")
                        .HasColumnType("int");

                    b.HasKey("so_id");

                    b.HasIndex("Colaboradorescol_id");

                    b.HasIndex("Estados_Solicitudeses_id");

                    b.HasIndex("SolicitudApelacionso_id");

                    b.HasIndex("Tipos_Solicitudests_id");

                    b.HasIndex("Usuariosus_id");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("Core.Entities.Tipo_Identificacion", b =>
                {
                    b.Property<int>("ti_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ti_id"));

                    b.Property<string>("ti_descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("ti_id");

                    b.ToTable("Tipo_Identificacions");
                });

            modelBuilder.Entity("Core.Entities.Tipos_Colaboradores", b =>
                {
                    b.Property<int>("tc_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("tc_id"));

                    b.Property<string>("tc_cargo")
                        .HasColumnType("longtext");

                    b.Property<string>("tc_descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("tc_id");

                    b.ToTable("Tipos_Colaboradores");
                });

            modelBuilder.Entity("Core.Entities.Tipos_Solicitudes", b =>
                {
                    b.Property<int>("ts_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ts_id"));

                    b.Property<string>("ts_descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("ts_nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ts_prioridad")
                        .HasColumnType("int");

                    b.HasKey("ts_id");

                    b.ToTable("Tipos_Solicitudes");
                });

            modelBuilder.Entity("Core.Entities.Tipos_Usuarios", b =>
                {
                    b.Property<int>("tu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("tu_id"));

                    b.Property<string>("tu_tipo_usuario")
                        .HasColumnType("longtext");

                    b.HasKey("tu_id");

                    b.ToTable("Tipos_Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Usuarios", b =>
                {
                    b.Property<int>("us_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("us_id"));

                    b.Property<int?>("Tipo_Identificacionti_id")
                        .HasColumnType("int");

                    b.Property<int?>("Tipos_Usuariostu_id")
                        .HasColumnType("int");

                    b.Property<string>("us_apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("us_correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("us_identificacion")
                        .HasColumnType("longtext");

                    b.Property<string>("us_nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("us_telefono")
                        .HasColumnType("longtext");

                    b.Property<int>("us_ti_id")
                        .HasColumnType("int");

                    b.Property<int>("us_tu_id")
                        .HasColumnType("int");

                    b.HasKey("us_id");

                    b.HasIndex("Tipo_Identificacionti_id");

                    b.HasIndex("Tipos_Usuariostu_id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Colaboradores", b =>
                {
                    b.HasOne("Core.Entities.Colaboradores", "Colaborador_Lider")
                        .WithMany()
                        .HasForeignKey("Colaborador_Lidercol_id");

                    b.HasOne("Core.Entities.Tipos_Colaboradores", "Tipos_Colaboradores")
                        .WithMany()
                        .HasForeignKey("Tipos_Colaboradorestc_id");

                    b.HasOne("Core.Entities.Tipos_Usuarios", "Tipos_Usuarios")
                        .WithMany()
                        .HasForeignKey("Tipos_Usuariostu_id");

                    b.Navigation("Colaborador_Lider");

                    b.Navigation("Tipos_Colaboradores");

                    b.Navigation("Tipos_Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Historicos_Solicitudes", b =>
                {
                    b.HasOne("Core.Entities.Colaboradores", "Colaboradores")
                        .WithMany()
                        .HasForeignKey("Colaboradorescol_id");

                    b.HasOne("Core.Entities.Estados_Solicitudes", "Estados_Solicitudes")
                        .WithMany()
                        .HasForeignKey("Estados_Solicitudeses_id");

                    b.HasOne("Core.Entities.Solicitudes", "Solicitudes")
                        .WithMany()
                        .HasForeignKey("Solicitudesso_id");

                    b.Navigation("Colaboradores");

                    b.Navigation("Estados_Solicitudes");

                    b.Navigation("Solicitudes");
                });

            modelBuilder.Entity("Core.Entities.Solicitudes", b =>
                {
                    b.HasOne("Core.Entities.Colaboradores", "Colaboradores")
                        .WithMany()
                        .HasForeignKey("Colaboradorescol_id");

                    b.HasOne("Core.Entities.Estados_Solicitudes", "Estados_Solicitudes")
                        .WithMany()
                        .HasForeignKey("Estados_Solicitudeses_id");

                    b.HasOne("Core.Entities.Solicitudes", "SolicitudApelacion")
                        .WithMany()
                        .HasForeignKey("SolicitudApelacionso_id");

                    b.HasOne("Core.Entities.Tipos_Solicitudes", "Tipos_Solicitudes")
                        .WithMany()
                        .HasForeignKey("Tipos_Solicitudests_id");

                    b.HasOne("Core.Entities.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("Usuariosus_id");

                    b.Navigation("Colaboradores");

                    b.Navigation("Estados_Solicitudes");

                    b.Navigation("SolicitudApelacion");

                    b.Navigation("Tipos_Solicitudes");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.Usuarios", b =>
                {
                    b.HasOne("Core.Entities.Tipo_Identificacion", "Tipo_Identificacion")
                        .WithMany()
                        .HasForeignKey("Tipo_Identificacionti_id");

                    b.HasOne("Core.Entities.Tipos_Usuarios", "Tipos_Usuarios")
                        .WithMany()
                        .HasForeignKey("Tipos_Usuariostu_id");

                    b.Navigation("Tipo_Identificacion");

                    b.Navigation("Tipos_Usuarios");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

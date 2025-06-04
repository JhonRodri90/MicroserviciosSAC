using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class primermigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estados_Solicitudes",
                columns: table => new
                {
                    es_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    es_nombre_estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Solicitudes", x => x.es_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo_Identificacions",
                columns: table => new
                {
                    ti_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ti_descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Identificacions", x => x.ti_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_Colaboradores",
                columns: table => new
                {
                    tc_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tc_cargo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tc_descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Colaboradores", x => x.tc_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_Solicitudes",
                columns: table => new
                {
                    ts_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ts_nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ts_descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ts_prioridad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Solicitudes", x => x.ts_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_Usuarios",
                columns: table => new
                {
                    tu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tu_tipo_usuario = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Usuarios", x => x.tu_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    col_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    col_nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    col_apellido = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    col_identificacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    col_telefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    col_email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    col_tc_id = table.Column<int>(type: "int", nullable: false),
                    col_tu_id = table.Column<int>(type: "int", nullable: false),
                    col_col_id_lider = table.Column<int>(type: "int", nullable: true),
                    col_activo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Tipos_Colaboradorestc_id = table.Column<int>(type: "int", nullable: true),
                    Tipos_Usuariostu_id = table.Column<int>(type: "int", nullable: true),
                    Colaborador_Lidercol_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.col_id);
                    table.ForeignKey(
                        name: "FK_Colaboradores_Colaboradores_Colaborador_Lidercol_id",
                        column: x => x.Colaborador_Lidercol_id,
                        principalTable: "Colaboradores",
                        principalColumn: "col_id");
                    table.ForeignKey(
                        name: "FK_Colaboradores_Tipos_Colaboradores_Tipos_Colaboradorestc_id",
                        column: x => x.Tipos_Colaboradorestc_id,
                        principalTable: "Tipos_Colaboradores",
                        principalColumn: "tc_id");
                    table.ForeignKey(
                        name: "FK_Colaboradores_Tipos_Usuarios_Tipos_Usuariostu_id",
                        column: x => x.Tipos_Usuariostu_id,
                        principalTable: "Tipos_Usuarios",
                        principalColumn: "tu_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    us_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    us_nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    us_apellido = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    us_ti_id = table.Column<int>(type: "int", nullable: false),
                    us_identificacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    us_telefono = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    us_tu_id = table.Column<int>(type: "int", nullable: false),
                    us_correo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo_Identificacionti_id = table.Column<int>(type: "int", nullable: true),
                    Tipos_Usuariostu_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.us_id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipo_Identificacions_Tipo_Identificacionti_id",
                        column: x => x.Tipo_Identificacionti_id,
                        principalTable: "Tipo_Identificacions",
                        principalColumn: "ti_id");
                    table.ForeignKey(
                        name: "FK_Usuarios_Tipos_Usuarios_Tipos_Usuariostu_id",
                        column: x => x.Tipos_Usuariostu_id,
                        principalTable: "Tipos_Usuarios",
                        principalColumn: "tu_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    so_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    so_numero_solicitud = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    so_ts_id = table.Column<int>(type: "int", nullable: false),
                    so_descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    so_fecha_creacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    so_es_id = table.Column<int>(type: "int", nullable: false),
                    so_us_id = table.Column<int>(type: "int", nullable: false),
                    so_url_image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    so_col_id = table.Column<int>(type: "int", nullable: true),
                    so_observaciones = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    so_respuesta = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    so_fecha_modificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    so_col_id_colaborador_modificacion = table.Column<int>(type: "int", nullable: true),
                    so_so_id = table.Column<int>(type: "int", nullable: true),
                    Tipos_Solicitudests_id = table.Column<int>(type: "int", nullable: true),
                    Estados_Solicitudeses_id = table.Column<int>(type: "int", nullable: true),
                    Usuariosus_id = table.Column<int>(type: "int", nullable: true),
                    Colaboradorescol_id = table.Column<int>(type: "int", nullable: true),
                    SolicitudApelacionso_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.so_id);
                    table.ForeignKey(
                        name: "FK_Solicitudes_Colaboradores_Colaboradorescol_id",
                        column: x => x.Colaboradorescol_id,
                        principalTable: "Colaboradores",
                        principalColumn: "col_id");
                    table.ForeignKey(
                        name: "FK_Solicitudes_Estados_Solicitudes_Estados_Solicitudeses_id",
                        column: x => x.Estados_Solicitudeses_id,
                        principalTable: "Estados_Solicitudes",
                        principalColumn: "es_id");
                    table.ForeignKey(
                        name: "FK_Solicitudes_Solicitudes_SolicitudApelacionso_id",
                        column: x => x.SolicitudApelacionso_id,
                        principalTable: "Solicitudes",
                        principalColumn: "so_id");
                    table.ForeignKey(
                        name: "FK_Solicitudes_Tipos_Solicitudes_Tipos_Solicitudests_id",
                        column: x => x.Tipos_Solicitudests_id,
                        principalTable: "Tipos_Solicitudes",
                        principalColumn: "ts_id");
                    table.ForeignKey(
                        name: "FK_Solicitudes_Usuarios_Usuariosus_id",
                        column: x => x.Usuariosus_id,
                        principalTable: "Usuarios",
                        principalColumn: "us_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Historicos_Solicitudes",
                columns: table => new
                {
                    hs_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    hs_so_id = table.Column<int>(type: "int", nullable: false),
                    hs_es_id = table.Column<int>(type: "int", nullable: false),
                    hs_col_id = table.Column<int>(type: "int", nullable: true),
                    hs_detalle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hs_fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Solicitudesso_id = table.Column<int>(type: "int", nullable: true),
                    Estados_Solicitudeses_id = table.Column<int>(type: "int", nullable: true),
                    Colaboradorescol_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_Solicitudes", x => x.hs_id);
                    table.ForeignKey(
                        name: "FK_Historicos_Solicitudes_Colaboradores_Colaboradorescol_id",
                        column: x => x.Colaboradorescol_id,
                        principalTable: "Colaboradores",
                        principalColumn: "col_id");
                    table.ForeignKey(
                        name: "FK_Historicos_Solicitudes_Estados_Solicitudes_Estados_Solicitud~",
                        column: x => x.Estados_Solicitudeses_id,
                        principalTable: "Estados_Solicitudes",
                        principalColumn: "es_id");
                    table.ForeignKey(
                        name: "FK_Historicos_Solicitudes_Solicitudes_Solicitudesso_id",
                        column: x => x.Solicitudesso_id,
                        principalTable: "Solicitudes",
                        principalColumn: "so_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_Colaborador_Lidercol_id",
                table: "Colaboradores",
                column: "Colaborador_Lidercol_id");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_Tipos_Colaboradorestc_id",
                table: "Colaboradores",
                column: "Tipos_Colaboradorestc_id");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_Tipos_Usuariostu_id",
                table: "Colaboradores",
                column: "Tipos_Usuariostu_id");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_Solicitudes_Colaboradorescol_id",
                table: "Historicos_Solicitudes",
                column: "Colaboradorescol_id");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_Solicitudes_Estados_Solicitudeses_id",
                table: "Historicos_Solicitudes",
                column: "Estados_Solicitudeses_id");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_Solicitudes_Solicitudesso_id",
                table: "Historicos_Solicitudes",
                column: "Solicitudesso_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_Colaboradorescol_id",
                table: "Solicitudes",
                column: "Colaboradorescol_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_Estados_Solicitudeses_id",
                table: "Solicitudes",
                column: "Estados_Solicitudeses_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_SolicitudApelacionso_id",
                table: "Solicitudes",
                column: "SolicitudApelacionso_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_Tipos_Solicitudests_id",
                table: "Solicitudes",
                column: "Tipos_Solicitudests_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_Usuariosus_id",
                table: "Solicitudes",
                column: "Usuariosus_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Tipo_Identificacionti_id",
                table: "Usuarios",
                column: "Tipo_Identificacionti_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Tipos_Usuariostu_id",
                table: "Usuarios",
                column: "Tipos_Usuariostu_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Historicos_Solicitudes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.DropTable(
                name: "Estados_Solicitudes");

            migrationBuilder.DropTable(
                name: "Tipos_Solicitudes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos_Colaboradores");

            migrationBuilder.DropTable(
                name: "Tipo_Identificacions");

            migrationBuilder.DropTable(
                name: "Tipos_Usuarios");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveForeignKeyRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Colaboradores_col_col_id_lider",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Tipos_Colaboradores_col_tc_id",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Tipos_Usuarios_col_tu_id",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Solicitudes_Colaboradores_hs_col_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Solicitudes_Estados_Solicitudes_hs_es_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Solicitudes_Solicitudes_hs_so_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Colaboradores_so_col_id_colaborador_modificacion",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Estados_Solicitudes_so_es_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Solicitudes_so_so_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Tipos_Solicitudes_so_ts_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Usuarios_so_us_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Tipo_Identificacions_us_ti_id",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Tipos_Usuarios_us_tu_id",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_us_ti_id",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_us_tu_id",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_so_col_id_colaborador_modificacion",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_so_es_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_so_so_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_so_ts_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_so_us_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_Solicitudes_hs_col_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_Solicitudes_hs_es_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_Solicitudes_hs_so_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_col_col_id_lider",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_col_tc_id",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_col_tu_id",
                table: "Colaboradores");

            migrationBuilder.AddColumn<int>(
                name: "Tipo_Identificacionti_id",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipos_Usuariostu_id",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Colaboradorescol_id",
                table: "Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estados_Solicitudeses_id",
                table: "Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SolicitudApelacionso_id",
                table: "Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipos_Solicitudests_id",
                table: "Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Usuariosus_id",
                table: "Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Colaboradorescol_id",
                table: "Historicos_Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estados_Solicitudeses_id",
                table: "Historicos_Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Solicitudesso_id",
                table: "Historicos_Solicitudes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Colaborador_Lidercol_id",
                table: "Colaboradores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipos_Colaboradorestc_id",
                table: "Colaboradores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipos_Usuariostu_id",
                table: "Colaboradores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Tipo_Identificacionti_id",
                table: "Usuarios",
                column: "Tipo_Identificacionti_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Tipos_Usuariostu_id",
                table: "Usuarios",
                column: "Tipos_Usuariostu_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Colaboradores_Colaborador_Lidercol_id",
                table: "Colaboradores",
                column: "Colaborador_Lidercol_id",
                principalTable: "Colaboradores",
                principalColumn: "col_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Tipos_Colaboradores_Tipos_Colaboradorestc_id",
                table: "Colaboradores",
                column: "Tipos_Colaboradorestc_id",
                principalTable: "Tipos_Colaboradores",
                principalColumn: "tc_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Tipos_Usuarios_Tipos_Usuariostu_id",
                table: "Colaboradores",
                column: "Tipos_Usuariostu_id",
                principalTable: "Tipos_Usuarios",
                principalColumn: "tu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Solicitudes_Colaboradores_Colaboradorescol_id",
                table: "Historicos_Solicitudes",
                column: "Colaboradorescol_id",
                principalTable: "Colaboradores",
                principalColumn: "col_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Solicitudes_Estados_Solicitudes_Estados_Solicitud~",
                table: "Historicos_Solicitudes",
                column: "Estados_Solicitudeses_id",
                principalTable: "Estados_Solicitudes",
                principalColumn: "es_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Solicitudes_Solicitudes_Solicitudesso_id",
                table: "Historicos_Solicitudes",
                column: "Solicitudesso_id",
                principalTable: "Solicitudes",
                principalColumn: "so_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Colaboradores_Colaboradorescol_id",
                table: "Solicitudes",
                column: "Colaboradorescol_id",
                principalTable: "Colaboradores",
                principalColumn: "col_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Estados_Solicitudes_Estados_Solicitudeses_id",
                table: "Solicitudes",
                column: "Estados_Solicitudeses_id",
                principalTable: "Estados_Solicitudes",
                principalColumn: "es_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Solicitudes_SolicitudApelacionso_id",
                table: "Solicitudes",
                column: "SolicitudApelacionso_id",
                principalTable: "Solicitudes",
                principalColumn: "so_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Tipos_Solicitudes_Tipos_Solicitudests_id",
                table: "Solicitudes",
                column: "Tipos_Solicitudests_id",
                principalTable: "Tipos_Solicitudes",
                principalColumn: "ts_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Usuarios_Usuariosus_id",
                table: "Solicitudes",
                column: "Usuariosus_id",
                principalTable: "Usuarios",
                principalColumn: "us_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Tipo_Identificacions_Tipo_Identificacionti_id",
                table: "Usuarios",
                column: "Tipo_Identificacionti_id",
                principalTable: "Tipo_Identificacions",
                principalColumn: "ti_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Tipos_Usuarios_Tipos_Usuariostu_id",
                table: "Usuarios",
                column: "Tipos_Usuariostu_id",
                principalTable: "Tipos_Usuarios",
                principalColumn: "tu_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Colaboradores_Colaborador_Lidercol_id",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Tipos_Colaboradores_Tipos_Colaboradorestc_id",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Tipos_Usuarios_Tipos_Usuariostu_id",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Solicitudes_Colaboradores_Colaboradorescol_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Solicitudes_Estados_Solicitudes_Estados_Solicitud~",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_Solicitudes_Solicitudes_Solicitudesso_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Colaboradores_Colaboradorescol_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Estados_Solicitudes_Estados_Solicitudeses_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Solicitudes_SolicitudApelacionso_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Tipos_Solicitudes_Tipos_Solicitudests_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Solicitudes_Usuarios_Usuariosus_id",
                table: "Solicitudes");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Tipo_Identificacions_Tipo_Identificacionti_id",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Tipos_Usuarios_Tipos_Usuariostu_id",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Tipo_Identificacionti_id",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Tipos_Usuariostu_id",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_Colaboradorescol_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_Estados_Solicitudeses_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_SolicitudApelacionso_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_Tipos_Solicitudests_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Solicitudes_Usuariosus_id",
                table: "Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_Solicitudes_Colaboradorescol_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_Solicitudes_Estados_Solicitudeses_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_Solicitudes_Solicitudesso_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_Colaborador_Lidercol_id",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_Tipos_Colaboradorestc_id",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_Tipos_Usuariostu_id",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Tipo_Identificacionti_id",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Tipos_Usuariostu_id",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Colaboradorescol_id",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "Estados_Solicitudeses_id",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "SolicitudApelacionso_id",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "Tipos_Solicitudests_id",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "Usuariosus_id",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "Colaboradorescol_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropColumn(
                name: "Estados_Solicitudeses_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropColumn(
                name: "Solicitudesso_id",
                table: "Historicos_Solicitudes");

            migrationBuilder.DropColumn(
                name: "Colaborador_Lidercol_id",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Tipos_Colaboradorestc_id",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Tipos_Usuariostu_id",
                table: "Colaboradores");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_us_ti_id",
                table: "Usuarios",
                column: "us_ti_id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_us_tu_id",
                table: "Usuarios",
                column: "us_tu_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_so_col_id_colaborador_modificacion",
                table: "Solicitudes",
                column: "so_col_id_colaborador_modificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_so_es_id",
                table: "Solicitudes",
                column: "so_es_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_so_so_id",
                table: "Solicitudes",
                column: "so_so_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_so_ts_id",
                table: "Solicitudes",
                column: "so_ts_id");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_so_us_id",
                table: "Solicitudes",
                column: "so_us_id");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_Solicitudes_hs_col_id",
                table: "Historicos_Solicitudes",
                column: "hs_col_id");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_Solicitudes_hs_es_id",
                table: "Historicos_Solicitudes",
                column: "hs_es_id");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_Solicitudes_hs_so_id",
                table: "Historicos_Solicitudes",
                column: "hs_so_id");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_col_col_id_lider",
                table: "Colaboradores",
                column: "col_col_id_lider");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_col_tc_id",
                table: "Colaboradores",
                column: "col_tc_id");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_col_tu_id",
                table: "Colaboradores",
                column: "col_tu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Colaboradores_col_col_id_lider",
                table: "Colaboradores",
                column: "col_col_id_lider",
                principalTable: "Colaboradores",
                principalColumn: "col_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Tipos_Colaboradores_col_tc_id",
                table: "Colaboradores",
                column: "col_tc_id",
                principalTable: "Tipos_Colaboradores",
                principalColumn: "tc_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Tipos_Usuarios_col_tu_id",
                table: "Colaboradores",
                column: "col_tu_id",
                principalTable: "Tipos_Usuarios",
                principalColumn: "tu_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Solicitudes_Colaboradores_hs_col_id",
                table: "Historicos_Solicitudes",
                column: "hs_col_id",
                principalTable: "Colaboradores",
                principalColumn: "col_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Solicitudes_Estados_Solicitudes_hs_es_id",
                table: "Historicos_Solicitudes",
                column: "hs_es_id",
                principalTable: "Estados_Solicitudes",
                principalColumn: "es_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_Solicitudes_Solicitudes_hs_so_id",
                table: "Historicos_Solicitudes",
                column: "hs_so_id",
                principalTable: "Solicitudes",
                principalColumn: "so_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Colaboradores_so_col_id_colaborador_modificacion",
                table: "Solicitudes",
                column: "so_col_id_colaborador_modificacion",
                principalTable: "Colaboradores",
                principalColumn: "col_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Estados_Solicitudes_so_es_id",
                table: "Solicitudes",
                column: "so_es_id",
                principalTable: "Estados_Solicitudes",
                principalColumn: "es_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Solicitudes_so_so_id",
                table: "Solicitudes",
                column: "so_so_id",
                principalTable: "Solicitudes",
                principalColumn: "so_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Tipos_Solicitudes_so_ts_id",
                table: "Solicitudes",
                column: "so_ts_id",
                principalTable: "Tipos_Solicitudes",
                principalColumn: "ts_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitudes_Usuarios_so_us_id",
                table: "Solicitudes",
                column: "so_us_id",
                principalTable: "Usuarios",
                principalColumn: "us_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Tipo_Identificacions_us_ti_id",
                table: "Usuarios",
                column: "us_ti_id",
                principalTable: "Tipo_Identificacions",
                principalColumn: "ti_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Tipos_Usuarios_us_tu_id",
                table: "Usuarios",
                column: "us_tu_id",
                principalTable: "Tipos_Usuarios",
                principalColumn: "tu_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

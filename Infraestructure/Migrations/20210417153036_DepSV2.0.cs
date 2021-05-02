using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Migrations
{
    public partial class DepSV20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEPSV_ZONESV_zoneSVID",
                table: "DEPSV");

            migrationBuilder.DropForeignKey(
                name: "FK_MUNSV_DEPSV_DEPSV_IDID",
                table: "MUNSV");

            migrationBuilder.RenameColumn(
                name: "DEPSV_IDID",
                table: "MUNSV",
                newName: "DepSVID");

            migrationBuilder.RenameIndex(
                name: "IX_MUNSV_DEPSV_IDID",
                table: "MUNSV",
                newName: "IX_MUNSV_DepSVID");

            migrationBuilder.RenameColumn(
                name: "zoneSVID",
                table: "DEPSV",
                newName: "ZoneSVID");

            migrationBuilder.RenameIndex(
                name: "IX_DEPSV_zoneSVID",
                table: "DEPSV",
                newName: "IX_DEPSV_ZoneSVID");

            migrationBuilder.AddColumn<int>(
                name: "DEPSV_ID",
                table: "MUNSV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DEPSV_ZONESV_ZoneSVID",
                table: "DEPSV",
                column: "ZoneSVID",
                principalTable: "ZONESV",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MUNSV_DEPSV_DepSVID",
                table: "MUNSV",
                column: "DepSVID",
                principalTable: "DEPSV",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEPSV_ZONESV_ZoneSVID",
                table: "DEPSV");

            migrationBuilder.DropForeignKey(
                name: "FK_MUNSV_DEPSV_DepSVID",
                table: "MUNSV");

            migrationBuilder.DropColumn(
                name: "DEPSV_ID",
                table: "MUNSV");

            migrationBuilder.RenameColumn(
                name: "DepSVID",
                table: "MUNSV",
                newName: "DEPSV_IDID");

            migrationBuilder.RenameIndex(
                name: "IX_MUNSV_DepSVID",
                table: "MUNSV",
                newName: "IX_MUNSV_DEPSV_IDID");

            migrationBuilder.RenameColumn(
                name: "ZoneSVID",
                table: "DEPSV",
                newName: "zoneSVID");

            migrationBuilder.RenameIndex(
                name: "IX_DEPSV_ZoneSVID",
                table: "DEPSV",
                newName: "IX_DEPSV_zoneSVID");

            migrationBuilder.AddForeignKey(
                name: "FK_DEPSV_ZONESV_zoneSVID",
                table: "DEPSV",
                column: "zoneSVID",
                principalTable: "ZONESV",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MUNSV_DEPSV_DEPSV_IDID",
                table: "MUNSV",
                column: "DEPSV_IDID",
                principalTable: "DEPSV",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

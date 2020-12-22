using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedCousinsApp.Migrations
{
    public partial class membermodel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Role_RoleId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Members",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Role_RoleId",
                table: "Members",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Role_RoleId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Members",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Role_RoleId",
                table: "Members",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

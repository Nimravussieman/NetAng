using Microsoft.EntityFrameworkCore.Migrations;

namespace NetAng.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserNames",
                type: "text",
                nullable: true,
                computedColumnSql: "\"FirstName\" || ' ' || \"LastName\"|| ' ' || \"SurName\"",
                stored: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserNames",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldComputedColumnSql: "\"FirstName\" || ' ' || \"LastName\"|| ' ' || \"SurName\"");
        }
    }
}

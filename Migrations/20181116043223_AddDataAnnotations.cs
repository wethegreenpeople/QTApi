using Microsoft.EntityFrameworkCore.Migrations;

namespace QTApi.Migrations
{
    public partial class AddDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fact",
                table: "CatFacts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fact",
                table: "CatFacts",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

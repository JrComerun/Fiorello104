using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class ChangeColumnInSliderDatasTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title1",
                table: "SliderDatas",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SliderDatas",
                newName: "Title1");
        }
    }
}

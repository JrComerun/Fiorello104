using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class AddSeedDataSliderDatasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SliderDatas",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[] { 1, "h2-sign-img.png", " Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.", " <h1>Send <span>flowers</span> like</h1>< h1 > you mean it </h1>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SliderDatas",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

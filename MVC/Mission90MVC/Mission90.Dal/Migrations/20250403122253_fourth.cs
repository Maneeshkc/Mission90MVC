using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission90.Dal.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_Id", "Category_Name", "DisplayOrder" },
                values: new object[] { 4, "test3", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Category_Id",
                keyValue: 4);
        }
    }
}

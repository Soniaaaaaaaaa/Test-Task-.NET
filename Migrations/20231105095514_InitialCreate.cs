 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Task.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    CatalogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCatalogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.CatalogId);
                    table.ForeignKey(
                        name: "FK_Catalogs_Catalogs_ParentCatalogId",
                        column: x => x.ParentCatalogId,
                        principalTable: "Catalogs",
                        principalColumn: "CatalogId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catalogs_ParentCatalogId",
                table: "Catalogs",
                column: "ParentCatalogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogs");
        }
    }
}

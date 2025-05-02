using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCoreDay.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "socialmedias",
                columns: table => new
                {
                    SocialmediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialmediaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialmediaClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialmediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socialmediaİcon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialmedias", x => x.SocialmediaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "socialmedias");
        }
    }
}

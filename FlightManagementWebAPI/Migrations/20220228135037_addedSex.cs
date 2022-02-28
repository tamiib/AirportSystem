using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManagementWebAPI.Migrations
{
    public partial class addedSex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "SexId",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_SexId",
                table: "Passengers",
                column: "SexId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Sexes_SexId",
                table: "Passengers",
                column: "SexId",
                principalTable: "Sexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Sexes_SexId",
                table: "Passengers");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_SexId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "SexId",
                table: "Passengers");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Passengers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }
    }
}

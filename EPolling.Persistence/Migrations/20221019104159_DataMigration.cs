using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPolling.Persistence.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LGAs",
                columns: table => new
                {
                    LgaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LGA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LGAs", x => x.LgaId);
                });

            migrationBuilder.CreateTable(
                name: "Pollingnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    LGAId = table.Column<int>(type: "int", nullable: false),
                    WardId = table.Column<int>(type: "int", nullable: false),
                    PollingUnitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pollingnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    WardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LgaId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.WardId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                column: "ConcurrencyStamp",
                value: "6c5b89a2-2d5b-45a1-b90b-03c2152ce582");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363403d4-83e9-409a-bc50-2185af49968c",
                column: "ConcurrencyStamp",
                value: "44eaf082-20b3-46e8-992b-7bdc632d4853");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99254314-a271-47be-af1a-f1d78693731b",
                column: "ConcurrencyStamp",
                value: "04b19859-3f4c-400e-9eb1-49e4afb70b0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56f97a8d-3571-4505-9f93-e2d6caed4525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e36a741-195d-47b5-ab68-eb34c6b6e0f2", "AQAAAAEAACcQAAAAEED/veNQMCyV/579YNGLyl+5u6wR0E0X9qCRwxCq7DWMhEllUKlUs1v0HOwYEf7jZA==", "a998aaa5-39e4-40a3-b948-effae38cf286" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7426a8db-b16d-497d-bfa3-e0b29b6a0fec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324b9c15-231b-4c53-bbca-0e08f1807736", "AQAAAAEAACcQAAAAEBGuQi+J7fG3VFBYLI3Qq4tyca3Ix2I2ju/AJQ2lhQTdZaU6yQoiMQ/kLSQmM0EDRw==", "74d2bc33-0fdc-4b9c-bd6b-6b16d6017426" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50af610-518d-4f5f-8422-ea54c733771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9bdba5-7e52-402d-8d88-35114bfbdd12", "AQAAAAEAACcQAAAAEB7L2nbSlLLqSrF9jgg6w8B30514zW1UBitQitBw4r47IgVPAmbY6qSTxpt/CRtMIw==", "911131cc-4b3d-4dfc-88ab-d0dade497015" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LGAs");

            migrationBuilder.DropTable(
                name: "Pollingnits");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Wards");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                column: "ConcurrencyStamp",
                value: "ba2bca19-7da0-4572-9c21-453e8eba69db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363403d4-83e9-409a-bc50-2185af49968c",
                column: "ConcurrencyStamp",
                value: "92d389fc-f86e-453e-bde9-a79880398c7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99254314-a271-47be-af1a-f1d78693731b",
                column: "ConcurrencyStamp",
                value: "b297791f-3541-404b-a842-b83ac40e201d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56f97a8d-3571-4505-9f93-e2d6caed4525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6043a39-a980-4448-9621-16a1d6438920", "AQAAAAEAACcQAAAAELWD5T6fFPcLfSsxxfm0/M83RAi8baeJjVyuwWk+LYW1/90znSDd6BtdYBjlrGmUnQ==", "d017db17-d6bd-4e3d-b966-47fcda1c7b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7426a8db-b16d-497d-bfa3-e0b29b6a0fec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b607fd8d-b521-4a3b-9c30-f94e4c2bf016", "AQAAAAEAACcQAAAAEJHHwA02Wr/EkACuq0rBxfMX+j5MKD+DsQUXkQnAtFkk4xI3KGnUC7WYr7ijD6ZYJQ==", "ea56397a-7905-40a9-a46b-7cda62f9e59c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50af610-518d-4f5f-8422-ea54c733771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05928ccf-f59c-464e-aa95-beb1567ed94d", "AQAAAAEAACcQAAAAEMGfB+QiUIoW71n+6oNqvE6x+Lya0/J5197piaCgTmLFyOjnvu7kOC6PYD6IbH3c+w==", "128e7e12-9f81-4724-b384-f736dee5340b" });
        }
    }
}

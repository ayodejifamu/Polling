using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPolling.Persistence.Migrations
{
    public partial class IdGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                column: "ConcurrencyStamp",
                value: "39d832dc-88d0-43be-b305-4936cf453e35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363403d4-83e9-409a-bc50-2185af49968c",
                column: "ConcurrencyStamp",
                value: "6f86ee4c-d5f3-4259-a325-243fa5054457");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99254314-a271-47be-af1a-f1d78693731b",
                column: "ConcurrencyStamp",
                value: "4b4571f4-cc2e-4246-b709-65a16f2bd90e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56f97a8d-3571-4505-9f93-e2d6caed4525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66afa801-ccec-49fc-9cf8-88726c89e99c", "AQAAAAEAACcQAAAAEKhWmn1YoYgk6lyytiFd4SK2F/3+spDzjV/m+lAv+ISma47+jHzuzPgClTOxn51prg==", "df69fdfb-815a-4ac1-aa4c-6fe8aa09b7a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7426a8db-b16d-497d-bfa3-e0b29b6a0fec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8596df62-71c1-4fdf-af09-753c2ab15fbe", "AQAAAAEAACcQAAAAEDit8keWLAV+F9RdBWLs4cpoeFm/8SvbESrh2+9lBdDvY6qeNW0SE3/WXc2nNti4gw==", "e4899919-de8b-41b2-bacb-4be423c0a62b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50af610-518d-4f5f-8422-ea54c733771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f87109-4de3-42e0-a353-f30a42551078", "AQAAAAEAACcQAAAAEKExjc1sPeDC147JZQIWZpnfRaPI9iFNs/WcBwJCQbOosTOWdzbE9yqvTqfDXSmoHg==", "887beae7-af6b-45a3-aaf3-f424ec0ff671" });
        }
    }
}

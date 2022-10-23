using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPolling.Persistence.Migrations
{
    public partial class UserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PollingUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PVC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                column: "ConcurrencyStamp",
                value: "f38a1aad-1b4f-4066-a901-935416b83983");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363403d4-83e9-409a-bc50-2185af49968c",
                column: "ConcurrencyStamp",
                value: "dbcbd6e9-f73a-4adc-8adc-4f84cb670451");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99254314-a271-47be-af1a-f1d78693731b",
                column: "ConcurrencyStamp",
                value: "37b572b8-5fc5-4361-aa5f-4acb3970600a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56f97a8d-3571-4505-9f93-e2d6caed4525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80cd0bdb-380b-47f5-a706-782318a86926", "AQAAAAEAACcQAAAAEA5ESDZfMkQ1PvDIONavSD6X3FJVeT+8bo6zolMKxk2Os6TMWZlC22DwYGjIeEeeLA==", "cec2aad7-dc7e-41c6-b0bd-9962da845d34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7426a8db-b16d-497d-bfa3-e0b29b6a0fec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e535f47-5abd-4b24-baf6-41eca4d8ec21", "AQAAAAEAACcQAAAAEKKgcu/NxT7WMPN4nb3ANxB8UNz+A90jka7jCBtzy/nDrKObeIFkZgxg7NmOnVNcsA==", "7363cf4e-1d44-4363-b85a-ffb2987ed591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50af610-518d-4f5f-8422-ea54c733771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0131b436-5acc-4192-aad2-4d3358dff5c9", "AQAAAAEAACcQAAAAEKnvQPg4ixrKiSh/iTyWXpRs4rm67G3+YOrOunNy7eUQTRVfz8Y/sKrnxOKaEeX9dQ==", "5acbbbef-6c92-4849-9d55-f1d378d0fab2" });
        }
    }
}

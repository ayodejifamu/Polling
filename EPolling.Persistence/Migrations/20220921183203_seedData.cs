using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPolling.Persistence.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                column: "ConcurrencyStamp",
                value: "0e7ca998-46d3-476d-8fb7-6474a7b65ba4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363403d4-83e9-409a-bc50-2185af49968c",
                column: "ConcurrencyStamp",
                value: "d4a838d3-87f5-4763-b766-4fe087769370");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99254314-a271-47be-af1a-f1d78693731b",
                column: "ConcurrencyStamp",
                value: "2b12228d-18ad-4205-87b5-028e62fa380d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56f97a8d-3571-4505-9f93-e2d6caed4525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bce14279-c9d8-49ee-ba5a-6d69c55ac24f", "AQAAAAEAACcQAAAAEJ/Gstq2NEuUu4VzQ6vpvpY/42Ls60ixRxMW+stYcd/vRUybUt/3+jPDyzS+55/OlQ==", "6bf34793-13ab-4b26-b838-91540279619b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7426a8db-b16d-497d-bfa3-e0b29b6a0fec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d6fdbe9-7cba-40be-a131-7be8bc86de81", "AQAAAAEAACcQAAAAEFAszqBF/HTxrvKHbGFUArNrCyqORyTsehUGpJLM2XCK3nVeVvlGs8fUcIreAib4+A==", "1466cbc9-04a2-430f-bd79-ce79ebe39a2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50af610-518d-4f5f-8422-ea54c733771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9dd16e6-f420-4b98-95c2-5ff2f55ca4b6", "AQAAAAEAACcQAAAAEHfo3JK/K4Q9wlF+nUAoLquomQZDMTOuSuDCqwt+3078eSPAS1f+u/OcSDiRLUZekA==", "f9853daf-2596-4414-893e-f0ee2ff8287b" });
        }
    }
}

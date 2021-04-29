using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "user",
                schema: "dbo",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    user_username = table.Column<string>(nullable: false),
                    user_password = table.Column<string>(nullable: false),
                    user_firstname = table.Column<string>(nullable: false),
                    user_lastname = table.Column<string>(nullable: false),
                    user_gender = table.Column<int>(nullable: false),
                    user_email = table.Column<string>(nullable: false),
                    user_phone = table.Column<string>(nullable: false),
                    user_birthday = table.Column<DateTime>(nullable: false),
                    user_avatar = table.Column<string>(nullable: true),
                    user_status = table.Column<int>(nullable: false),
                    user_created_by = table.Column<int>(nullable: false),
                    user_created_at = table.Column<DateTime>(nullable: true),
                    user_updated_by = table.Column<DateTime>(nullable: true),
                    user_isdeleted = table.Column<int>(nullable: false),
                    user_token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "user",
                columns: new[] { "user_id", "user_avatar", "user_birthday", "user_created_at", "user_created_by", "user_email", "user_firstname", "user_gender", "user_isdeleted", "user_lastname", "user_password", "user_phone", "user_status", "user_token", "user_updated_by", "user_username" },
                values: new object[] { 1, null, new DateTime(2021, 4, 29, 11, 16, 32, 267, DateTimeKind.Local), new DateTime(2021, 4, 29, 11, 16, 32, 266, DateTimeKind.Local), 1, "nttung@gmai.com", "Tung", 1, 0, "Nguyen", "nttung", "096431808", 1, null, null, "nttung" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "user",
                columns: new[] { "user_id", "user_avatar", "user_birthday", "user_created_at", "user_created_by", "user_email", "user_firstname", "user_gender", "user_isdeleted", "user_lastname", "user_password", "user_phone", "user_status", "user_token", "user_updated_by", "user_username" },
                values: new object[] { 2, null, new DateTime(2021, 4, 29, 11, 16, 32, 267, DateTimeKind.Local), new DateTime(2021, 4, 29, 11, 16, 32, 267, DateTimeKind.Local), 1, "abc@gmai.com", "abc", 1, 0, "abc", "abc", "096431808", 1, null, null, "abc" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "user",
                columns: new[] { "user_id", "user_avatar", "user_birthday", "user_created_at", "user_created_by", "user_email", "user_firstname", "user_gender", "user_isdeleted", "user_lastname", "user_password", "user_phone", "user_status", "user_token", "user_updated_by", "user_username" },
                values: new object[] { 3, null, new DateTime(2021, 4, 29, 11, 16, 32, 267, DateTimeKind.Local), new DateTime(2021, 4, 29, 11, 16, 32, 267, DateTimeKind.Local), 1, "xyz@gmai.com", "xyz", 1, 0, "xyz", "xyz", "096431808", 1, null, null, "xyz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user",
                schema: "dbo");
        }
    }
}

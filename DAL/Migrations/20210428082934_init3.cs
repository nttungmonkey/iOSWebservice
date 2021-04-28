using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init3 : Migration
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
                    user_created_by = table.Column<string>(nullable: false),
                    user_created_at = table.Column<DateTime>(nullable: true),
                    user_updated_by = table.Column<DateTime>(nullable: true),
                    user_isdeleted = table.Column<int>(nullable: false),
                    user_token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user",
                schema: "dbo");
        }
    }
}

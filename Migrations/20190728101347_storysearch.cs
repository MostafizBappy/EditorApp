using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EditorApp.API.Migrations
{
    public partial class storysearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "View_StorySearch",
                columns: table => new
                {
                    StoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoryHeading = table.Column<string>(maxLength: 500, nullable: true),
                    StoryBody = table.Column<string>(nullable: true),
                    StoryWord = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StoryDate = table.Column<DateTime>(type: "date", nullable: true),
                    StoryDesk = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Keyword = table.Column<string>(maxLength: 250, nullable: true),
                    UserCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    StoryType = table.Column<string>(maxLength: 50, nullable: true),
                    NewswrapCenter = table.Column<int>(nullable: true),
                    ldapint = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View_StorySearch", x => x.StoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "View_StorySearch");
        }
    }
}

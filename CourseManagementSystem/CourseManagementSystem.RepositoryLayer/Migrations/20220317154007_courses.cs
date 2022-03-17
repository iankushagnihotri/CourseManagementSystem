using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseManagementSystem.RepositoryLayer.Migrations
{
    public partial class courses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Course_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}

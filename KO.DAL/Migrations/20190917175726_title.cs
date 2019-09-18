using Microsoft.EntityFrameworkCore.Migrations;

namespace KO.DAL.Migrations
{
    public partial class title : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "OptionsOfQuestions");

            migrationBuilder.AlterColumn<string>(
                name: "Option",
                table: "OptionsOfQuestions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exams");

            migrationBuilder.AlterColumn<string>(
                name: "Option",
                table: "OptionsOfQuestions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "OptionsOfQuestions",
                nullable: false,
                defaultValue: false);
        }
    }
}

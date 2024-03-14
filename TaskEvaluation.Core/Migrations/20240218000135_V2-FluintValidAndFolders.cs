using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskEvaluation.Core.Migrations
{
    /// <inheritdoc />
    public partial class V2FluintValidAndFolders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Books_CourseId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Solution_EvaluationGrade_GradeId",
                table: "Solution");

            migrationBuilder.DropForeignKey(
                name: "FK_Solution_Students_StudentId",
                table: "Solution");

            migrationBuilder.DropForeignKey(
                name: "FK_Solution_Task_TaskId",
                table: "Solution");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_GroupId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solution",
                table: "Solution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvaluationGrade",
                table: "EvaluationGrade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Solution",
                newName: "Solutions");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "EvaluationGrade",
                newName: "EvaluationGrades");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Solution_TaskId",
                table: "Solutions",
                newName: "IX_Solutions_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Solution_StudentId",
                table: "Solutions",
                newName: "IX_Solutions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Solution_GradeId",
                table: "Solutions",
                newName: "IX_Solutions_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Group_CourseId",
                table: "Groups",
                newName: "IX_Groups_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solutions",
                table: "Solutions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvaluationGrades",
                table: "EvaluationGrades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_GroupId",
                table: "Assignments",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Courses_CourseId",
                table: "Groups",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_Assignments_TaskId",
                table: "Solutions",
                column: "TaskId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_EvaluationGrades_GradeId",
                table: "Solutions",
                column: "GradeId",
                principalTable: "EvaluationGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_Students_StudentId",
                table: "Solutions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Courses_CourseId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_Assignments_TaskId",
                table: "Solutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_EvaluationGrades_GradeId",
                table: "Solutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_Students_StudentId",
                table: "Solutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solutions",
                table: "Solutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvaluationGrades",
                table: "EvaluationGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Solutions",
                newName: "Solution");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameTable(
                name: "EvaluationGrades",
                newName: "EvaluationGrade");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Solutions_TaskId",
                table: "Solution",
                newName: "IX_Solution_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Solutions_StudentId",
                table: "Solution",
                newName: "IX_Solution_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Solutions_GradeId",
                table: "Solution",
                newName: "IX_Solution_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_CourseId",
                table: "Group",
                newName: "IX_Group_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solution",
                table: "Solution",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvaluationGrade",
                table: "EvaluationGrade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_GroupId",
                table: "Task",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Books_CourseId",
                table: "Group",
                column: "CourseId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solution_EvaluationGrade_GradeId",
                table: "Solution",
                column: "GradeId",
                principalTable: "EvaluationGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solution_Students_StudentId",
                table: "Solution",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solution_Task_TaskId",
                table: "Solution",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

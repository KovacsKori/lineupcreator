using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lineupcreator.Migrations
{
    /// <inheritdoc />
    public partial class FootballMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_playerstable$",
                table: "playerstable$");

            migrationBuilder.DropColumn(
                name: "club_logo_url",
                table: "playerstable$");

            migrationBuilder.DropColumn(
                name: "club_name",
                table: "playerstable$");

            migrationBuilder.DropColumn(
                name: "league_name",
                table: "playerstable$");

            migrationBuilder.DropColumn(
                name: "nation_flag_url",
                table: "playerstable$");

            migrationBuilder.DropColumn(
                name: "nationality_name",
                table: "playerstable$");

            migrationBuilder.DropColumn(
                name: "player_url",
                table: "playerstable$");

            migrationBuilder.RenameTable(
                name: "playerstable$",
                newName: "player");

            migrationBuilder.AlterColumn<int>(
                name: "weak_foot",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "skill_moves",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "shooting",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "physic",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "passing",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pace",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "overall",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "nationality_id",
                table: "player",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "height_cm",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "dribbling",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "defending",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "club_team_id",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "club_jersey_number",
                table: "player",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "sofifa_id",
                table: "player",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_player",
                table: "player",
                column: "sofifa_id");

            migrationBuilder.CreateTable(
                name: "club",
                columns: table => new
                {
                    club_team_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    club_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    league_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    club_logo_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_club", x => x.club_team_id);
                });

            migrationBuilder.CreateTable(
                name: "nationality",
                columns: table => new
                {
                    nationality_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationality_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nation_flag_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationality", x => x.nationality_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_club_team_id",
                table: "player",
                column: "club_team_id");

            migrationBuilder.CreateIndex(
                name: "IX_player_nationality_id",
                table: "player",
                column: "nationality_id");

            migrationBuilder.AddForeignKey(
                name: "FK_player_club_club_team_id",
                table: "player",
                column: "club_team_id",
                principalTable: "club",
                principalColumn: "club_team_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_player_nationality_nationality_id",
                table: "player",
                column: "nationality_id",
                principalTable: "nationality",
                principalColumn: "nationality_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_club_club_team_id",
                table: "player");

            migrationBuilder.DropForeignKey(
                name: "FK_player_nationality_nationality_id",
                table: "player");

            migrationBuilder.DropTable(
                name: "club");

            migrationBuilder.DropTable(
                name: "nationality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_player",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_club_team_id",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_nationality_id",
                table: "player");

            migrationBuilder.RenameTable(
                name: "player",
                newName: "playerstable$");

            migrationBuilder.AlterColumn<double>(
                name: "weak_foot",
                table: "playerstable$",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "skill_moves",
                table: "playerstable$",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "shooting",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "physic",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "passing",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "pace",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "overall",
                table: "playerstable$",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "nationality_id",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "height_cm",
                table: "playerstable$",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "dribbling",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "defending",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "club_team_id",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "club_jersey_number",
                table: "playerstable$",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "age",
                table: "playerstable$",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "sofifa_id",
                table: "playerstable$",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "club_logo_url",
                table: "playerstable$",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "club_name",
                table: "playerstable$",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "league_name",
                table: "playerstable$",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nation_flag_url",
                table: "playerstable$",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nationality_name",
                table: "playerstable$",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "player_url",
                table: "playerstable$",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_playerstable$",
                table: "playerstable$",
                column: "sofifa_id");
        }
    }
}

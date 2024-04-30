using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lineupcreator.Migrations
{
    /// <inheritdoc />
    public partial class Football : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "playerstable$",
                columns: table => new
                {
                    sofifa_id = table.Column<double>(type: "float", nullable: false),
                    player_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    short_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    long_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    overall = table.Column<double>(type: "float", nullable: false),
                    player_positions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<double>(type: "float", nullable: false),
                    height_cm = table.Column<double>(type: "float", nullable: false),
                    club_team_id = table.Column<double>(type: "float", nullable: true),
                    club_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    league_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    club_jersey_number = table.Column<double>(type: "float", nullable: true),
                    nationality_id = table.Column<double>(type: "float", nullable: true),
                    nationality_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preferred_foot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weak_foot = table.Column<double>(type: "float", nullable: false),
                    skill_moves = table.Column<double>(type: "float", nullable: false),
                    work_rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    player_traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pace = table.Column<double>(type: "float", nullable: true),
                    shooting = table.Column<double>(type: "float", nullable: true),
                    passing = table.Column<double>(type: "float", nullable: true),
                    dribbling = table.Column<double>(type: "float", nullable: true),
                    defending = table.Column<double>(type: "float", nullable: true),
                    physic = table.Column<double>(type: "float", nullable: true),
                    player_face_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    club_logo_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nation_flag_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playerstable$", x => x.sofifa_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "playerstable$");
        }
    }
}

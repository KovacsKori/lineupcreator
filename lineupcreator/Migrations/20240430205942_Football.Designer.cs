﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lineupcreator.Components.Services;

#nullable disable

namespace lineupcreator.Migrations
{
    [DbContext(typeof(FootballDbContext))]
    [Migration("20240430205942_Football")]
    partial class Football
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("lineupcreator.Components.Data.Player", b =>
                {
                    b.Property<double>("sofifa_id")
                        .HasColumnType("float")
                        .HasColumnName("sofifa_id");

                    b.Property<double>("age")
                        .HasColumnType("float")
                        .HasColumnName("age");

                    b.Property<double?>("club_jersey_number")
                        .HasColumnType("float")
                        .HasColumnName("club_jersey_number");

                    b.Property<string>("club_logo_url")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("club_logo_url");

                    b.Property<string>("club_name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("club_name");

                    b.Property<double?>("club_team_id")
                        .HasColumnType("float")
                        .HasColumnName("club_team_id");

                    b.Property<double?>("defending")
                        .HasColumnType("float")
                        .HasColumnName("defending");

                    b.Property<double?>("dribbling")
                        .HasColumnType("float")
                        .HasColumnName("dribbling");

                    b.Property<double>("height_cm")
                        .HasColumnType("float")
                        .HasColumnName("height_cm");

                    b.Property<string>("league_name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("league_name");

                    b.Property<string>("long_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("long_name");

                    b.Property<string>("nation_flag_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nation_flag_url");

                    b.Property<double?>("nationality_id")
                        .HasColumnType("float")
                        .HasColumnName("nationality_id");

                    b.Property<string>("nationality_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nationality_name");

                    b.Property<double>("overall")
                        .HasColumnType("float")
                        .HasColumnName("overall");

                    b.Property<double?>("pace")
                        .HasColumnType("float")
                        .HasColumnName("pace");

                    b.Property<double?>("passing")
                        .HasColumnType("float")
                        .HasColumnName("passing");

                    b.Property<double?>("physic")
                        .HasColumnType("float")
                        .HasColumnName("physic");

                    b.Property<string>("player_face_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("player_face_url");

                    b.Property<string>("player_positions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("player_positions");

                    b.Property<string>("player_traits")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("player_traits");

                    b.Property<string>("player_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("player_url");

                    b.Property<string>("preferred_foot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("preferred_foot");

                    b.Property<double?>("shooting")
                        .HasColumnType("float")
                        .HasColumnName("shooting");

                    b.Property<string>("short_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("short_name");

                    b.Property<double>("skill_moves")
                        .HasColumnType("float")
                        .HasColumnName("skill_moves");

                    b.Property<double>("weak_foot")
                        .HasColumnType("float")
                        .HasColumnName("weak_foot");

                    b.Property<string>("work_rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("work_rate");

                    b.HasKey("sofifa_id");

                    b.ToTable("playerstable$", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

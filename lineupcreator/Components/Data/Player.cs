using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lineupcreator.Components.Data
{
    public class Player
    {
        [Key]
        [Column("sofifa_id")]
        public int sofifa_id { get; set; }

        [Column("short_name")]
        public string short_name { get; set; }

        [Column("long_name")]
        public string long_name { get; set; }

        [Column("overall")]
        public int overall { get; set; }

        [Column("player_positions")]
        public string player_positions { get; set; }

        [Column("age")]
        public int age { get; set; }

        [Column("height_cm")]
        public int height_cm { get; set; }

        [Column("club_team_id")]
        public int? club_team_id { get; set; }

        [Column("club_jersey_number")]
        public int? club_jersey_number { get; set; }

        [Column("nationality_id")]
        public int nationality_id { get; set; }

        [Column("preferred_foot")]
        public string preferred_foot { get; set; }

        [Column("weak_foot")]
        public int weak_foot { get; set; }

        [Column("skill_moves")]
        public int skill_moves { get; set; }

        [Column("work_rate")]
        public string work_rate { get; set; }

        [Column("player_traits")]
        public string? player_traits { get; set; }

        [Column("pace")]
        public int? pace { get; set; }

        [Column("shooting")]
        public int? shooting { get; set; }

        [Column("passing")]
        public int? passing { get; set; }

        [Column("dribbling")]
        public int? dribbling { get; set; }

        [Column("defending")]
        public int? defending { get; set; }

        [Column("physic")]
        public int? physic { get; set; }
        
        [Column("player_face_url")]
        public string player_face_url { get; set; }

        [ForeignKey("club_team_id")]
        public virtual Club Club { get; set; }

        [ForeignKey("nationality_id")]
        public virtual Nation Nation { get; set; }

    }

} 
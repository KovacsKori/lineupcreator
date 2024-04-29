using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace lineupcreator.Components.Data
{
    public class Player
    {
        [Column("sofifa_id")]
        public float sofifa_id { get; set; }

        [Column("player_url")]
        public string player_url { get; set; }

        [Column("short_name")]
        public string short_name { get; set; }

        [Column("long_name")]
        public string long_name { get; set; }

        [Column("overall")]
        public float overall { get; set; }

        [Column("player_positions")]
        public string player_positions { get; set; }

        [Column("age")]
        public float age { get; set; }

        [Column("height_cm")]
        public float height_cm { get; set; }

        [Column("club_team_id")]
        public float? club_team_id { get; set; }

        [Column("club_name")]
        public string? club_name { get; set; }

        [Column("league_name")]
        public string? league_name { get; set; }

        [Column("club_jersey_number")]
        public float? club_jersey_number { get; set; }

        [Column("nationality_id")]
        public float? nationality_id { get; set; }

        [Column("nationality_name")]
        public string nationality_name { get; set; }

        [Column("preferred_foot")]
        public string preferred_foot { get; set; }

        [Column("weak_foot")]
        public float weak_foot { get; set; }

        [Column("skill_moves")]
        public float skill_moves { get; set; }

        [Column("work_rate")]
        public string work_rate { get; set; }

        [Column("player_traits")]
        public string? player_traits { get; set; }

        [Column("pace")]
        public float? pace { get; set; }

        [Column("shooting")]
        public float? shooting { get; set; }

        [Column("passing")]
        public float? passing { get; set; }

        [Column("dribbling")]
        public float? dribbling { get; set; }

        [Column("defending")]
        public float? defending { get; set; }

        [Column("physic")]
        public float? physic { get; set; }

        /* [Column("st")]
         public string st { get; set; }

         [Column("lw")]
         public float lw { get; set; }

         [Column("cf")]
         public float cf { get; set; }

         [Column("rw")]
         public float rw { get; set; }

         [Column("cam")]
         public string cam { get; set; }

        [Column("lm")]
         public string lm { get; set; }

         [Column("cm")]
         public string cm { get; set; }

         [Column("rm")]
         public string rm { get; set; }

         [Column("cdm")]
         public string cdm { get; set; }

         [Column("lwb")]
         public string lwb { get; set; }

         [Column("lb")]
         public string lb { get; set; }

         [Column("cb")]
         public string cb { get; set; }

         [Column("rb")]
         public string rb { get; set; }

         [Column("rwb")]
         public string rwb { get; set; }

         [Column("gk")]
         public string gk { get; set; }*/

        [Column("player_face_url")]
        public string player_face_url { get; set; }

        [Column("club_logo_url")]
        public string? club_logo_url { get; set; }

        [Column("nation_flag_url")]
        public string nation_flag_url { get; set; }

    }

}
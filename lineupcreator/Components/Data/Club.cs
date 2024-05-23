using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lineupcreator.Components.Data
{
    public class Club
    {
        [Key]
        [Column("club_team_id")]
        public int club_team_id { get; set; }

        [Column("club_name")]
        public string club_name { get; set; }

        [Column("league_name")]
        public string league_name { get; set; }

        [Column("club_logo_url")]
        public string club_logo_url { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lineupcreator.Components.Data
{
    public class Nation
    {
        [Key]
        [Column("nationality_id")]
        public int nationality_id { get; set; }

        [Column("nationality_name")]
        public string nationality_name { get; set; }

        [Column("nation_flag_url")]
        public string nation_flag_url { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}

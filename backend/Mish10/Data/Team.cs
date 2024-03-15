using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mish10.Data
{
    public class Team
    {
        // team table
        [Key]
        public required int TeamID { get; set; }
        public required string TeamName { get; set; }
        public required int CaptainID { get; set; }
    }
}


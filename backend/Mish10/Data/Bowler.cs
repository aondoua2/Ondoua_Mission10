using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mish10.Data
{
    public class Bowler
    {
        // connect to Team table
        [Key]
        public int BowlerId { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public int BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }

        [ForeignKey("TeamID")]
        public int TeamID { get; set; }
        public Team? Team { get; set; }
       
    }

}

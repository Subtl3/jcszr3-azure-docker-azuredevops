using System.ComponentModel.DataAnnotations;

namespace FootballHub.Core.Models
{
    public class Club
    {
        [Key]
        public string Name { get; set; }
        public string League { get; set; }
        public int YearFounded { get; set; }
    }
}

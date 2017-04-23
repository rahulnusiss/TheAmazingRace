using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ACETreasureHunt.Models
{
    public class PitStop
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Event Name")]
        public string PitStopName { get; set; }

        [Required]
        public int PitStopNumber { get; set; }

        [Required]
        [Range(-90.000, 90.0000)]
        public int latitude { get; set; }

        [Required]
        [Range(-180.000, 180.0000)]
        public int longitude { get; set; }
    }
}
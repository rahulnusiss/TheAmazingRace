using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ACETreasureHunt.Models
{
    public class Event
    {
        public Event()
        {
            this.Teams = new HashSet<Team>();
            this.Staffs = new HashSet<Staff>();
            this.PitStops = new HashSet<PitStop>();
        }

        [Key]
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Event Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public string Address { get; set; }

        [Required]
        [Range(-90.000, 90.0000)]
        public double Latitude { get; set; }
        [Required]
        [Range(-180.000, 180.0000)]
        public double Longitude { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<PitStop> PitStops { get; set; }

    }
}
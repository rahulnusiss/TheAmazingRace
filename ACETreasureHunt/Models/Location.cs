using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ACETreasureHunt.Models
{
    public class Location
    {
        public Location()
        {
            //this.Events = new HashSet<Event>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [Range(-90.000,90.0000)]
        public double Latitude { get; set; }
        [Required]
        [Range(-180.000, 180.0000)]
        public double Longitude { get; set; }

       // public virtual ICollection<Event> Events { get; set; }
    }
}
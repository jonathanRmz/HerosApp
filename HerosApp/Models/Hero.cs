using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HerosApp.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public double Rating { get; set; }
        public string UrlPhoto { get; set; }
        public List<Score> RatingsHistorical { get; set; }
    }
}

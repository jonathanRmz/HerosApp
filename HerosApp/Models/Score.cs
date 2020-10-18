using System;
using System.ComponentModel.DataAnnotations;

namespace HerosApp.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int IdHero { get; set; }
        public string UserName { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
    }
}
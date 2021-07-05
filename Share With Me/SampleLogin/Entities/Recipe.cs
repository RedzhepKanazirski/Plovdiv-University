using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareWithMe.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string one { get; set; }
        public string two { get; set; }
        public string three { get; set; }
        public string four { get; set; }
        public string five { get; set; }
        public string six { get; set; }
        public string seven { get; set; }
        public string eight { get; set; }
        public string nine { get; set; }
        public string ten { get; set; }
       
        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
    }
}

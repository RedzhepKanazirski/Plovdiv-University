using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareWithMe.Entities
{
    public class Music
    { 
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
    }
}

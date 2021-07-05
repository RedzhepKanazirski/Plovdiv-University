using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareWithMe.Entities
{
    public class UserToMusic
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MusicId { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }

        [ForeignKey("MusicId")]
        public Music ParentMusic { get; set; }
    }
}

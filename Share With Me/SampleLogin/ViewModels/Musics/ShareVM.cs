using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShareWithMe.Entities;

namespace ShareWithMe.ViewModels.Musics
{
    public class ShareVM
    {
        public int UserId { get; set; }
        public int MusicId { get; set; }
        public Music Music { get; set; }
        public List<User> SharedWithM { get; set; }

        public List<User> Users { get; set; }
    }
}

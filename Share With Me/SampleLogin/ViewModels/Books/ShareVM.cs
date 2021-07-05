using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShareWithMe.Entities;

namespace ShareWithMe.ViewModels.Books
{
    public class ShareVM
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public List<User> SharedWith { get; set; }

        public List<User> Users { get; set; }
    }
}

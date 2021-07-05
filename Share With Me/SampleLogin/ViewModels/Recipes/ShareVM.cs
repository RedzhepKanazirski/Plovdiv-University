using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShareWithMe.Entities;

namespace ShareWithMe.ViewModels.Recipes
{
    public class ShareVM
    {
        public int UserId { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public List<User> SharedWithR { get; set; }

        public List<User> Users { get; set; }
    }
}

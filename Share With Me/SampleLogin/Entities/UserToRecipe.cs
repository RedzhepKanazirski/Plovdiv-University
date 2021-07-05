using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShareWithMe.Entities
{
    public class UserToRecipe
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe ParentRecipe { get; set; }
    }
}

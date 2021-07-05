using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShareWithMe.Entities;

namespace ShareWithMe.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<UserToBook> UserToBooks { get; set; }
        public DbSet<UserToMusic> UserToMusics { get; set; }
        public DbSet<UserToRecipe> UserToRecipes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Recipe> Recipes { get; set; }



        public MyDbContext()
        {
            Users = this.Set<User>();
            Books = this.Set<Book>();
            UserToBooks = this.Set<UserToBook>();
            UserToRecipes = this.Set<UserToRecipe>();
            UserToMusics = this.Set<UserToMusic>();
            Librarians = this.Set<Librarian>();
            Musics = this.Set<Music>();
            Recipes = this.Set<Recipe>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;");
        }
    }
}


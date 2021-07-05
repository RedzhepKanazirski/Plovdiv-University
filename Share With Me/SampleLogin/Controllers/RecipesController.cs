using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ShareWithMe.ActionFilters;
using ShareWithMe.Database;
using ShareWithMe.Entities;
using ShareWithMe.ViewModels.Recipes;

namespace ShareWithMe.Controllers
{
    [AuthenticationFilter]
    public class RecipesController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));

            MyDbContext context = new MyDbContext();
            model.Items = context.Recipes
                                           .Where(d => d.UserId == loggedUserId)
                                           .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Share(int id)
        {
            ShareVM model = new ShareVM();

            MyDbContext context = new MyDbContext();

            model.Recipe = context.Recipes
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            model.SharedWithR = context.UserToRecipes
                                            .Include(utc => utc.ParentUser)
                                            .Include(utc => utc.ParentRecipe)
                                            .Where(i => i.RecipeId == model.Recipe.Id)
                                            .Select(i => i.ParentUser)
                                            .ToList();

            model.Users = context.Users.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ShareVM model)
        {
            MyDbContext context = new MyDbContext();

            UserToRecipe userToRecipe = new UserToRecipe();
            userToRecipe.UserId = model.UserId;
            userToRecipe.RecipeId = model.RecipeId;

            context.UserToRecipes.Add(userToRecipe);
            context.SaveChanges();

            return RedirectToAction("Share", "Recipes", new { id = model.RecipeId });
        }

        public IActionResult RevokeAccess(int UserId, int RecipeId)
        {
            MyDbContext context = new MyDbContext();

            UserToRecipe item = context.UserToRecipes
                                                       .Where(utc => utc.UserId == UserId
                                                        && utc.RecipeId == RecipeId)
                                                       .FirstOrDefault();

            if (item != null)
            {
                context.UserToRecipes.Remove(item);
                context.SaveChanges();
            }
            return RedirectToAction("Share", "Recipes", new { id = RecipeId });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));


            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();

            Recipe item = new Recipe();
            item.UserId = loggedUserId;
            item.one = model.one;
            item.two = model.two;
            item.three = model.three;
            item.four = model.four;
            item.five = model.five;
            item.six = model.six;
            item.seven = model.seven;
            item.eight = model.eight;
            item.nine = model.nine;
            item.ten = model.ten;

            context.Recipes.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Recipes");
        }

        public IActionResult Delete(int id)
        {
            MyDbContext context = new MyDbContext();

            Recipe item = new Recipe();
            item.Id = id;

            //context.Users.Remove(item);
            //or
            //context.Entry(item).State = EntityState.Deleted;
            EntityEntry entry = context.Entry(item);
            entry.State = EntityState.Deleted;

            context.SaveChanges();

            return RedirectToAction("Index", "Recipes");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            MyDbContext context = new MyDbContext();

            Recipe item = context.Recipes
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Recipes");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.UserId = item.UserId;
            model.one = item.one;
            model.two = item.two;
            model.three = item.three;
            model.four = item.four;
            model.five = item.five;
            model.six = item.six;
            model.seven = item.seven;
            model.eight = item.eight;
            model.nine = item.nine;
            model.ten = item.ten;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();

            Recipe item = new Recipe();
            item.Id = model.Id;
            item.UserId = model.UserId;
            item.one = model.one;
            item.two = model.two;
            item.three = model.three;
            item.four = model.four;
            item.five = model.five;
            item.six = model.six;
            item.seven = model.seven;
            item.eight = model.eight;
            item.nine = model.nine;
            item.ten = model.ten;

            context.Recipes.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Recipes");
        }
    }
}


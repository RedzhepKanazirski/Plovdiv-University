using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ShareWithMe.Database;
using ShareWithMe.Entities;
using ShareWithMe.ViewModels.Users;
using ShareWithMe.ActionFilters;

namespace ShareWithMe.Controllers
{
    [AuthenticationFilter]
    public class UsersController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            MyDbContext context = new MyDbContext();
            model.Items = context.Users.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();

            User item = new User();
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.isDeleted = false;

            context.Users.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }

        public IActionResult Delete(int id)
        {
            MyDbContext context = new MyDbContext();

            User item = new User();
            item.Id = id;

            //context.Users.Remove(item);
            //or
            //context.Entry(item).State = EntityState.Deleted;
            EntityEntry entry = context.Entry(item);
            entry.State = EntityState.Deleted;

            context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            MyDbContext context = new MyDbContext();

            User item = context.Users
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Users");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();

            User item = new User();
            item.Id = model.Id;
            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            context.Users.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }
    }
}
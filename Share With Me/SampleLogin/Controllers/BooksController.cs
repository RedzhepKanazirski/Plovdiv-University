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
using ShareWithMe.ViewModels.Books;

namespace ShareWithMe.Controllers
{
    [AuthenticationFilter]
    public class BooksController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));

            MyDbContext context = new MyDbContext();
            model.Items = context.Books
                                           .Where(d => d.UserId == loggedUserId)
                                           .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Share(int id)
        {
            ShareVM model = new ShareVM();

            MyDbContext context = new MyDbContext();

            model.Book = context.Books
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            model.SharedWith = context.UserToBooks
                                            .Include(utc => utc.ParentUser)
                                            .Include(utc => utc.ParentBook)
                                            .Where(i => i.BookId == model.Book.Id)
                                            .Select(i => i.ParentUser)
                                            .ToList();

            model.Users = context.Users.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ShareVM model)
        {
            MyDbContext context = new MyDbContext();

            UserToBook userToBook = new UserToBook();
            userToBook.UserId = model.UserId;
            userToBook.BookId = model.BookId;

            context.UserToBooks.Add(userToBook);
            context.SaveChanges();

            return RedirectToAction("Share", "Books", new { id = model.BookId });
        }

        public IActionResult RevokeAccess(int UserId, int BookId)
        {
            MyDbContext context = new MyDbContext();

            UserToBook item = context.UserToBooks
                                                       .Where(utb => utb.UserId == UserId
                                                        && utb.BookId == BookId)
                                                       .FirstOrDefault();

            if (item != null)
            {
                context.UserToBooks.Remove(item);
                context.SaveChanges();
            }
            return RedirectToAction("Share", "Books", new { id = BookId });
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

            Book item = new Book();
            item.UserId = loggedUserId;
            item.ISBN = model.ISBN;
            item.Genre = model.Genre;
            item.Title = model.Title;
            item.FirstName = model.FirstName;
            item.Year = model.Year;


            context.Books.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        public IActionResult Delete(int id)
        {
            MyDbContext context = new MyDbContext();

            Book item = new Book();
            item.Id = id;

      
            EntityEntry entry = context.Entry(item);
            entry.State = EntityState.Deleted;

            context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            MyDbContext context = new MyDbContext();

            Book item = context.Books
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Books");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.UserId = item.UserId;
            model.ISBN = item.ISBN;
            model.Genre = item.Genre;
            model.Title = item.Title;
            model.FirstName = item.FirstName;
            model.Year = item.Year;


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();

            Book item = new Book();
            item.Id = model.Id;
            item.UserId = model.UserId;
            item.ISBN = model.ISBN;
            item.Genre = model.Genre;
            item.Title = model.Title;
            item.FirstName = model.FirstName;
            item.Year = model.Year;

            context.Books.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }
    }
}


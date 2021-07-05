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
using ShareWithMe.ViewModels.Musics;

namespace ShareWithMe.Controllers
{
    [AuthenticationFilter]
    public class MusicsController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = Convert.ToInt32(this.HttpContext.Session.GetString("LoggedUserId"));

            MyDbContext context = new MyDbContext();
            model.Items = context.Musics
                                           .Where(d => d.UserId == loggedUserId)
                                           .ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Share(int id)
        {
            ShareVM model = new ShareVM();

            MyDbContext context = new MyDbContext();

            model.Music = context.Musics
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            model.SharedWithM = context.UserToMusics
                                            .Include(utc => utc.ParentUser)
                                            .Include(utc => utc.ParentMusic)
                                            .Where(i => i.MusicId == model.Music.Id)
                                            .Select(i => i.ParentUser)
                                            .ToList();

            model.Users = context.Users.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Share(ShareVM model)
        {
            MyDbContext context = new MyDbContext();

            UserToMusic userToMusic = new UserToMusic();
            userToMusic.UserId = model.UserId;
            userToMusic.MusicId = model.MusicId;

            context.UserToMusics.Add(userToMusic);
            context.SaveChanges();

            return RedirectToAction("Share", "Musics", new { id = model.MusicId });
        }

        public IActionResult RevokeAccess(int UserId, int MusicId)
        {
            MyDbContext context = new MyDbContext();

            UserToMusic item = context.UserToMusics
                                                       .Where(utc => utc.UserId == UserId
                                                        && utc.MusicId == MusicId)
                                                       .FirstOrDefault();

            if (item != null)
            {
                context.UserToMusics.Remove(item);
                context.SaveChanges();
            }
            return RedirectToAction("Share", "Musics", new { id = MusicId });
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

            Music item = new Music();
            item.UserId = loggedUserId;
            item.Genre = model.Genre;
            item.Title = model.Title;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Year = model.Year;


            context.Musics.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Musics");
        }

        public IActionResult Delete(int id)
        {
            MyDbContext context = new MyDbContext();

            Music item = new Music();
            item.Id = id;

            //context.Users.Remove(item);
            //or
            //context.Entry(item).State = EntityState.Deleted;
            EntityEntry entry = context.Entry(item);
            entry.State = EntityState.Deleted;

            context.SaveChanges();

            return RedirectToAction("Index", "Musics");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            MyDbContext context = new MyDbContext();

            Music item = context.Musics
                                .Where(u => u.Id == id)
                                .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Musics");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.UserId = item.UserId;
            model.Genre = item.Genre;
            model.Title = item.Title;
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.Year = item.Year;


            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            MyDbContext context = new MyDbContext();

            Music item = new Music();
            item.Id = model.Id;
            item.UserId = model.UserId;
            item.Genre = model.Genre;
            item.Title = model.Title;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;
            item.Year = model.Year;

            context.Musics.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Musics");
        }
    }
}


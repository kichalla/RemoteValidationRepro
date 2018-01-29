using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

// Resource name: WebApplication.Resources.Resource.resources
// TypeFullName: Blah.Controllers.BooksController

namespace Blah.Controllers
{
    public class BooksController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Decline(BookViewModel bookViewModel)
        {
            return Content("Books.Decline");
        }

        // GET: Books/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(new NovelViewModel()
            {
                Id = 1,
                 ISBN = 1111,
                  Protagonist = "asdfsad",
                  Title = "asdfas"
            });
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, [Bind("Id,Title,ISBN")] BookViewModel bookViewModel)
        {
            return Content("Books.Update");
        }

        public IActionResult ValidateTitle(string title, int id)
        {
            return Json(true);
        }
    }
}

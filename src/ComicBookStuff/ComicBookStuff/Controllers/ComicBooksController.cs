using ComicBookStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStuff.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            // object initilizer syntax 
            var comicbook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' " +
                        "life and his one, last, great act of revenge! Even if Spider-Man " +
                        "survives... <strong>will Peter Parker?</strong></p>",

                // new artist array 
                Artists = new Artist[]
                {
                    // artist model instances 
                    new Artist() {Name = "Dan Slott", Role = "Script"},
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters"}
                }
            };

            // return model instance comicbook 
            return View(comicbook);


        }

    }
}
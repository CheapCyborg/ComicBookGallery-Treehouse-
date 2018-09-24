using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		public ActionResult Detail()
		{
			var comicBook = new ComicBook()
			{
				SeriesTitle = "The Amazing Spider - Man",
				IssueNumber = 700,
				DescriptionHtml = "<p>Final Issue! Witness Petey get speedy and just a tad greedy</p>",
				Artists = new Artist[]
				{
					 new Artist(){Name = "Me", Role = "awesome"},
					 new Artist(){Name = "dan", Role = "wdw"},
					 new Artist(){Name = "wrvw", Role = "wf"},
					 new Artist(){Name = "wefwq", Role = "wfwf"},
				}
			};
			return View(comicBook);
		}
	}
}
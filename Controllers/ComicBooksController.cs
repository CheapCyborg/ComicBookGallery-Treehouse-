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
			//Properties start with capital 
			//Supplying data to view
			ViewBag.SeriesTitle = "The Amazing Spider-Man";
			ViewBag.IssueNumber = 700;
			ViewBag.Description = "<p>Final Issue! Witness Petey get speedy and just a tad greedy</p>";
			ViewBag.Artists = new string[]
			{
				"me",
				"awesome"
			};

			return View();
		}
	}
}
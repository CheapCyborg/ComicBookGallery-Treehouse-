using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
	public class ComicBook
	{
		public int Id { get; set; }
		public string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public string DescriptionHtml { get; set; }
		//Added artist model to improve structue as well as removing the presentation of data from the data itself
		public Artist[] Artists { get; set; }
		public bool Favorite { get; set; }

		public string DisplayText
		{
			//Read only meaning value cannot be changed by directly setting property 
			get
			{
				return SeriesTitle + " #" + IssueNumber;
			}
		}

		public string CoverImageFileName
		{
			get
			{
				return SeriesTitle.Replace(" ", "-")
					.ToLower() + "-" + IssueNumber + ".jpg";
			}
		}
	}
}
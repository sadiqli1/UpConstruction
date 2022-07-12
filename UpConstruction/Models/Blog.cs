using System;
using System.Collections.Generic;

namespace UpConstruction.Models
{
	public class Blog
	{
		public int Id { get; set; }
		public string Image { get; set; }
		public string Title { get; set; }
		public string Desc { get; set; }
		public string Author { get; set; }
		public DateTime Date { get; set; }
		public List<Comment> Comments { get; set; }
		public List<Tag> Tags { get; set; }

	}
}

using System.Collections.Generic;
using UpConstruction.Models;

namespace UpConstruction.ViewModels
{
	public class BlogVM
	{
		public Blog Blog { get; set; }
		public List<Tag> Tag { get; set; }
		public List<Blog> Blogs { get; set; }
	}
}

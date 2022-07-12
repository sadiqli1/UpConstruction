using System;

namespace UpConstruction.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string User { get; set; }
		public string Message { get; set; }
		public DateTime ReleaseDate { get; set; }
		public int BlogId { get; set; }
		public Blog Blog { get; set; }
	}
}

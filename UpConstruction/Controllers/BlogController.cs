using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UpConstruction.DAL;
using UpConstruction.Models;
using UpConstruction.ViewModels;

namespace UpConstruction.Controllers
{
	public class BlogController:Controller
	{
		private readonly AppDbContext _context;

		public BlogController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			List<Blog> blogs = _context.Blogs.Include(b => b.Comments).Include(b => b.Tags).ToList();
			return View(blogs);
		}
		public IActionResult Detail(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			Blog blog = _context.Blogs.Include(b => b.Comments).Include(b => b.Tags).FirstOrDefault(b => b.Id == id);
			List<Tag> tags = _context.Tags.ToList();
			List<Blog> blogs = _context.Blogs.OrderBy(b => b.Date).Take(6).ToList();
			BlogVM model = new BlogVM()
			{
				Blog = blog,
				Tag = tags,
				Blogs = blogs
			};
			return View(model);
		}
	}
}

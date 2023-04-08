using System;
using Microsoft.EntityFrameworkCore;

namespace Mission14_rtj_API.Models
{
	//Creating MovieDbContext to be used throughout the application
	public class MovieDbContext : DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
		{
		}

		public DbSet<Movie> Movies { get; set; }
	}
}


using System;
using Microsoft.EntityFrameworkCore;

namespace Mission14_rtj34_API
{
	public class MovieDbContext : DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
		{
		}

	}
}


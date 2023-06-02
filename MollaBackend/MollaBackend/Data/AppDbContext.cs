using Microsoft.EntityFrameworkCore;
using MollaBackend.Models;

namespace MollaBackend.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
		{
		}
		public DbSet<Slider> Sliders { get; set; }
        public DbSet<Featured> Features { get; set; }
        public DbSet<Setting> Settings { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Featured>().HasQueryFilter(m => !m.SoftDelete);
        }
	}
}

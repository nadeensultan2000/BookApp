using BookApp.ViewModel;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Data
{
	public class BookDbContext:IdentityDbContext<ApplicationUser>
	{
        public BookDbContext(DbContextOptions<BookDbContext> options):base(options) { 

        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<IdentityUser>().ToTable("Users", "Identity");
			//modelBuilder.Entity<IdentityRole>().ToTable("Roles", "Identity");
			//modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Identity");
			//modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim", "Identity");
			//modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin", "Identity");
			//modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim", "Identity");
			//modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserToken", "Identity");
			modelBuilder.Entity<Book>().Property(x=>x.Id).HasDefaultValueSql("(newid())");
			modelBuilder.Entity<Category>().Property(x => x.Id).HasDefaultValueSql("(newid())");
			modelBuilder.Entity<SubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
			modelBuilder.Entity<LogCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
			modelBuilder.Entity<LogSubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
			modelBuilder.Entity<LogBook>().Property(x => x.Id).HasDefaultValueSql("(newid())");
		


		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<LogCategory> LogCategories { get; set; }
		public DbSet<LogSubCategory> LogSubCategories { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<LogBook> LogBooks { get; set; }	



	}
}

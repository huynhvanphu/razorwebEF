using System;
using Microsoft.EntityFrameworkCore;

namespace razorwebEF.Model
{
    public class BlogDbConText : DbContext
    {
        public BlogDbConText(DbContextOptions options) : base(options) //Khai bao DI options de dang ky vao trong dich vu DI container
        {

        }

        public DbSet<Article> article { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderData> SliderDatas { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SliderData>().HasData(new SliderData {
                Id = 1, SubTitle = " Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.", Title = " <h1>Send <span>flowers</span> like</h1><h1> you mean it </h1>",ImageUrl="h2-sign-img.png"
            });
        
        }
    }
}

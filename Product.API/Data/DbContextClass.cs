﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Product.API.Models;

namespace Product.API.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Products> Productss { get; set; }
    }
}

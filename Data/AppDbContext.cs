﻿using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }


    }
}

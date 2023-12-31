﻿using Microsoft.EntityFrameworkCore;

namespace ShakenOrStirred.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public List<Drink> Drinks { get; set; }
    }
}

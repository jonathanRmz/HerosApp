﻿using HerosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HerosApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Hero> Heros { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}

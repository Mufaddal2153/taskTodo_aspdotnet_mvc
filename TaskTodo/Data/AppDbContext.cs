﻿using Microsoft.EntityFrameworkCore;
using TaskTodo.Models;

namespace TaskTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskDbModel> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    }
}

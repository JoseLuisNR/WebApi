using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        { }
    }
}

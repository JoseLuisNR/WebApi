using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class StudenDbContext: DbContext
    
    {
        public DbSet<Student>Student { get; set; }
        public StudenDbContext(DbContextOptions<StudenDbContext> options)
            : base(options)
        { }

    }
}

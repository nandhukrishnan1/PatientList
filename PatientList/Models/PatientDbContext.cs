using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientList.Models
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientData>().HasKey(p => p.PatientId);
            //modelBuilder.Entity<StudyData>().HasKey(p => p.StudyID);
        }

        public DbSet<PatientData> PatientDatas { get; set; }
    }
}

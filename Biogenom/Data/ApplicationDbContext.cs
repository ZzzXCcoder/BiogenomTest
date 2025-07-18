using Biogenom.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Biogenom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<AssessmentResult> AssessmentResults { get; set; }
        public DbSet<NutrientScore> NutrientScores { get; set; }
    }
}

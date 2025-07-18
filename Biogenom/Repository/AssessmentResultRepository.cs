using Biogenom.Data;
using Biogenom.Entities;
using Microsoft.EntityFrameworkCore;

namespace Biogenom.Repository
{
    public class AssessmentResultRepository : IAssessmentResultRepository
    {
        private readonly ApplicationDbContext _context;

        public AssessmentResultRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AssessmentResult> GetLatestResultAsync()
        {
            return await _context.AssessmentResults
                .Include(ar => ar.NutrientScores)
                .OrderByDescending(ar => ar.CompletedAt)
                .FirstOrDefaultAsync();
        }
    }
}

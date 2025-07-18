using Biogenom.Dtos;
using Biogenom.Repository;

namespace Biogenom.Service
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IAssessmentResultRepository _repository;

        public AssessmentService(IAssessmentResultRepository repository)
        {
            _repository = repository;
        }

        public async Task<AssesmentResultDto> GetLatestAssessmentResultAsync()
        {
            var result = await _repository.GetLatestResultAsync();
            if (result == null) return null;

            return new AssesmentResultDto
            {
                CompletedAt = result.CompletedAt,
                TotalScore = result.TotalScore,
                Recommendation = result.Recommendation,
                NutrientScores = result.NutrientScores
                    .Select(ns => new NutrientScoreDto
                    {
                        NutrientName = ns.NutrientName,
                        Score = ns.Score
                    }).ToList()
            };
        }
    }
}

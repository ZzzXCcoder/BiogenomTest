using Biogenom.Entities;

namespace Biogenom.Repository
{
    public interface IAssessmentResultRepository
    {
        Task<AssessmentResult> GetLatestResultAsync();
    }
}
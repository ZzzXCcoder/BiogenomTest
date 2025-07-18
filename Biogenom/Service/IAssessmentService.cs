using Biogenom.Dtos;

namespace Biogenom.Service
{
    public interface IAssessmentService
    {
        Task<AssesmentResultDto> GetLatestAssessmentResultAsync();
    }
}
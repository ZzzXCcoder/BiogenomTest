namespace Biogenom.Dtos
{
    public class AssesmentResultDto
    {
        public DateTime CompletedAt { get; set; }
        public int TotalScore { get; set; }
        public string Recommendation { get; set; }
        public List<NutrientScoreDto> NutrientScores { get; set; }
    }
}

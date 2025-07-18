using System.ComponentModel.DataAnnotations;

namespace Biogenom.Entities
{
    public class AssessmentResult
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CompletedAt { get; set; }
        public int TotalScore { get; set; }
        public string Recommendation { get; set; }
        public List<NutrientScore> NutrientScores { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biogenom.Entities
{
    public class NutrientScore
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NutrientName { get; set; }
        public int Score { get; set; }
        [ForeignKey(nameof(AssessmentResult))]
        public int AssessmentResultId { get; set; } 
        public AssessmentResult AssessmentResult { get; set; }
    }
}

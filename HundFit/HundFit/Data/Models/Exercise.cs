using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace HundFit.Data.Models;

public class Exercise
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [MaxLength(2500)]
    public string Description { get; set; }

    public int Series { get; set; }
    public int RepetitionsPerSeries { get; set; }
    public float Load { get; set; }
    
    [SwaggerIgnore]
    public List<TrainingExercises> TrainingExercises { get; set; } = new();
}

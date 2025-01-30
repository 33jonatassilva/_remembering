using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;

namespace HundFit.Data.Models;

public class Training
{
    [Key]
    public Guid Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }

    [Required, MaxLength(2500)]
    public string Description { get; set; }

    [Required]
    public int DurationInMinutes { get; set; }

    public Guid? StudentId { get; set; } 
    
    [SwaggerIgnore]
    public Student Student { get; set; }

    public Guid InstructorId { get; set; }
    
    [SwaggerIgnore]
    public Instructor Instructor { get; set; }
    
    [SwaggerIgnore]
    public List<TrainingExercises> TrainingExercises { get; set; } = new();
}

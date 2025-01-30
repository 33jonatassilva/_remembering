using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace HundFit.Data.Models;

public class PhysicalAssessment
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid StudentId { get; set; }
    
    [SwaggerIgnore]
    public Student Student { get; set; }

    [Required]
    public Guid InstructorId { get; set; }
    
    [SwaggerIgnore]
    public Instructor Instructor { get; set; }

    [Required]
    public DateTime PhysicalAssessmentDate { get; set; }

    [Required]
    public float FatBody { get; set; }

    [Required]
    public float LeanMass { get; set; }

    [Required]
    public float ActualWeight { get; set; }
}
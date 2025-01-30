using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HundFit.Data.Models;

public class TrainingExercises
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TrainingId { get; set; }
    [ForeignKey("TrainingId")]
    public Training Training { get; set; }


    [Required]
    public Guid ExerciseId { get; set; }
    [ForeignKey("ExerciseId")]
    public Exercise Exercise { get; set; }
}
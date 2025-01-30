﻿
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HundFit.Data.Models;

public class Plan
{
    [Key]
    public Guid Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }

    [Required]
    public float Price { get; set; }

    [Required]
    public int DurationInMonths { get; set; }

    [JsonIgnore]
    public List<Student> Students { get; set; } = new();
}
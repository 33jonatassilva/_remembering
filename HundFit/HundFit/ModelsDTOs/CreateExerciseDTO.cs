﻿namespace HundFit.ModelsDTOs;

public class CreateExerciseDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Series { get; set; }
    public int RepetitionsPerSeries { get; set; }
    public float Load { get; set; }
    
}
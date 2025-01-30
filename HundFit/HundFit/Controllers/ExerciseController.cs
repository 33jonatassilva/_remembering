using HundFit.Data.Models;
using HundFit.ModelsDTOs;
using HundFit.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HundFit.Controllers;


[ApiController]
[Route("/hundfit/v1/")]

public class ExerciseController : ControllerBase
{
    
    
    
    private readonly IExerciseRepository _repository;

    public ExerciseController(IExerciseRepository repository)
    {
        _repository = repository;
    }
    


    [HttpPost("/exercises")]
    public async Task<IActionResult> CreateExerciseAsync([FromBody] CreateExerciseDTO createExerciseDto)
    {
        var exercise = new Exercise
        {
            Id = Guid.NewGuid(),
            Name = createExerciseDto.Name,
            Description = createExerciseDto.Description,
            Series = createExerciseDto.Series,
            RepetitionsPerSeries = createExerciseDto.RepetitionsPerSeries,
            Load = createExerciseDto.Load
        };
        
        await _repository.CreateAsync(exercise);
        return Ok(createExerciseDto);
    }


    [HttpGet("/exercises/")]
    public async Task<IActionResult> GetExerciseAsync([FromQuery] Guid? id)
    {
        return id.HasValue ? Ok(await _repository.GetByIdAsync(id.Value)) : Ok(await GetExercisesAsync());
    }
    
    
    [SwaggerIgnore]
    public async Task<IActionResult> GetExercisesAsync()
    {
        var result = await _repository.GetAllAsync();
        return Ok(result);
    }
    
    
    
    [SwaggerIgnore]
    public async Task<IActionResult> GetExercisesByIdAsync(Guid id)
    {
        var exercise = await _repository.GetByIdAsync(id);
        return Ok(exercise);
    }
    


    [HttpPut("/exercises/{id:guid}")]
    public async Task<IActionResult> UpdateExercise(Guid id, [FromBody] UpdateExerciseDTO updateExerciseDto)
    {
        var exerciseToUpdate = await _repository.GetByIdAsync(id);
        
        exerciseToUpdate.Name = updateExerciseDto.Name;
        exerciseToUpdate.Description = updateExerciseDto.Description;
        exerciseToUpdate.Series = updateExerciseDto.Series;
        exerciseToUpdate.Load = updateExerciseDto.Load;
        
        
        await _repository.UpdateAsync(exerciseToUpdate);
        return Ok(exerciseToUpdate);
    }



    [HttpDelete("/exercises/{id:guid}")]
    public async Task<IActionResult> DeleteExerciseByIdAsync(Guid id)
    {
        var exercise = await _repository.GetByIdAsync(id);
        await _repository.DeleteAsync(id);
        return Ok(exercise);
    }
    
    
    
    
    
    
}
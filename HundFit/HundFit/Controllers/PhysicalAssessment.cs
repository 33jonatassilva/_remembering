using HundFit.Data.Models;
using HundFit.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HundFit.Controllers;


[ApiController]
[Route("/physical-assessment")]

public class PhysicalAssessmentController : ControllerBase
{
    
        private readonly IPhysicalAssessmentRepository _repository;

        public PhysicalAssessmentController(IPhysicalAssessmentRepository repository)
        {
            _repository = repository;
        }
    


        [HttpPost("/physical-assessment")]
        public async Task<IActionResult> CreatePhysicalAssessmentAsync([FromBody] PhysicalAssessment physicalAssessment)
        {
            await _repository.CreateAsync(physicalAssessment);
            return Ok(physicalAssessment);
        }



        [HttpGet("/physical-assessment/")]


        public async Task<IActionResult> GetPhysicalAssessmentAsync([FromQuery] Guid? id)
        {
           return id.HasValue ? Ok(await _repository.GetByIdAsync(id.Value)) : Ok(await _repository.GetAllAsync());
        }
        
        
        [SwaggerIgnore]
        public async Task<IActionResult> GetPhysicalAssessments()
        {
            var result = await _repository.GetAllAsync();
            return Ok(result);
        }
    
    
    
        [SwaggerIgnore]
        public async Task<IActionResult> GetPhysicalAssessmentsByIdAsync(Guid id)
        {
            var physicalAssessment = await _repository.GetByIdAsync(id);
            return Ok(physicalAssessment);
        }
    


        [HttpPut("/PhysicalAssessments/{id:guid}")]
        public async Task<IActionResult> UpdatePhysicalAssessment(Guid id, [FromBody] PhysicalAssessment physicalAssessment)
        {
            var physicalAssessmentToUpdate = await _repository.GetByIdAsync(id);

            physicalAssessmentToUpdate.StudentId = physicalAssessment.StudentId;
            physicalAssessmentToUpdate.InstructorId = physicalAssessment.InstructorId;
            physicalAssessmentToUpdate.PhysicalAssessmentDate = physicalAssessment.PhysicalAssessmentDate;
            physicalAssessmentToUpdate.FatBody = physicalAssessment.FatBody;
            physicalAssessmentToUpdate.LeanMass = physicalAssessment.LeanMass;
            physicalAssessmentToUpdate.ActualWeight = physicalAssessment.ActualWeight;

            await _repository.UpdateAsync(physicalAssessmentToUpdate);
            return Ok(physicalAssessmentToUpdate);
        }



        [HttpDelete("/physical-assessment/{id:guid}")]
        public async Task<IActionResult> DeletePhysicalAssessmentByIdAsync(Guid id)
        {
            var physicalAssessment = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(id);
            return Ok(physicalAssessment);
        }
}
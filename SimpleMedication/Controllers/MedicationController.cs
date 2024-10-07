using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleMedication.Application.Features.Medications.Commands.CreateMedication;
using SimpleMedication.Application.Features.Medications.Commands.DeleteMedication;
using SimpleMedication.Application.Features.Medications.Models;
using SimpleMedication.Application.Features.Medications.Queries.GetAllMedications;

namespace SimpleMedication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MedicationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _mediator.Send(new GetMedicationsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateMedicationCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _mediator.Send(new DeleteMedicationCommand { Id = id });
            return NoContent();
        }
    }
}

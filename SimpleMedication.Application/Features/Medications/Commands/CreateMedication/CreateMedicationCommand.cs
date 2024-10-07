using MediatR;
using SimpleMedication.Application.Features.Medications.Models;

namespace SimpleMedication.Application.Features.Medications.Commands.CreateMedication
{
    public class CreateMedicationCommand : IRequest<MedicationDTO>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}

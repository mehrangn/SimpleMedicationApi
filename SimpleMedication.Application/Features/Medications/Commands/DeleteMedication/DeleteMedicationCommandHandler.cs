using MediatR;
using SimpleMedication.Application.Contracts.Persistance;
using SimpleMedication.Application.Features.Medications.Models;
using SimpleMedication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Application.Features.Medications.Commands.DeleteMedication
{
    public class DeleteMedicationCommandHandler : IRequestHandler<DeleteMedicationCommand>
    {
        private readonly IMedicationRepo _medicationRepo;

        public DeleteMedicationCommandHandler(IMedicationRepo medicationRepo)
        {
            _medicationRepo = medicationRepo;
        }

        public async Task Handle(DeleteMedicationCommand request, CancellationToken cancellationToken)
        {
            Medication medication = await _medicationRepo.GetByIdAsync(request.Id);
            if (medication == null)
            {
                throw new KeyNotFoundException("Medication not found");
            }
            _medicationRepo.DeleteAsync(medication);
        }
    }
}
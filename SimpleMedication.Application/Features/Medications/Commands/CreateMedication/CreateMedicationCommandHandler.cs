using AutoMapper;
using MediatR;
using SimpleMedication.Application.Contracts.Persistance;
using SimpleMedication.Application.Features.Medications.Models;
using SimpleMedication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Application.Features.Medications.Commands.CreateMedication
{
    public class CreateMedicationCommandHandler : IRequestHandler<CreateMedicationCommand, MedicationDTO>
    {
        private readonly IMedicationRepo _medicationRepo;
        private readonly IMapper _mapper;

        public CreateMedicationCommandHandler(IMedicationRepo medicationRepo, IMapper mapper)
        {
            _medicationRepo = medicationRepo;
            _mapper = mapper;
        }

        public async Task<MedicationDTO> Handle(CreateMedicationCommand request, CancellationToken cancellationToken)
        {
            Medication medication = _mapper.Map<Medication>(request);

            return _mapper.Map<MedicationDTO>(await _medicationRepo.AddAsync(medication));
        }
    }
}

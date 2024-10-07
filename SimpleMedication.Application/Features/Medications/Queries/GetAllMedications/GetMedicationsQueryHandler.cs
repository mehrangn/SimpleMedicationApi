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

namespace SimpleMedication.Application.Features.Medications.Queries.GetAllMedications
{
    public class GetMedicationsQueryHandler : IRequestHandler<GetMedicationsQuery, ICollection<MedicationDTO>>
    {
        private readonly IMedicationRepo _medicationRepo;
        private readonly IMapper _mapper;
        public GetMedicationsQueryHandler(IMedicationRepo medicationRepo, IMapper mapper)
        {
            _medicationRepo = medicationRepo;
            _mapper = mapper;
        }

        public async Task<ICollection<MedicationDTO>> Handle(GetMedicationsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<ICollection<MedicationDTO>>(await _medicationRepo.GetAllAsync());
        }
    }
}

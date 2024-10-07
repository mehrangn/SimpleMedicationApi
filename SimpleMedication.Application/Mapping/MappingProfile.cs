using AutoMapper;
using SimpleMedication.Application.Features.Medications.Models;
using SimpleMedication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Medication , MedicationDTO>().ReverseMap();
        }
    }
}

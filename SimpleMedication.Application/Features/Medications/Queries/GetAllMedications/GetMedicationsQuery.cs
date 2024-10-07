using MediatR;
using SimpleMedication.Application.Features.Medications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Application.Features.Medications.Queries.GetAllMedications
{
    public class GetMedicationsQuery : IRequest<ICollection<MedicationDTO>>
    {
    }
}

using SimpleMedication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Application.Contracts.Persistance
{
    public interface IMedicationRepo : IGenericRepo<Medication>
    {

    }
}

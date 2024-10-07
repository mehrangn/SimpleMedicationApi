using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Application.Features.Medications.Models
{
    public class MedicationDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime CreationDate { get; set; }

        public MedicationDTO()
        {
            CreationDate = DateTime.Now;
            Id = Guid.NewGuid();
        }
    }
}

using SimpleMedication.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMedication.Domain.Entities
{
    public class Medication : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
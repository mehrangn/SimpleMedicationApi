using SimpleMedication.Application.Contracts.Persistance;
using SimpleMedication.Domain.Entities;
using SimpleMedication.Infrastructure.Persistance;

namespace SimpleMedication.Infrastructure.Repositories
{
    public class MedicationRepo : BaseRepo<Medication>, IMedicationRepo
    {
        public MedicationRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}   

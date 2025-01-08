using Hospital.Core.Entities;
using Hospital.Data.Contexts;
using Hospital.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Repositories.Implementation
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalApiDbContext hospitalApiDbContext) : base(hospitalApiDbContext)
        {
        }
    }
}

using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Services.Abstraction
{
    public interface IPatienceService
    {
        Task<Patient> CreateAsync(CreatePatientDto createPatientDto);
        Task<List<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync(int id);
        Task<bool> Update(int id,UpdatePatientDto updatePatientDto);
       
        Task<bool> HardDeleteAsync(int id);
        
    }
}

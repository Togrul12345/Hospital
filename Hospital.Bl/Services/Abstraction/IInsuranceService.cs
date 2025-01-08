using Hospital.Bl.Dtos.InsuranceDtos;
using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Services.Abstraction
{
    public interface IInsuranceService
    {
        Task<Insurance> CreateAsync(CreateInsuranceDto createInsuranceDto);
        Task<List<Insurance>> GetAllAsync();
        Task<Insurance> GetByIdAsync(int id);
        Task<bool> Update(int id, UpdateInsuranceDto updateInsuranceDto);

        Task<bool> HardDeleteAsync(int id);
    }
}

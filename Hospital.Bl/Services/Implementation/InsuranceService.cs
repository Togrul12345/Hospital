using AutoMapper;
using Hospital.Bl.Dtos.InsuranceDtos;
using Hospital.Bl.Dtos.InsuranceDtos;
using Hospital.Bl.Services.Abstraction;
using Hospital.Core.Entities;
using Hospital.Data.Repositories.Abstraction;
using Hospital.Data.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Services.Implementation
{
    public class InsuranceService : IInsuranceService
    {
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly IMapper _mapper;

        public InsuranceService(IInsuranceRepository insuranceRepository, IMapper mapper)
        {
            _insuranceRepository = insuranceRepository;
            _mapper = mapper;
        }

        public async Task<Insurance> CreateAsync(CreateInsuranceDto createInsuranceDto)
        {
            try
            {
                Insurance Insurance = _mapper.Map<Insurance>(createInsuranceDto);
                await _insuranceRepository.CreateAsync(Insurance);
                await _insuranceRepository.SaveChangesAsync();
                return Insurance;
            }
            catch (Exception)
            {

                throw new Exception("Couldnt map");
            }
        }

        public async Task<List<Insurance>> GetAllAsync()
        {
            return await _insuranceRepository.GetAllAsync();
        }

        public async Task<Insurance> GetByIdAsync(int id)
        {
            return await _insuranceRepository.GetByIdAsync(id);
        }

        public async Task<bool> HardDeleteAsync(int id)
        {
            await _insuranceRepository.HardDeleteAsync(id);
            await _insuranceRepository.SaveChangesAsync();
            return true;
        }



        public async Task<bool> Update(int id, UpdateInsuranceDto updateInsuranceDto)
        {
            try
            {
                Insurance Insurance = _mapper.Map<Insurance>(updateInsuranceDto);
                Insurance.Id = id;
                _insuranceRepository.Update(Insurance);
                await _insuranceRepository.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                throw new Exception("Couldnt map");
            }

        }
    }
}

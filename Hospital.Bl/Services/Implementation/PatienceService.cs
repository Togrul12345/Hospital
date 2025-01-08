using AutoMapper;
using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Bl.Services.Abstraction;
using Hospital.Core.Entities;
using Hospital.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Services.Implementation
{
    public class PatienceService : IPatienceService
    {
        private readonly IMapper _mapper;
        private readonly IPatientRepository _patientRepository;

        public PatienceService(IMapper mapper, IPatientRepository patientRepository)
        {
            _mapper = mapper;
            _patientRepository = patientRepository;
        }

        public async Task<Patient> CreateAsync(CreatePatientDto createPatientDto)
        {
            try
            {
                Patient patient = _mapper.Map<Patient>(createPatientDto);
                await _patientRepository.CreateAsync(patient);
                await _patientRepository.SaveChangesAsync();
                return patient;
            }
            catch (Exception)
            {

                throw new Exception("Couldnt map");
            }



        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await _patientRepository.GetAllAsync();
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await _patientRepository.GetByIdAsync(id);
        }

        public async Task<bool> HardDeleteAsync(int id)
        {
            await _patientRepository.HardDeleteAsync(id);
            await _patientRepository.SaveChangesAsync();
            return true;
        }



        public async Task<bool> Update(int id, UpdatePatientDto updatePatientDto)
        {
            try
            {
                Patient patient = _mapper.Map<Patient>(updatePatientDto);
                patient.Id = id;
                _patientRepository.Update(patient);
                await _patientRepository.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                throw new Exception("Couldnt map");
            }

        }
    }
}

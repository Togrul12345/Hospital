using Hospital.Core.Entities;
using Hospital.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Dtos.PatientDtos
{
    public class CreatePatientDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public string BloodGroup { get; set; }
        public string? PhoneNumber { get; set; }
        public string? SeriaNumber { get; set; }
        public string? RegistrationAddress { get; set; }
        public string? CurrentAddress { get; set; }
        public int InsuranceId { get; set; }
  
        public string? Email { get; set; }
    }
}

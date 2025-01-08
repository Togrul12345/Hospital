using AutoMapper;
using Hospital.Bl.Dtos.InsuranceDtos;
using Hospital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Profiles.InsuranceProfiles
{
    public class InsuranceProfile:Profile
    {
        public InsuranceProfile()
        {
            CreateMap<CreateInsuranceDto, Insurance>();
            CreateMap<UpdateInsuranceDto, Insurance>();
        }
    }
}

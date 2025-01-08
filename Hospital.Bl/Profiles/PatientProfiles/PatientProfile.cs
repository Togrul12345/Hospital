using AutoMapper;
using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Core.Entities;
using Hospital.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Profiles.PatientProfiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
           
            
            
                CreateMap<CreatePatientDto, Patient>()
               .ForMember(a => a.Gender, b => b.MapFrom(src => Enum.Parse<Gender>(src.Gender))).ForMember(a => a.BloodGroup, b => b.MapFrom(a => Enum.Parse<BloodGroup>(a.BloodGroup)));
          
           
            
          
                CreateMap<UpdatePatientDto, Patient>()
               .ForMember(a => a.Gender, b => b.MapFrom(src => Enum.Parse<Gender>(src.Gender))).ForMember(a => a.BloodGroup, b => b.MapFrom(a => Enum.Parse<BloodGroup>(a.BloodGroup)));
          
          
           

        }
    }
}


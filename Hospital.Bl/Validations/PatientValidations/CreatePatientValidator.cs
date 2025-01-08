using FluentValidation;
using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Bl.ExtensionMethods;
using Hospital.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Validations.PatientValidations
{
    public class CreatePatientValidator:AbstractValidator<CreatePatientDto>
    {
        public CreatePatientValidator()
        {
            RuleFor(a => a.Email).Must(b => b.IsValidEmail()).WithMessage("This is not valid email");
            RuleFor(a => a.CurrentAddress).MaximumLength(100).WithMessage("This is must be max 100 character");
            RuleFor(a => a.PhoneNumber).Must(b => b.IsValidPhoneNumber()).WithMessage("This is not phone number");
            RuleFor(a => a.Surname).MaximumLength(40).WithMessage("Max length must be 40");
            RuleFor(a => a.InsuranceId).NotNull().WithMessage("Cannot be null").NotEmpty().WithMessage("Cannot be empty");
            RuleFor(a => a.DOB).NotEmpty().WithMessage("Cannot be empty").NotNull().WithMessage("Cannot be null");
            RuleFor(a=>a.Name).MaximumLength(40).WithMessage("Max length must be 40");
            RuleFor(a => a.BloodGroup).NotNull().WithMessage("Cannot be null").NotEmpty().WithMessage("Cannot be empty");
            RuleFor(a => a.RegistrationAddress).NotNull().WithMessage("Cannot be null").NotEmpty().WithMessage("Cannot be empty");
            RuleFor(a => a.Gender).NotEmpty().WithMessage("Cannot be empty").NotNull().WithMessage("Cannot be null");
        }
    }
}

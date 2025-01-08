using FluentValidation;
using Hospital.Bl.Dtos.InsuranceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Validations.InsuranceValidations
{
    public class CreateInsuranceValidator:AbstractValidator<CreateInsuranceDto>
    {
        public CreateInsuranceValidator()
        {
            RuleFor(a => a.PersonInsurance).NotNull().WithMessage("Cannot be null").NotEmpty().WithMessage("cannot be empty");
            RuleFor(a=>a.Discount).NotNull().WithMessage("Cannot be null").NotEmpty().WithMessage("cannot be empty");
        }
    }
}

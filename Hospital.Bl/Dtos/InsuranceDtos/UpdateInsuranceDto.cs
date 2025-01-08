using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Dtos.InsuranceDtos
{
    public class UpdateInsuranceDto
    {
        public string? PersonInsurance { get; set; }
        public float Discount { get; set; }
    }
}

using Hospital.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
           builder.HasOne(a=>a.Insurance).WithMany(a=>a.Patients).HasForeignKey(a=>a.InsuranceId);
            builder.HasKey(a => a.Id);
           
        }
    }
}

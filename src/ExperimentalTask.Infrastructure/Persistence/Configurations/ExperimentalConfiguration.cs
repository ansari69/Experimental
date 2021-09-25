using ExperimentalTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalTask.Infrastructure.Persistence.Configurations
{
    public class ExperimentalConfiguration : IEntityTypeConfiguration<Experimental>
    {
        public void Configure(EntityTypeBuilder<Experimental> builder)
        {

            builder.HasKey(e => e.ExperimentalId);

            //  throw new NotImplementedException();
        }
    }
}

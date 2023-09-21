using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
            (
               new Company
               {
                   Id = new Guid ("c9d4c053-49b6-410c-bc78-2d54a9991855"),
                   Name = "MAPRE",
                   Address = "cra 100 sur 28",
                   Country = "USA"
               },

               new Company
               {
                   Id = new Guid("c1d2c053-49b6-410c-bc78-2d54a9991833"),
                   Name = "S.A SOLUTION",
                   Address = "cll 85 B 48 A",
                   Country = "USA"
               }

            );
        }
    }
}

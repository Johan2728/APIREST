using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
               new Employee
               {
                   Id = new Guid("c9d4c013-49b6-410c-bc78-2d54a9991877"),
                   Name = "Andres Gutierrez",
                   Age = 30,
                   Position = "Desarrollador",
                   CompanyId = new Guid("c9d4c053-14b6-410c-bc78-2d54a9991866")
               },

               new Employee
               {
                   Id = new Guid("c9d4c053-49b1-510c-bc78-2d54a9991888"),
                   Name = "Sebastian Murcia",
                   Age = 20,
                   Position = "Desarrollador",
                   CompanyId = new Guid("c9d4c053-49b6-416c-bc78-2d54a9991899")
               }

            );
        }
    }
}

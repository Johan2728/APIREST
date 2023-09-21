using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = " El nombre de la compañia es requerido")]
        [MaxLength(30, ErrorMessage = "Maximo de caracteres es de 30")]
        public string? Name { get; set; }

        [Required(ErrorMessage = " La edad del empleado es requerido")]
        public int Age { get; set; }

        [Required(ErrorMessage = " La posicion del empleado es requerido")]
        [MaxLength(20, ErrorMessage = "Maximo de caracteres es de 20")]
        public string? Position { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}

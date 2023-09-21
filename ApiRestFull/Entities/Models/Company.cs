using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = " El nombre de la compañia es requerido")]
        [MaxLength(60, ErrorMessage = "Maximo de caracteres es de 60")]

        public string? Name { get; set; }

        [Required(ErrorMessage = " La direccion de la compañia es requerido")]
        [MaxLength(60, ErrorMessage = "Maximo de caracteres es de 60")]

        public string? Address { get; set; }
        public string? Country { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}

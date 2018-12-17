using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMaintenance.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [MaxLength(50)]
        public string DepartmentName { get; set; }

        //public virtual ICollection<Employee> Employees { get; set; }
    }
}
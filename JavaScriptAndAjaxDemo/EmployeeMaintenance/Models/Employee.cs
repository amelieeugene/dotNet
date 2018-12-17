using EmployeeMaintenance.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeMaintenance.Models
{
    public class Employee
    {
        //Table properties
        [Key]
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        [NotMapped]
        public Departments DepartmentEnum { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string Address1 { get; set; }

        [MaxLength(50)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime? DOB { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        public bool IsPermanent { get; set; }

        public decimal Salary { get; set; }

        public virtual Department Department { get; set; }
    }
}
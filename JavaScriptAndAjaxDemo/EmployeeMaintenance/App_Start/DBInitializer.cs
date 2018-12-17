using EmployeeMaintenance.Models;
using EmployeeMaintenance.Models.DL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeMaintenance.App_Start
{
    public class DBInitializer
    {
        public static void CreateAndInitializeDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DBModel>());
            DBModel db = new DBModel();
            if (db.Departments.Count() <= 0)
            {
                Department department = new Department();
                department.DepartmentName = "IT";
                db.Departments.Add(department);
                department = new Department();
                department.DepartmentName = "CSE";
                db.Departments.Add(department);
            }
            if (db.Employees.Count() <= 0)
            {
                Employee emp = new Employee();
                emp.FirstName = "Tom";
                emp.LastName = "Hanks";
                emp.Address1 = "1St Street";
                emp.Address2 = "Columbia Ave";
                emp.City = "Los Angeles";
                emp.State = "CA";
                emp.Country = "US";
                emp.PostalCode = "123456";
                emp.DepartmentId = 1;
                db.Employees.Add(emp);

                emp = new Employee();
                emp.FirstName = "Bruce";
                emp.LastName = "Willis";
                emp.Address1 = "2nd Street";
                emp.Address2 = "Farmers Ave";
                emp.City = "Seattle";
                emp.State = "WA";
                emp.Country = "US";
                emp.PostalCode = "756446";
                emp.DepartmentId = 2;
                db.Employees.Add(emp);

                emp = new Employee();
                emp.FirstName = "Johnny";
                emp.LastName = "Depp";
                emp.Address1 = "5Th Street";
                emp.Address2 = "Shuttle Ave";
                emp.City = "San Antonio";
                emp.State = "TX";
                emp.Country = "US";
                emp.PostalCode = "123456";
                emp.DepartmentId = 2;
                db.Employees.Add(emp);

                emp = new Employee();
                emp.FirstName = "Christian";
                emp.LastName = "Bale";
                emp.Address1 = "8th Street";
                emp.Address2 = "SpaceX Ave";
                emp.City = "Chicago";
                emp.State = "IL";
                emp.Country = "US";
                emp.PostalCode = "123456";
                emp.DepartmentId = 1;
                db.Employees.Add(emp);

                emp = new Employee();
                emp.FirstName = "Heath";
                emp.LastName = "Ledger";
                emp.Address1 = "7th Street";
                emp.Address2 = "Discovery Ave";
                emp.City = "Los Angeles";
                emp.State = "CA";
                emp.Country = "US";
                emp.PostalCode = "123456";
                emp.DepartmentId = 1;
                db.Employees.Add(emp);
            }
            db.SaveChanges();
        }
    }
}
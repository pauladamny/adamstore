using AdamStore.Business.Interface;
using AdamStore.Domain;
using AdamStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamStore.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        public List<EmployeeDomainModel> GetAllEmployees()
        {

            mvcTutorialEntities db = new mvcTutorialEntities();

            List<EmployeeDomainModel> emplist = db.Employees.Select(x => new EmployeeDomainModel
            {
                EmployeeId = x.EmployeeId,
                Name = x.Name,
                Address=x.Address,
                IsDeleted=x.IsDeleted,
                DepartmentId=x.Department.DepartmentId,
                DepartmentName=x.Department.DepartmentName
            }).ToList();

           // List<EmployeeDomainModel> emplist = new List<EmployeeDomainModel>();
            
            //emplist.Add(new EmployeeDomainModel { EmployeeId = 1, Name = "Paul" });
            //emplist.Add(new EmployeeDomainModel { EmployeeId = 2, Name = "Eleni" });
            //emplist.Add(new EmployeeDomainModel { EmployeeId = 3, Name = "Harry" });
            return emplist;
        }

        public string GetEmployeeName(int EmployeeId)
        {
            ///testing
            return EmployeeId.ToString();
        }

    }
}

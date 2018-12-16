using AdamStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdamStore.Business.Interface
{
   public interface IEmployeeBusiness
    {
        string GetEmployeeName(int EmployeeId);
        List<EmployeeDomainModel> GetAllEmployees();
    }
}

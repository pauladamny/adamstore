using AdamStore.Business;
using AdamStore.Business.Interface;
using AdamStore.Domain;
using AdamStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdamStore.Controllers
{
    public class RepositoryController : Controller
    {
        // GET: Repository
        public ActionResult Index()
        {

            IEmployeeBusiness EmpBusiness = new EmployeeBusiness();

            List<EmployeeDomainModel> ListDM = EmpBusiness.GetAllEmployees();
            List<EmployeeViewModel> ListVM = new List<EmployeeViewModel>();


            AutoMapper.Mapper.Map(ListDM, ListVM);

            ViewBag.EmpName = EmpBusiness.GetEmployeeName(2);

            ViewBag.AllEmps = ListVM;// EmpBusiness.GetAllEmployees();


            return View();
        }
    }
}
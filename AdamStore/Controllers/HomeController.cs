using AdamStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdamStore.Controllers
{
    public class HomeController : Controller
    {
       



        [HttpPost]
        public ActionResult Index(EmployeeViewModel model)
        {
          

                var db = new AdamStoreEntities();
                var list = db.Departments.ToList();
                ViewBag.DepartmentList = new SelectList(list, "DepartmentID", "DepartmentName");

                var employee = new Employee();
                employee.Name = model.Name;
                employee.Address = model.Address;
                employee.DepartmentId = model.DepartmentId;
            //  employee.Department.DepartmentName = model.DepartmentName;

            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            return View();

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CountryStateView()
        {

            ViewBag.CountryList = new SelectList(GetCountries(), "CountryId", "CountryName");

            //var db = new AdamStoreEntities();
            //var employee = db.Employees.SingleOrDefault(x => x.EmployeeId == 1);

            //var employeeVM = new EmployeeViewModel();
            //employeeVM.Name = employee.Name;
            //employeeVM.Address = employee.Address;
            //employeeVM.EmployeeId = employee.EmployeeId;
            //employeeVM.DepartmentId = employee.Department.DepartmentId;

            //return View(employeeVM);




            //var db = new AdamStoreEntities();
            //var list = db.Departments.ToList();
            //ViewBag.DepartmentList = new SelectList(list, "DepartmentID", "DepartmentName");
            return View();

        }



        public List<Country> GetCountries()
        {
            var db = new AdamStoreEntities();
            var CountryList = db.Countries.ToList();

            return CountryList;
        }

        public ActionResult GetStates(int CountryId)
        {
            var db = new AdamStoreEntities();
            var StateList = db.States.Where(s => s.CountryId == CountryId).ToList();

            ViewBag.StateList = new SelectList(StateList, "StateId", "StateName");

            return PartialView("PartialViewStates"); //StateList;
        }


    }
}
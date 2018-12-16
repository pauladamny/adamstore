using AdamStore.Domain;
using AdamStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamStore.Infrastracture
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {       
        public AutomapperWebProfile()
        {
            CreateMap<EmployeeViewModel,EmployeeDomainModel>();
            CreateMap<EmployeeDomainModel,EmployeeViewModel>();
        }


        public static void Run()
        {
            AutoMapper.Mapper.Initialize(am => { am.AddProfile<AutomapperWebProfile>(); });
        }       


    }
}
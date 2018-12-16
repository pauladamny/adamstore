using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdamStore.Models
{
    public class EmployeeViewModel
    {

        public int EmployeeId { get; set; }


        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }



      
        public Nullable<int> DepartmentId { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    
        public string DepartmentName { get; set; }
    }
}
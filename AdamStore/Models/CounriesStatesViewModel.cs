using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamStore.Models
{
    public class CounriesStatesViewModel
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
     

        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
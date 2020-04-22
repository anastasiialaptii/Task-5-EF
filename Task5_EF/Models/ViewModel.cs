using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task5_EF.Models
{
    public class ViewModel
    {
        public IEnumerable<SelectListItem> Flowers { get; set; }
        public IEnumerable<string> SelectedFlowers{ get; set; }
    }
}
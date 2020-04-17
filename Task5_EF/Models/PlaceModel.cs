using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Task5_EF.Models
{
    public class PlaceModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }
    }
}
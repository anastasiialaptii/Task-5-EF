﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Task5_EF.Models
{
    public class PlaceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
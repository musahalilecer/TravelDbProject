﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelDbProject.Models.Classes
{
    public class AboutUs
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
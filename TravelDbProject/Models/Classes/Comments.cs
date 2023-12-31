﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelDbProject.Models.Classes
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
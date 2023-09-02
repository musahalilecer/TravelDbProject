using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TravelDbProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string BlogTittle { get; set; }
        public string BlogDescription { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogDate { get; set; }
        public ICollection<Comments> Commentss { get; set; }
    }
}
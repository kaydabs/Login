using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace appp.Models
{
    public class link
    {
        [Key]
        public int key { get; set; }
        public string webLink { get; set; }
        public string linkRole { get; set; }
    }
}
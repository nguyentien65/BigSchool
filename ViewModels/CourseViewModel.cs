using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public String Place { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime() => DateTime.Parse(string.Format("{0} {1}", Date, Time));
    }
}
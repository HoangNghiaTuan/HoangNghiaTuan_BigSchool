using HoangNghiaTuan_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HoangNghiaTuan_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [FutureDate]
        [Required]
        public string Date { get; set; }
        [ValidTime]
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        [Required]
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}
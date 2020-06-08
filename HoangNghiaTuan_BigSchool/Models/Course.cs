using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HoangNghiaTuan_BigSchool.Models
{
    public class Course
    {
        public int id { get; set; }
        public ApplicationUser Leecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}
using Lab4_5_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_5_6.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}
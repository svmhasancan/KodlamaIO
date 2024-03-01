using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Descripton { get; set; }
        public int Price { get; set; }
        public string InstructorName { get; set; }
        public string ImageUrl { get; set; }

    }
}

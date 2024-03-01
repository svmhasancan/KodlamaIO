using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concreate
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>()
            {

                new Course(){CourseId = 1,CourseName = "Javascript",Descripton = "2024 Javascript Kursu",InstructorName="Engin Demiroğ",Price=20,ImageUrl="https://www.images.com/image1"},
                new Course(){CourseId = 2,CourseName = "C++",Descripton = "2021 C++ Kursu",InstructorName="Engin Demiroğ",Price=50,ImageUrl="https://www.images.com/image2"},
                new Course(){CourseId = 3,CourseName = "Html-Css-Javascript",Descripton = "Web Geliştirme Eğitimi",InstructorName="Halit Enes Kalaycı",Price=500,ImageUrl="https://www.images.com/image3"}

            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Delete(Course course)
        {
            _courses.RemoveAll(
                deleteCourse =>
                    deleteCourse.CourseId == course.CourseId
                    &&
                    deleteCourse.CourseName.ToUpper() == course.CourseName.ToUpper()
            );
        }


        public void Update(Course course)
        {
            foreach (Course updatedCourse in _courses)
            {
                if (course.CourseId == updatedCourse.CourseId)
                {
                    updatedCourse.CourseName = course.CourseName;
                    updatedCourse.Descripton = course.Descripton;
                    updatedCourse.Price = course.Price;
                    updatedCourse.ImageUrl = course.ImageUrl;
                    updatedCourse.InstructorName = course.InstructorName;
                }
            }
        }
    }
}

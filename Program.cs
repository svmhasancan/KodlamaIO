using KodlamaIO.Business.Concreate;
using KodlamaIO.DataAccess.Concreate;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace KodlamaIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            //                              Tested Course Manager

            //Tested GetAll() method for Course
            //CourseManager courseManager = new CourseManager(new CourseDal());
            //ListOfCourse(courseManager);

            // Tested Add Course
            //CourseManager courseManager = new CourseManager(new CourseDal());
            //courseManager.Add(new Course() { CourseId = 5, CourseName = "İngilizce Kursu", Price = 0, Descripton = "A1-A2-A3 seviye ingilizce kursu...", InstructorName = "Hasan Can Sevim", ImageUrl = "https://www.images.com/image5" });
            //ListOfCourse(courseManager);

            // Tested A Delete Course
            //CourseManager courseManager = new CourseManager(new CourseDal());
            //courseManager.Delete(new Course() { CourseId = 3, CourseName = "Html-Css-Javascript", Descripton = "Web Geliştirme Eğitimi", InstructorName = "Engin Demiroğ", Price = 500, ImageUrl = "https://www.images.com/image3" });
            //ListOfCourse(courseManager);

            // Tested A Update Course
            //CourseManager courseManager = new CourseManager(new CourseDal());
            //courseManager.Update(new Course() { CourseId = 3, CourseName = "Dart", Descripton = "Dart Eğitimi", InstructorName="Mustafa Murat Coşkun", Price = 36, ImageUrl = "https://www.images.com/image3133124" });
            //ListOfCourse(courseManager);


            //                                 Tested Category Manager

            // Tested GetAll() method
            //CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //ListOfCategories(categoryManager);

            // Tested Add Category
            //CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //categoryManager.Add(new Category() { CategoryId = 14, CategoryName = "Siber Güvenlik" });
            //ListOfCategories(categoryManager);

            // Tested Update Category
            //CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //categoryManager.Update(new Category() { CategoryId=11,CategoryName="Oyun Programlama"});
            //ListOfCategories(categoryManager);

            // Tested Delete Course
            //CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //categoryManager.Delete(new Category() { CategoryId = 11 , CategoryName="Programlama"});
            //ListOfCategories(categoryManager);



            //                              Tested Instructor Manager
            // Tested GetAll() method
            //InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            //ListOfInstructors(instructorManager);

            // Tested Add Instructor
            //InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            //instructorManager.Add(new Instructor() { InstructorId=114 , FirstName = "Hasan Can" , LastName = "Sevim"});
            //ListOfInstructors(instructorManager);

            // Tested Delete Instructor
            //InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            //instructorManager.Delete(new Instructor() { InstructorId = 111});
            //ListOfInstructors(instructorManager);

            // Tested Update Instructor
            //InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            //instructorManager.Update(new Instructor() { InstructorId = 111 , FirstName = "Mert" , LastName = "Karaca"});
            //ListOfInstructors(instructorManager);

            Console.ReadLine();
        }

        static public void CourseForEach(List<Course> courseList)
        {
            foreach(Course course in courseList)
            {
                Console.WriteLine(
                    "Id: " + course.CourseId + " " +
                    "Course Name: " + course.CourseName + " " +
                    "Price: " + course.Price + " " +
                    "Course Description : " + course.Descripton + " " +
                    "Percentage: " + course.InstructorName + " " +
                    "Image: " + course.ImageUrl
                );
                Console.WriteLine(" ");
            }
        }

        static public void ListOfCourse(CourseManager courseManager)
        {
            CourseForEach(courseManager.GetAll());
        }

        static public void CategoryForEach(List<Category> categoryList)
        {
            foreach (Category category in categoryList)
            {
                Console.WriteLine(
                    "Category Id : " + category.CategoryId + " " +
                    "Category Name : " + category.CategoryName
                );
                Console.WriteLine(" ");
            }
        }

        static public void ListOfCategories(CategoryManager categoryManager)
        {
            CategoryForEach(categoryManager.GetAll());
        }

        static public void InstructorForEach(List<Instructor> instructorList)
        {
            foreach(Instructor instructor in instructorList)
            {
                Console.WriteLine(
                    "Instructor Id : " + instructor.InstructorId + " " +
                    "Instructor Name : " + instructor.FirstName + " " + instructor.LastName
                );
                Console.WriteLine(" ");
            }
        }

        static public void ListOfInstructors(InstructorManager instructorManager)
        {
            InstructorForEach(instructorManager.GetAll());
        }
    }
}

using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concreate
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    InstructorId = 111,
                    FirstName = "Engin",
                    LastName = "Demiroğ"
                },
                new Instructor()
                {
                    InstructorId = 112,
                    FirstName = "Halit Enes",
                    LastName = "Kalaycı"
                },
                new Instructor()
                {
                    InstructorId = 113,
                    FirstName = "Mustafa Murat",
                    LastName = "Coşkun"
                }
            };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.RemoveAll(
                deleteInstructor => deleteInstructor.InstructorId == instructor.InstructorId
            );
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            foreach (Instructor updatedInstructor in _instructors)
            {
                if(updatedInstructor.InstructorId == instructor.InstructorId)
                {
                    updatedInstructor.FirstName = instructor.FirstName;
                    updatedInstructor.LastName = instructor.LastName;
                }
            }
        }
    }
}

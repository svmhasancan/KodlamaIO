using KodlamaIO.Business.Abstracts;
using KodlamaIO.DataAccess.Concreate;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concreate
{
    public class InstructorManager : IInstructorService
    {
        private InstructorDal _instructorDal;
        
        public InstructorManager(InstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}

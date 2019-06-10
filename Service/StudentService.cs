using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        bool Add(Student model);
        bool Delete(int id);
        bool Update(Student model);
        Student Get(int id);

    }
    public class StudentService: IStudentService
    {
        private readonly StudentDbContext _studentDbContext;

        public StudentService(StudentDbContext studentDbContex)
        {
            _studentDbContext = studentDbContex;
        }

        public IEnumerable<Student>GetAll()
        {
            var result = new List<Student>();

            try
            {
                result = _studentDbContext.Student.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Student Get(int id)
        {
            var result = new Student();

            try
            {
                result = _studentDbContext.Student.Single(x => x.StudentId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public bool Add(Student Model)
        {
            try
            {
                _studentDbContext.Add(Model);
                _studentDbContext.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
           
        }

        public bool Update(Student Model)
        {
            try
            {
                var originalModel = _studentDbContext.Student.Single(x =>
                    x.StudentId == Model.StudentId
                );

                originalModel.Name = Model.Name;
                originalModel.LastName = Model.LastName;
                originalModel.Bio = Model.Bio;
                _studentDbContext.Update(Model);
                _studentDbContext.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;

        }

        public bool Delete(int id)
        {
            try
            {
                _studentDbContext.Entry(new Student { StudentId = id }).State = EntityState.Deleted; ;
                _studentDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
    }
}

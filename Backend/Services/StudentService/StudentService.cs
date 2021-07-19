using Backend.DataLayer;
using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services.StudentService
{
    class StudentService : IStudentService
    {
        DBContex DB = new DBContex();
        public void Add(Student student)
        {
            DB.Students.Add(student);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = DB.Students.FirstOrDefault(p => p.Id == id);
            if (student != null) DB.Students.Remove(student);
            DB.SaveChanges();
        }

        public void Update(int id, Student student)
        {
            var model = DB.Students.FirstOrDefault(p => p.Id == id);
            if(model != null)
            {
                model.FirstName = student.FirstName;
                model.LastName = student.LastName;
                model.Birthday = student.Birthday;
                model.Group = student.Group;
                model.PaymentId = student.PaymentId;
                model.FaceId = student.FaceId;
                model.TouchId = student.TouchId;
                DB.SaveChanges();
            }
        }

        public Student Get(int id)
        {
            Student student = DB.Students.FirstOrDefault(p => p.Id == id);
            return student;
        }
    }
}

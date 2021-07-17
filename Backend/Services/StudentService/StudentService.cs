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
        public void Add(StudentModel student)
        {
            DB.Students.Add(student);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            StudentModel student = DB.Students.FirstOrDefault(p => p.Id == id);
            if (student != null) DB.Students.Remove(student);
            DB.SaveChanges();
        }

        public void Update(int id, StudentModel student)
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

        public StudentModel Get(int id)
        {
            StudentModel student = DB.Students.FirstOrDefault(p => p.Id == id);
            return student;
        }
    }
}

using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services.StudentService
{
    interface IStudentService
    {
        public void Add(StudentModel student);
        public StudentModel Get(int id);
        public void Update(int id, StudentModel student);
        public void Delete(int id);
    }
}

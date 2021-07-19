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
        public void Add(Student student);
        public Student Get(int id);
        public void Update(int id, Student student);
        public void Delete(int id);
    }
}

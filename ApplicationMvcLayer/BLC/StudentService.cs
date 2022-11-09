using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL;
using BLC.DTO;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;

namespace BLC
{
    public class StudentService
    {
        public static List<StudentDTO> Get()
        {
            var students = new List<StudentDTO>();
            foreach (var item in StudentRepo.Get())
            {
                var data = item.ToString();
                students.Add(new StudentDTO() { Id = item.Id, Name = item.Name });
            }
            return students;
          
        }
        
    }
}

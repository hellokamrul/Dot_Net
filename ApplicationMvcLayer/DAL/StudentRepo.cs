using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL
{
    public class StudentRepo
    {
        public static List<Student> Get()
        {
            var db = new PortalEntities();
            return db.Students.ToList();

        }
        
    }
}

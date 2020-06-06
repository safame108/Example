using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BuisnessObject;

namespace BuisnessLogic
{
    public class StudentBL
    {

        public CustomBO AddStudent(StudentOB st)
        {
            return new StudentDAL().AddStudent(st);
        }
    }
}

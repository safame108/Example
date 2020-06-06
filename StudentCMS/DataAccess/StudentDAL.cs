using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessObject;

namespace DataAccess
{
    public class StudentDAL
    {
        private StudentPortalEntities SPE;

        public StudentDAL()
        {
            SPE = new StudentPortalEntities();
        }
        public CustomBO AddStudent(StudentOB student)
        {
            CustomBO objcustome = new CustomBO();
            Student objstu = new Student() {

                Reg_no = student.RegisterNumber,
                FirstName=student.FirstName,
                LastName=student.LastName,
                Depart=student.Department,
                Semester=student.Semester
                
            };
            SPE.Students.Add(objstu);
            int returnval = SPE.SaveChanges();
            if (returnval > 0)
            {
                objcustome.CustomerMessage = "Data sucessfully added";
                objcustome.CustomeNumber = returnval;
            }
            else
            {
                objcustome.CustomerMessage = "Data failed to add";
                objcustome.CustomeNumber = returnval;
            }
            return objcustome;
            
        }
    }
}

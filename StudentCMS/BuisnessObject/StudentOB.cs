using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BuisnessObject
{
    public class StudentOB
    {
        [Display(Name = "Reg #")]
        [Required(ErrorMessage ="Enter incompleter information.")]
        public String RegisterNumber { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter incompleter information.")]

        public String FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter incompleter information.")]


        public String LastName { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Enter incompleter information.")]


        public String Department { get; set; }
        [Display(Name = "Semester (1 letter)")]
        [Required(ErrorMessage = "Enter incompleter information.")]


        public String Semester { get; set; }

    } 
}

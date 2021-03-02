using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HarmanMvcPractice.Models
{
    public class SignUp
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range (0,40, ErrorMessage ="Age should be less than 40 ")]
        public string Age { get; set; }
        [Required]
        [Range(0, 4000000, ErrorMessage = "Age should be less than 40 ")]
        public int Salary { get; set; }
        [Required]
        public string Desination { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public int genderDropdown { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

        
    }
}

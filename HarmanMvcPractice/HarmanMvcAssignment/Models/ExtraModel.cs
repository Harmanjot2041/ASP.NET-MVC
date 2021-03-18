using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HarmanMvcAssignment.Models
{
    public class ExtraModel
    {
        public ExtraModel()
        {
            RememberMe = true;
        }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Degsination { get; set; }
        public int Salary { get; set; }
        public Gender StudentGender { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public bool RememberMe { get; set; }

        

    }
    public enum Gender
    {
        Male,
        Female
    }
}

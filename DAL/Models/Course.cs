using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int TeacherId { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public Course()
        {
            StudentCourses = new List<StudentCourse>();
        }

    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseDTO
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

    }
}

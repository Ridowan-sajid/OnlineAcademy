using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Gmail { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }

        public virtual ICollection<StudentCommunity> StudentCommunities { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }



    }
}

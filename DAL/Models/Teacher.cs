using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Teacher
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
        [Required]
        public string Education { get; set; }
        [Required]
        public string InterestedCourse { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public Teacher()
        {
            Courses = new List<Course>();
            Posts = new List<Post>();
            Comments = new List<Comment>();
        }
    }
}

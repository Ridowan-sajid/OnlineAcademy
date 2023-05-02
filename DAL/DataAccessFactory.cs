using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Comment,int,bool> CommentData()
        {
            return new CommentRepo();
        }

        public static IRepo<Community, int, bool> CommunityData()
        {
            return new CommunityRepo();
        }
        public static IRepo<Course, int, bool> CourseData()
        {
            return new CourseRepo();
        }
        public static IRepo<Post, int, bool> PostData()
        {
            return new PostRepo();
        }
        public static IRepo<StudentCommunity, int, bool> StudentCommunityData()
        {
            return new StudentCommunityRepo();
        }
        public static IRepo<StudentCourse, int, bool> StudentCourseData()
        {
            return new StudentCourseRepo();
        }
        public static IRepo<Student, int, bool> StudentData()
        {
            return new StudentRepo();
        }
        public static IRepo<Teacher, int, bool> TeacherData()
        {
            return new TeacherRepo();
        }
    }
}

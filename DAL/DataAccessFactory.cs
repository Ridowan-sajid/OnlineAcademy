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
        public static IRepo<UserCommunity, int, bool> UserCommunityData()
        {
            return new UserCommunityRepo();
        }
        public static IRepo<UserCourse, int, bool> UserCourseData()
        {
            return new UserCourseRepo();
        }
        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }
/*        public static IRepo<Teacher, int, bool> TeacherData()
        {
            return new TeacherRepo();
        }*/
    }
}

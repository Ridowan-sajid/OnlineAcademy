using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineAcademy.Controllers
{
    public class StudentCourseController : ApiController
    {

        [HttpGet]
        [Route("api/StudentCourses")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = StudentCourseServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/StudentCourses/{id:int}")]
        public HttpResponseMessage GetM(int id)
        {
            try
            {
                var data = StudentCourseServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/StudentCourses/add")]
        public HttpResponseMessage AddMembers(StudentCourseDTO StudentCourse)
        {
            try
            {
                var res = StudentCourseServices.Create(StudentCourse);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/StudentCourses/update")]
        public HttpResponseMessage UpdateMembers(StudentCourseDTO StudentCourse)
        {
            try
            {
                var res = StudentCourseServices.Update(StudentCourse);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpDelete]
        [Route("api/StudentCourses/delete/{id:int}")]
        public HttpResponseMessage DeleteMembers(int id)
        {
            try
            {
                var res = StudentCourseServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}

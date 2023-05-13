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
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("api/Users")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = UserServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Users/{id:int}")]
        public HttpResponseMessage GetM(int id)
        {
            try
            {
                var data = UserServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }



        [HttpGet]
        [Route("api/Users/{id:int}/post")]
        public HttpResponseMessage GetWithPost(int id)
        {
            try
            {
                var data = UserServices.GetWithPost(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }


        [HttpPost]
        [Route("api/Users/add")]
        public HttpResponseMessage AddMembers(UserDTO Student)
        {
            try
            {
                var res = UserServices.Create(Student);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
        }

        [HttpPost]
        [Route("api/Users/update")]
        public HttpResponseMessage UpdateMembers(UserDTO Student)
        {
            try
            {
                var res = UserServices.Update(Student);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpDelete]
        [Route("api/Users/delete/{id:int}")]
        public HttpResponseMessage DeleteMembers(int id)
        {
            try
            {
                var res = UserServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.InnerException.InnerException.Message);
            }

        }
    }
}

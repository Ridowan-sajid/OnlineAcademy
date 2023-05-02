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
    public class StudentCommunityController : ApiController
    {

        [HttpGet]
        [Route("api/StudentCommunitys")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = StudentCommunityServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/StudentCommunitys/{id:int}")]
        public HttpResponseMessage GetM(int id)
        {
            try
            {
                var data = StudentCommunityServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/StudentCommunitys/add")]
        public HttpResponseMessage AddMembers(StudentCommunityDTO StudentCommunity)
        {
            try
            {
                var res = StudentCommunityServices.Create(StudentCommunity);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/StudentCommunitys/update")]
        public HttpResponseMessage UpdateMembers(StudentCommunityDTO StudentCommunity)
        {
            try
            {
                var res = StudentCommunityServices.Update(StudentCommunity);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpDelete]
        [Route("api/StudentCommunitys/delete/{id:int}")]
        public HttpResponseMessage DeleteMembers(int id)
        {
            try
            {
                var res = StudentCommunityServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}

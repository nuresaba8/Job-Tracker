using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Job_Tracker.Controllers
{
    public class CandidateController : ApiController
    {
        [HttpGet]
        [Route("api/candidate/all")]
        public HttpResponseMessage Get()
        {
            var data = CandidateService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/candidate/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = CandidateService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpPost]
        [Route("api/candidate/create")]
        public HttpResponseMessage Create(CandidateDTO j)
        {
           CandidateService.Create(j);
            return Request.CreateResponse(HttpStatusCode.OK, "Successfully Created!");
        }

        [HttpPut]
        [Route("api/candidate/update")]
        public HttpResponseMessage Update(CandidateDTO j)
        {

            var updatedCandidate = CandidateService.Update(j);
            return Request.CreateResponse(HttpStatusCode.OK, updatedCandidate);
        }

        [HttpDelete]
        [Route("api/candidate/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var deletedCandidate = CandidateService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, deletedCandidate);
        }
    }
}

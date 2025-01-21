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
    public class AvailableJobController : ApiController
    {
        //Give job circular by hiring manager
        [HttpPost]
        [Route("api/availablejobs/create")]
        public HttpResponseMessage Create(AvailableJobDTO a)
        {
            var createdJobApplication = AvailableJobService.Create(a);
            return Request.CreateResponse(HttpStatusCode.OK, createdJobApplication);
        }

        //Candidate Check all available jobs
        [HttpGet]
        [Route("api/availablejobs/all")]
        public HttpResponseMessage Get()
        {
            var data = AvailableJobService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //Candidated check their applied job apllications
        [Route("api/availablejobs/status/{status}")]
        [HttpGet]
        public HttpResponseMessage SearchStatus(string status)
        {
            var data = JobApplicationService.SearchStatus(status);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //Candidate get Notification from applied job's deadline
        [Route("api/availablejobs/notification")]
        [HttpGet]
        public HttpResponseMessage GetNotification()
        {
            var notifications = AvailableJobService.GetNotification();
            return Request.CreateResponse(HttpStatusCode.OK, notifications);
        }

        ////Hiring Manager delete applications
        [HttpDelete]
        [Route("api/availablejobs/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var deleteJobApplication = AvailableJobService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, deleteJobApplication);
        }



    }
}

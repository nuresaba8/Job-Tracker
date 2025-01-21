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
    public class JobApplicationController : ApiController
    {
        //Candiddate applies job application
        [HttpPost]
        [Route("api/jobapplication/create")]
        public HttpResponseMessage Create(JobApplicationDTO j)
        {
            var createdJobApplication = JobApplicationService.Create(j);
            return Request.CreateResponse(HttpStatusCode.OK, createdJobApplication);
        }

        //Candidate track their status
        [HttpGet]
        [Route("api/jobapplication/{id}/status")]
        public HttpResponseMessage GetwithStatus(int id)
        {
            var data = JobApplicationService.GetwithStatus(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //Candidate update their notes in jon application
        [HttpPut]
        [Route("api/jobapplication/{id}/note")]
        public HttpResponseMessage Update(int id, NoteDTO notesDto)
        {
            var jobApplicationDTO = JobApplicationService.Update(id, notesDto);
            return Request.CreateResponse(HttpStatusCode.OK, jobApplicationDTO);

        }

        //Hiring Manager check all applied applications
        [HttpGet]
        [Route("api/jobapplication/all")]
        public HttpResponseMessage Get()
        {
            var data = JobApplicationService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/jobapplication/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = JobApplicationService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //Hiring Manager filer job status
        [HttpGet]
        [Route("api/jobapplication/status/{status}")]
        public HttpResponseMessage SearchStatus(string status)
        {
            var data = JobApplicationService.SearchStatus(status);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //Hiring Manager update the status
        [HttpPut]
        [Route("api/jobapplication/{id}/updatestatus")]
        public HttpResponseMessage UpdateStatus(int id, StatusDTO status)
        {
            var jobApplicationDTO = JobApplicationService.UpdateStatus(id, status);
            return Request.CreateResponse(HttpStatusCode.OK, jobApplicationDTO);

        }


    }
}

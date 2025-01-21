using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JobApplicationService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobApplication, JobApplicationDTO>();
                cfg.CreateMap<JobApplicationDTO, JobApplication>();
            });
            return new Mapper(config);
        }








        //Candiddate applies job application
        public static JobApplicationDTO Create(JobApplicationDTO j)
        {
            var repo = DataAccessFactory.JobApplicationData();
            var finalData = GetMapper().Map<JobApplication>(j);
            repo.Create(finalData);
            return Get(j.JobId);

        }

        //Candidate track their status
        public static IEnumerable<string> GetwithStatus(int id)
        {
            var repo = DataAccessFactory.JobApplicationData();
            return repo
                .Get()
                .Where(n => n.JobId == id)
                .Select(n => GetMapper().Map<JobApplicationDTO>(n).Status);
        }


        //Candidate update their notes in jon application
        public static JobApplicationDTO Update(int jobId, NoteDTO notesDto)
        {
            var repo = DataAccessFactory.JobApplicationData();
            var updatedJobApplication = repo.Update(jobId, notesDto.Notes);

            return new JobApplicationDTO
            {
                JobId = updatedJobApplication.JobId,
                Status = updatedJobApplication.Status,
                Notes = updatedJobApplication.Notes,
                Deadling = updatedJobApplication.Deadling
            };
        }

        //Hiring Manager check all applied applications
        public static List<JobApplicationDTO> Get()
        {
            var repo = DataAccessFactory.JobApplicationData();
            return GetMapper().Map<List<JobApplicationDTO>>(repo.Get());
        }
        public static JobApplicationDTO Get(int id)
        {
            var repo = DataAccessFactory.JobApplicationData();

            var job = repo.Get(id);
            var ret = GetMapper().Map<JobApplicationDTO>(job);
            return ret;

        }

        ////Hiring Manager filer job status
        public static IEnumerable<JobApplicationDTO> SearchStatus(string status)
        {
            var repo = DataAccessFactory.JobApplicationData();
            return repo
                .Get()
                .Where(n => n.Status == status)
                .Select(n => GetMapper().Map<JobApplicationDTO>(n));
        }

        //Hiring Manager update the status
        public static JobApplicationDTO UpdateStatus(int id, StatusDTO status)
        {
            var repo = DataAccessFactory.JobApplicationData();
            var updatedJobApplication = repo.UpdateStatus(id, status.Status);

            return new JobApplicationDTO
            {
                JobId = updatedJobApplication.JobId,
                Status = updatedJobApplication.Status
            };
        }

    }
}

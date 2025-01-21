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
    public class AvailableJobService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AvailableJob, AvailableJobDTO>();
                cfg.CreateMap<AvailableJobDTO, AvailableJob>();
            });
            return new Mapper(config);
        }

        //Give job circular by hiring manager
        public static AvailableJobDTO Create(AvailableJobDTO a)
        {
            var repo = DataAccessFactory.AvailableJobData();
            var finalData = GetMapper().Map<AvailableJob>(a);
            repo.Create(finalData);
            return Get()
    .Where(n => n.AvaibleJobId == a.AvaibleJobId)
    .Select(n => GetMapper().Map<AvailableJobDTO>(n))
    .FirstOrDefault();

        }

        //Candidate Check all available jobs
        public static List<AvailableJobDTO> Get()
        {
            var repo = DataAccessFactory.AvailableJobData();
            return GetMapper().Map<List<AvailableJobDTO>>(repo.Get());
        }

        //Candidated check their applied job apllications
        public static IEnumerable<AvailableJobDTO> SearchStatus(string status)
        {
            var repo = DataAccessFactory.AvailableJobData();
            return repo
                .Get()
                .Where(n => n.Status == status)
                .Select(n => GetMapper().Map<AvailableJobDTO>(n));
        }

        //Candidate get Notification from applied job's deadline
        public static List<string> GetNotification()
        {
            var repo = DataAccessFactory.AvailableJobData();
            var jobs = repo.GetNotifications();
            var notifications = new List<string>();
            foreach (var job in jobs)
            {
                notifications.Add($"Reminder: Two Days Left!! The deadline for the job '{job.Company}' is on {job.Deadline:dd-MM-yyyy}.");
            }

            return notifications;
        }

        ////Hiring Manager delete applications
        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.AvailableJobData();
            repo.Delete(id);
            return true;
        }
    }
}

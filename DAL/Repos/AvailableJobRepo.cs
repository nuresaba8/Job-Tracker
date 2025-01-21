using DAL.EF.Tables;
using DAL.Inerfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AvailableJobRepo : Repo, IAvailableJobRepo<AvailableJob, int, AvailableJob>
    {
        //Give job circular by hiring manager
        public AvailableJob Create(AvailableJob obj)
        {
            db.AAvailableJobs.Add(obj);
            db.SaveChanges();
            return obj;
        }

        //Candidate Check all available jobs
        public List<AvailableJob> Get()
        {
            return db.AAvailableJobs.ToList();
        }

        ////Candidate get Notification from applied job's deadline
        public List<AvailableJob> GetNotifications()
        {
            var currentDate = DateTime.Now;
            var jobs = db.AAvailableJobs
                         .Where(job => job.Status == "Applied"
                                       && DbFunctions.DiffDays(currentDate, job.Deadline) == 2)
                         .ToList();

            return jobs;
        }

        ////Hiring Manager delete applications
        public bool Delete(int id)
        {
            var ex = db.AAvailableJobs.Find(id);
            db.AAvailableJobs.Remove(ex);
            return db.SaveChanges() > 0;
        }



    }

}

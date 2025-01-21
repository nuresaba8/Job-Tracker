using DAL.EF.Tables;
using DAL.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class JobApplicationRepo : Repo, IRepo<JobApplication, int, JobApplication>
    {


        //public bool Delete(int id)
        //{
        //    var ex = Get(id);
        //    db.JobApplications.Remove(ex);
        //    return db.SaveChanges() > 0;
        //}






        //public JobApplication UpdateStatus(int jobId, string newStatus)
        //{
        //    var jobApplication = db.JobApplications.Find(jobId);
        //    jobApplication.Status = newStatus;
        //    db.SaveChanges();

        //    return jobApplication; 
        //}



        //Candiddate applies job application
        public JobApplication Create(JobApplication obj)
        {
            db.JobApplications.Add(obj);
            db.SaveChanges();
            return obj;
        }

        //Candidate update their notes in jon application
        public JobApplication Update(int jobId, string newNotes)
        {
            var jobApplication = db.JobApplications.Find(jobId);
            jobApplication.Notes = newNotes;
            db.SaveChanges();
            return jobApplication;
        }

        //Hiring Manager check all applied applications
        public JobApplication Get(int id)
        {
            return db.JobApplications.Find(id);
        }

        public List<JobApplication> Get()
        {
            return db.JobApplications.ToList();
        }

        //Hiring Manager update the status
        public JobApplication UpdateStatus(int id, string status)
        {
            var jobApplication = db.JobApplications.Find(id);
            jobApplication.Status = status;
            db.SaveChanges();
            return jobApplication;
        }

    }
}

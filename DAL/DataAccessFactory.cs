using DAL.EF.Tables;
using DAL.Inerfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static ILoginRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }
        public static ICandidateRepo<Candidate, int, Candidate> CandidateData()
        {
            return new CandidateRepo();
        }
        public static IRepo<JobApplication, int, JobApplication> JobApplicationData()
        {
            return new JobApplicationRepo();
        }
        public static IAvailableJobRepo<AvailableJob, int, AvailableJob> AvailableJobData()
        {
            return new AvailableJobRepo();
        }
    }
}

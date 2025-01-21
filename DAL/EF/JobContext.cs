using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class JobContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<AvailableJob> AAvailableJobs { get; set; }
    }
}

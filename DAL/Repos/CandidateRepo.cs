using DAL.EF.Tables;
using DAL.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CandidateRepo : Repo, ICandidateRepo<Candidate, int, Candidate>
    {
        public Candidate Create(Candidate obj)
        {
            var user = new User();
            user.UserId = obj.CandidateId;
            user.UserEmail = obj.CandidateEmail;
            user.UserPassword = obj.CandidatePassword;
            user.UserRole = 3;
            db.Users.Add(user);
            db.SaveChanges();
            db.Candidates.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Candidates.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Candidate Get(int id)
        {
            return db.Candidates.Find(id);
        }

        public List<Candidate> Get()
        {
            return db.Candidates.ToList();
        }

        public Candidate Update(Candidate obj)
        {
            var ex = Get(obj.CandidateId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}

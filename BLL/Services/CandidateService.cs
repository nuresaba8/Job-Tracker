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
    public class CandidateService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Candidate, CandidateDTO>();
                cfg.CreateMap<CandidateDTO, Candidate>();
            });
            return new Mapper(config);
        }
        public static List<CandidateDTO> Get()
        {
            var repo = DataAccessFactory.CandidateData();
            return GetMapper().Map<List<CandidateDTO>>(repo.Get());
        }
        public static CandidateDTO Get(int id)
        {
            var repo = DataAccessFactory.CandidateData();

            var Product = repo.Get(id);
            var ret = GetMapper().Map<CandidateDTO>(Product);
            return ret;

        }

        public static CandidateDTO Create(CandidateDTO j)
        {
            var repo = DataAccessFactory.CandidateData();
            var finalData = GetMapper().Map<Candidate>(j);
            repo.Create(finalData);
            return Get(j.CandidateId);

        }

        public static CandidateDTO Update(CandidateDTO j)
        {
            var repo = DataAccessFactory.CandidateData();
            var finalData = GetMapper().Map<Candidate>(j);
            repo.Update(finalData);
            return Get(j.CandidateId);
        }

        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.CandidateData();
            repo.Delete(id);
            return true;
        }

    }
}

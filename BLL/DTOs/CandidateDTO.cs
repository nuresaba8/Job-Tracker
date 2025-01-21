using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CandidateDTO
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string CandidatePassword { get; set; }
        public string CandidateEmail { get; set; }
        public int UseCanId { get; set; }
    }
}

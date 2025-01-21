using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string CandidatePassword { get; set; }
        public string CandidateEmail { get; set; }
        [ForeignKey("UseCan")]
        public int UseCanId { get; set; }
        public virtual User UseCan { get; set; }
    }
}

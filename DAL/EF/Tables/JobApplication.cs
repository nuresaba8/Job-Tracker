using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class JobApplication
    {
        [Key]
        public int JobId { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime Deadling { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        [ForeignKey("JobCan")]
        public int JobCanId { get; set; }

        public virtual Candidate JobCan { get; set; }
    }
}

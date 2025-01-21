using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class AvailableJob
    {
        [Key]
        public int AvaibleJobId { get; set; }
        public DateTime Deadline { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}

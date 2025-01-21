using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class JobApplicationDTO
    {
        public int JobId { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime Deadling { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public int JobCanId { get; set; }
    }
}

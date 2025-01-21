using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AvailableJobDTO
    {
        public int AvaibleJobId { get; set; }
        public DateTime Deadline { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inerfaces
{
    public interface IAvailableJobRepo<CLASS, ID, RET>
    {
        RET Create(CLASS obj);
        List<CLASS> Get();
        List<CLASS> GetNotifications();
        bool Delete(ID id);



    }
}

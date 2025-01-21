using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inerfaces
{
    public interface IRepo<CLASS, ID, RET>
    {
        RET Create(CLASS obj);
        CLASS Get(ID id);
        List<CLASS> Get();
        RET Update(int id, string newNotes);
        RET UpdateStatus(int id, string status);



    }
}

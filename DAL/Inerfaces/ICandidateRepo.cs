﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inerfaces
{
    public interface ICandidateRepo<CLASS, ID, RET>
    {
        RET Create(CLASS obj);
        RET Update(CLASS obj);
        CLASS Get(ID id);
        List<CLASS> Get();
        bool Delete(ID id);
    }
}

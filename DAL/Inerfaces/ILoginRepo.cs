﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inerfaces
{
    public interface ILoginRepo<CLASS, ID, RET>
    {

        RET Login(CLASS obj);
    }
}

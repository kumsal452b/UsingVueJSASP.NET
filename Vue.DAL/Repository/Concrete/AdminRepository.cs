﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vue.DAL.Repository.Abstract;
using Vue.Domain;

namespace Vue.DAL.Repository.Concrete
{
    class AdminRepository:Repository<Admin>,IAdminRepository
    {

    }
}

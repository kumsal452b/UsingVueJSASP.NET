using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vue.DAL.Repository.Abstract;

namespace Vue.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        IAdminRepository AdminRepository { get; }
        IUserRepository UserRepository { get;}

        int complete();

    }
}

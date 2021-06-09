using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vue.DAL.Repository.Abstract;
using Vue.DAL.Repository.Concrete;

namespace Vue.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private VueContext mContext;
        public UnitOfWork(VueContext context)
        {
            this.mContext = context;
            AdminRepository = new AdminRepository(mContext);
            UserRepository = new UserRepository(mContext);

        }

        public IAdminRepository AdminRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }

        public int complete()
        {
            return mContext.SaveChanges();
        }

        public void Dispose()
        {
            mContext.Dispose();
        }
    }
}

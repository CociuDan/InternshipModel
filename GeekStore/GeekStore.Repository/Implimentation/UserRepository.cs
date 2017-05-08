using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Repository.Implimentation
{
    public class UserRepository : IUserRepository
    {
        private ISession _session;
        private ITransaction _transaction;

        public UserRepository(ISession session)
        {
            _session = session;
        }
        public void CreateUser(User user)
        {
            _session.SaveOrUpdate(user);
        }
    }
}

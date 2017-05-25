using GeekStore.Repository.Interfaces;
using NHibernate;
using System.Collections.Generic;
using GeekStore.Domain.Model;

namespace GeekStore.Repository.Implimentation
{
    public class CartRepository : ICartRepository
    {
        private ISession _session;
        public CartRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<Cart> GetAll(int UserId)
        {
            return _session.QueryOver<Cart>().Where(x => x.User.Id == UserId).List();
        }
    }
}
using GeekStore.Infrastucture.Extensions;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace GeekStore.Repository.Extensions
{
    public static class QueryableExtensions
    {
        public static IList<T> GetPagedResult<T>(this IQueryOver<T> query, PagedRequestDescription description)
        {
            query.Sort(description.JtSortingColumn, description.JtAscending);
            var entities = query.Skip(description.JtStartIndex).Take(description.JtPageSize).List<T>();            
            return entities;
        }

        public static void Sort<T>(this IQueryOver<T> colletion, string sortBy, bool asc = true)
        {
            ICriteria criteria = null;
            if (asc)
            {
                criteria = colletion.UnderlyingCriteria.AddOrder(Order.Asc(sortBy));
            }
            else
            {
                criteria = colletion.UnderlyingCriteria.AddOrder(Order.Desc(sortBy));
            }
        }
    }
}

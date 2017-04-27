using System.Collections.Generic;
using NHibernate;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain;

namespace GeekStore.Repository.Implimentation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private ISession _session;
        private ITransaction _transaction;
        public GenericRepository(ISession session)
        {
            _session = session;
        }

        public void Save(T entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _session.QueryOver<T>().List();
        }

        public IEnumerable<T> GetAllPaged(int page, int pageSize)
        {
            return _session.QueryOver<T>().Skip((page - 1) * pageSize).Take(pageSize).List();
        }

        public T GetById(int id)
        {
            return _session.Get<T>(id);
        }

        public void Update(T entity)
        {
            _session.Update(entity);
        }

        public void Delete(T entity)
        {
            _transaction = _session.BeginTransaction();
            _session.Delete(entity);
            _transaction.Commit();
        }
        
        //public IEnumerable<CPU> GetTOPCPUs()
        //{
        //    CPU cpuAlias = null;
        //    return _session.QueryOver(() => cpuAlias)
        //                   .Where(Restrictions.On(() => cpuAlias.Model).IsLike("%i7%") || Restrictions.On(() => cpuAlias.Model).IsLike("%Ryzen 7%"))
        //                   .List();
        //}

        //public IEnumerable<string> GetLaptops()
        //{
        //    Laptop laptopAlias = null;
        //    CPU cpuAlias = null;
        //    return _session.QueryOver(() => laptopAlias)
        //                   .JoinQueryOver(() => laptopAlias.CPU, () => cpuAlias)
        //                   .Where(x=>x.Model.IsLike("2600", MatchMode.Anywhere))
        //                   .Select(c => c.Model).List<string>();
        //}

        //public IEnumerable<LaptopCpuGpuModels> GetLaptopCpuGpuModels()
        //{
        //    Laptop laptopAlias = null;
        //    CPU cpuAlias = null;
        //    GPU gpuAlias = null;
        //    LaptopCpuGpuModels laptopCpuGpuModels = null;
        //    return _session.QueryOver(() => laptopAlias)
        //                   .JoinAlias(() => laptopAlias.CPU, () => cpuAlias)
        //                   .JoinAlias(() => laptopAlias.GPU, () => gpuAlias)
        //                   .SelectList(list => list
        //                   .Select(() => laptopAlias.Model).WithAlias(() => laptopCpuGpuModels.LaptopModel)
        //                   .Select(() => cpuAlias.Model).WithAlias(() => laptopCpuGpuModels.CpuModel)
        //                   .Select(() => gpuAlias.Model).WithAlias(() => laptopCpuGpuModels.GpuModel))
        //                   .TransformUsing(Transformers.AliasToBean<LaptopCpuGpuModels>())
        //                   .List<LaptopCpuGpuModels>();
        //}

        //public IEnumerable<int> GetCaseCount()
        //{
        //    return _session.QueryOver<Case>().Select().
        //}
    }
}
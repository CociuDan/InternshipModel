using System.Collections.Generic;
using NHibernate;
using GeekStore.Repository.Interfaces;
using GeekStore.Domain;
using GeekStore.Domain.Model;
using GeekStore.Domain.Model.Components;
using NHibernate.Criterion;
using GeekStore.Domain.CustomModel;
using NHibernate.Transform;

namespace GeekStore.Repository.Implimentation
{
    public class GenericRepository : IRepository
    {
        private ISession _session;
        //private ITransaction _transaction;
        public GenericRepository(ISession session)
        {
            _session = session;
        }

        public void Save<T>(T item) where T : Entity
        {
            _session.SaveOrUpdate(item);
        }

        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            return _session.QueryOver<T>().List();
        }

        public Entity GetById<T>(int id) where T : Entity
        {
            return _session.Get<T>(id);
        }

        public void Update<T>(T item) where T : Entity
        {
            _session.Update(item);
        }

        public void Delete<T>(T item) where T : Entity
        {
            //_transaction = _session.BeginTransaction();
            _session.Delete(item);
            // _transaction.Commit();
        }



























        public IEnumerable<CPU> GetTOPCPUs()
        {
            CPU cpuAlias = null;
            return _session.QueryOver(() => cpuAlias)
                           .Where(Restrictions.On(() => cpuAlias.Model).IsLike("%i7%") || Restrictions.On(() => cpuAlias.Model).IsLike("%Ryzen 7%"))
                           .List();
        }

        public IEnumerable<string> GetLaptops()
        {
            Laptop laptopAlias = null;
            CPU cpuAlias = null;
            return _session.QueryOver(() => laptopAlias)
                           .JoinQueryOver(() => laptopAlias.CPU, () => cpuAlias)
                           .Where(x=>x.Model.IsLike("2600", MatchMode.Anywhere))
                           .Select(c => c.Model).List<string>();
        }

        public IEnumerable<LaptopCpuGpuModels> GetLaptopCpuGpuModels()
        {
            Laptop laptopAlias = null;
            CPU cpuAlias = null;
            GPU gpuAlias = null;
            LaptopCpuGpuModels laptopCpuGpuModels = null;
            return _session.QueryOver(() => laptopAlias)
                           .JoinAlias(() => laptopAlias.CPU, () => cpuAlias)
                           .JoinAlias(() => laptopAlias.GPU, () => gpuAlias)
                           .SelectList(list => list
                           .Select(() => laptopAlias.Model).WithAlias(() => laptopCpuGpuModels.LaptopModel)
                           .Select(() => cpuAlias.Model).WithAlias(() => laptopCpuGpuModels.CpuModel)
                           .Select(() => gpuAlias.Model).WithAlias(() => laptopCpuGpuModels.GpuModel))
                           .TransformUsing(Transformers.AliasToBean<LaptopCpuGpuModels>())
                           .List<LaptopCpuGpuModels>();
        }

        //public IEnumerable<int> GetCaseCount()
        //{
        //    return _session.QueryOver<Case>().Select().
        //}
    }
}

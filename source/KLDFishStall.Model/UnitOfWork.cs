using KLDFishStall.Model.Models;
using System;
using System.Collections.Generic;

namespace KLDFishStall.Model
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private field members
        private Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        private KLDFishStallContext dataContext;
        #endregion

        #region CTOR
        public UnitOfWork(KLDFishStallContext dataContext)
        {
            this.dataContext = dataContext;
        }
        #endregion

        public Repository<User> User => GetRepository<User>();

        public Repository<Order> Order => GetRepository<Order>();

        public Repository<OrderItem> OrderItem => GetRepository<OrderItem>();

        public Repository<FishAttributes> FishAttributes => GetRepository<FishAttributes>();

        public Repository<Fish> Fish => GetRepository<Fish>();

        public Repository<Category> Category => GetRepository<Category>();

        public Repository<FishCategory> FishCategory => GetRepository<FishCategory>();

        public Repository<FishImage> FishImage => GetRepository<FishImage>();

        public void Commit()
        {
            dataContext.SaveChanges();
        }

        private Repository<T> GetRepository<T>() where T : class
        {
            if (!_repositories.ContainsKey(typeof(T)))
                _repositories.Add(typeof(T), new Repository<T>(dataContext));
            return (Repository<T>)_repositories[typeof(T)];
        }
    }
}

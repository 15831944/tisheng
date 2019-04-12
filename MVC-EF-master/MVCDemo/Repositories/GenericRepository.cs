using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MVCDemo.DAL;
using System.Data.Entity;
using System.Data;

namespace MVCDemo.Repositories
{
    public class GenericRepository<TEntity> :
        IGenericRepository<TEntity> where TEntity : class
    {
        internal AccountContext Context;
        internal DbSet<TEntity> dbset;
        public GenericRepository(AccountContext Context)
        {
            this.Context = Context;
            this.dbset = Context.Set<TEntity>();
        }
        public void Delete(object Id)
        {
            TEntity user= dbset.Find(Id);
            Delete(user);
        }
        public virtual void Delete(TEntity user)
        {
            if (Context.Entry(user).State==EntityState.Detached)
            {
                dbset.Attach(user);
            }
            dbset.Remove(user);
        }

        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties="")
        {
            IQueryable<TEntity> query = dbset;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split(new char[] { ','},StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);

            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return dbset.ToList();
            }
        }

        public TEntity GetById(object id)
        {
            return dbset.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbset.Add(entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbset.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~GenericRepository() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
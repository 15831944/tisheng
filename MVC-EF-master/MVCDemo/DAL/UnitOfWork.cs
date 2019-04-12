using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Repositories;
using MVCDemo.ViewModels;

namespace MVCDemo.DAL
{
    public class UnitOfWork:IDisposable
    {

        private AccountContext context = new AccountContext();
        private GenericRepository<SysUser> _SysUserRepository;
        private GenericRepository<SysUserRole> _SysUserRoleRepository;
        private GenericRepository<SysRole> _SysRoleRepository;

        public GenericRepository<SysUser> SysUserRepository
        {
            get
            {
                if (this._SysUserRepository==null)
                {
                    this._SysUserRepository = new GenericRepository<SysUser>(context);
                }
                return _SysUserRepository;
            }
        }
        public GenericRepository<SysUserRole> SysUserRoleRepository
        {
            get
            {
                if (this._SysUserRoleRepository == null)
                {
                    this._SysUserRoleRepository = new GenericRepository<SysUserRole>(context);
                }
                return _SysUserRoleRepository;
            }
        }
        public GenericRepository<SysRole> SysRoleRepository
        {
            get
            {
                if (this._SysRoleRepository == null)
                {
                    this._SysRoleRepository = new GenericRepository<SysRole>(context);
                }
                return _SysRoleRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
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
        // ~UnitOfWork() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        void IDisposable.Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
using HMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndocPM.WebAPI
{
    public interface IUnitOfWork : IDisposable
    {
        HmsDbcontext context { get; }

        void BeginTranaction();

        void Commit();

        void Rollback();
        void Dispose();
        void Save();
        Task SaveAsync();
        IGenericRepository<T> GenericRepository<T>() where T : class;
    }
}

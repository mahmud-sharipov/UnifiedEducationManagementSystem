using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OneCampus.Domain.Core.Interfaces;

namespace OneCampus.Domain.Interfaces.Context
{
    public interface IContext : IDisposable
    {
        int? CommandTimeout { get; set; }
        IQueryable<T> Set<T>() where T : class, IEntity;
        void Update<T>(Guid id, T entity) where T : class, IEntity;
        void Delete<T>(T entity) where T : class, IEntity;
        T Get<T>(Guid guid) where T : class, IEntity;
        bool HasChange();
        int ExecuteSqlCommand(string sql, params object[] parameters);
        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);
        void UndoChanges();
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}

using Microsoft.EntityFrameworkCore.Storage;

namespace Factory.BLL.InterFaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();

        IExecutionStrategy CreateExecutionStrategy();
    }
}
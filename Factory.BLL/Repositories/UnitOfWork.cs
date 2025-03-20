using Factory.BLL.InterFaces;
using Factory.BLL.Repositories;
using Factory.DAL;
using Microsoft.EntityFrameworkCore.Storage;

namespace Factory.BLL
{
public class UnitOfWork : IUnitOfWork
{
    private readonly FactDdContext _context;
    private Dictionary<Type, object> _repositories;
    private IDbContextTransaction _transaction;
    private bool _disposed;

    public UnitOfWork(FactDdContext context)
    {
        _context = context;
        _repositories = new Dictionary<Type, object>();
    }

    public IExecutionStrategy CreateExecutionStrategy()
    {
        return _context.Database.CreateExecutionStrategy();
    }

    public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
    {
        if (_repositories.ContainsKey(typeof(TEntity)))
        {
            return _repositories[typeof(TEntity)] as IRepository<TEntity>
                ?? throw new InvalidOperationException($"Repository for {typeof(TEntity).Name} not found.");
        }

        var repository = new Repository<TEntity>(_context);
        _repositories.Add(typeof(TEntity), repository);
        return repository;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
        return _transaction;
    }

    public async Task CommitTransactionAsync()
    {
        try
        {
            await _transaction.CommitAsync();
        }
        finally
        {
            await _transaction.DisposeAsync();
            _transaction = null;
        }
    }

    public async Task RollbackTransactionAsync()
    {
        try
        {
            await _transaction.RollbackAsync();
        }
        finally
        {
            await _transaction.DisposeAsync();
            _transaction = null;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _repositories?.Clear();
                _transaction?.Dispose();
                _context?.Dispose();
            }
        }
        _disposed = true;
    }
}
}
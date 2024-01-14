using Common.Abstractions;
using Infrastructure.Abstractions;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private static readonly string ConnectionString = "ConnectionString";

        private IDbConnection _connection;

        private IDbTransaction _transaction;

        private bool _disposed;

        private IAccountRepository _account;

        public IAccountRepository Account
        {
            get { return _account ??= new AccountRepository(_transaction, _connection); }
        }

        public UnitOfWork(IConfigProvider configProvider)
        {
            var connectionString = configProvider.GetConfigString(ConnectionString);
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Begin();
        }

        private void ResetRepository()
        {
            _account = null;
        }

        public void Begin()
        {
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            if (_transaction == null) return;

            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
            }
            finally
            {
                _transaction.Dispose();
                ResetRepository();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }

                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
            }

            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}

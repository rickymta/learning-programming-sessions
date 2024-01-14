using System.Data;

namespace Infrastructure.Implementations
{
    internal class RepositoryBase
    {
        protected IDbTransaction Transaction { get; }

        protected IDbConnection Connection { get; }

        public RepositoryBase(IDbTransaction transaction, IDbConnection connection)
        {
            Transaction = transaction;
            Connection = connection;
        }
    }
}

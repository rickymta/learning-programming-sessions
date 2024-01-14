namespace Infrastructure.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Account { get; }

        void Begin();

        void Commit();
    }
}

using Models.Entities;

namespace Infrastructure.Abstractions
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<Account?> HandleLoginAsync(string email);
    }
}

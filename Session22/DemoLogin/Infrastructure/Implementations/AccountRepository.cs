using DapperExtensions;
using DapperExtensions.Predicate;
using Infrastructure.Abstractions;
using Models.Entities;
using System.Data;

namespace Infrastructure.Implementations
{
    internal class AccountRepository : RepositoryBase, IAccountRepository
    {
        public AccountRepository(IDbTransaction transaction, IDbConnection connection) : base(transaction, connection)
        {
        }

        /// <summary>
        /// Thêm mới bản ghi Account
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<long> CreateAsync(Account entity)
        {
            try
            {
                // Tiến hành thêm mới bản ghi Account và trả về Id của bản ghi vừa thêm mới
                var id = await Connection.InsertAsync(entity, transaction: Transaction);
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Nếu thêm mới lỗi, trả về 0
                return 0;
            }
        }

        /// <summary>
        /// Xoá bản ghi Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                // Tìm ra bản ghi cần xoá
                var find = await Connection.GetAsync<Account>(id);

                // Kiểm tra xem có tìm thấy không?
                if (find != null)
                {
                    // Nếu tìm thấy thì tiến hành xoá
                    var result = await Connection.DeleteAsync(find, transaction: Transaction);
                    // Trả ra kết quả xoá thành công hay không?
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Account>?> GetAllAsync()
        {
            try
            {
                var result = await Connection.GetListAsync<Account>(transaction: Transaction);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Lấy 1 bản ghi Account theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Account?> GetAsync(long id)
        {
            try
            {
                // Tìm trong DB có bản ghi nào có id = id cần tìm không
                var find = await Connection.GetAsync<Account>(id, transaction: Transaction);
                // Trả về kết quả
                return find;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Xử lý đăng nhập
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Account?> HandleLoginAsync(string email)
        {
            try
            {
                var condition = new PredicateGroup
                {
                    Operator = GroupOperator.And,
                    Predicates = new List<IPredicate>()
                    {
                        new FieldPredicate<Account> { PropertyName = "Email", Operator = Operator.Eq, Value = email }
                    }
                };

                var result = await Connection.GetListAsync<Account>(condition, transaction: Transaction);

                if (result != null && result.Any())
                {
                    return result.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        /// <summary>
        /// Cập nhật bản ghi Account
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(Account entity)
        {
            try
            {
                // Tìm ra bản ghi cần cập nhật
                var find = await Connection.GetAsync<Account>(entity.Id, transaction: Transaction);

                // Kiểm tra xem có tìm thấy không?
                if (find != null)
                {
                    // Tiến hành cập nhật
                    var result = await Connection.UpdateAsync(entity, transaction: Transaction);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return false;
        }
    }
}

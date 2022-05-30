using CloudCustomers.API.Models;

namespace CloudCustomers.API.Interface
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }
}

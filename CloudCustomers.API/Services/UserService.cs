using CloudCustomers.API.Interface;
using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var userResponse = await _httpClient.GetAsync("http://example.com");
            return new List<User>() { };
        }
    }
}

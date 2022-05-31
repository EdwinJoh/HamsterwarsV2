using Entities.Models;
using SharedHelpers;

namespace Service.Contracts
{
    public interface IAutService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExist(string email);
        Task<ServiceResponse<string>> Login(string email,string password);
    }
}

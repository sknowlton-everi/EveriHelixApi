using EveriHelixAPI.Models;

namespace EveriHelixAPI.Services
{
    public interface IUserService
    {
        Task<ProjectList> ValidateCredentialsAsync(string username, string password);

        Task<Token> GetTokenAsync(UserCredentials credentials);
    }
}
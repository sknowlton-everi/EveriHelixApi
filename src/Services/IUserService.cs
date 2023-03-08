using EveriHelixAPI.Models;

namespace EveriHelixAPI.Services
{
    public interface IUserService
    {
        Task<ProjectList> ValidateCredentialsAsync(string username, string password);

        Task<Token> AuthenticateAsync(int projectId, string username, string password);
    }
}
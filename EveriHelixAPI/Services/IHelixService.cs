using EveriHelixAPI.Models;

namespace EveriHelixAPI.Services
{
    public interface IHelixService
    {
        Task<ProjectList> GetProjectsAsync();

        Task<RequirementList> GetRequirementsAsync();

        Task<Requirement> GetRequirementAsync(int id);
    }
}
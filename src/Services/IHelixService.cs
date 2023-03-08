using EveriHelixAPI.Models;
using EveriHelixAPI.Services.Impl;
using System.Net;

namespace EveriHelixAPI.Services
{
    public interface IHelixService
    {
        Task<ProjectList> GetProjectsAsync();

        Task<RequirementList> GetRequirementsAsync(int projectId);

        Task<Requirement> GetRequirementAsync(int projectId, int requirementid);
    }
}
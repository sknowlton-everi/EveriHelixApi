using EveriHelixAPI.Extensions;
using EveriHelixAPI.Models;
using EveriHelixAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics;
using System.Net.Mime;

namespace EveriHelixAPI.Controllers.v1
{
    [Authorize]
    [ApiController]
    [Route("v1/api")]
    public class RequirementController : ControllerBase
    {
        private readonly IHelixService helixService;

        public RequirementController(IHelixService helixService)
        {
            this.helixService = helixService;
        }

        [HttpGet("{projectId}/requirements")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(RequirementList), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllAsync(int projectId)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            RequirementList result = await helixService.GetRequirementsAsync(projectId);

            return Ok(result);
        }

        [HttpGet("{projectId}/requirements/{requirementId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Requirement), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetByIdAsync(int projectId, int requirementId)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            Requirement requirement = await helixService.GetRequirementAsync(projectId, requirementId);
            if (requirement != null)
            {
                return Ok(requirement);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("{projectId}/requirements")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Requirement), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateRequirementAsync(int projectId, Requirement requirement)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            return Ok();
        }

        [HttpPut("{projectId}/requirements")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Requirement), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateRequirementAsync(int projectId, Requirement requirement)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            return Ok();
        }

        [HttpDelete("{projectId}/requirements/{requirementId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Requirement), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteRequirementAsync(int projectId, int requirementId)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            return Ok();
        }
    }
}
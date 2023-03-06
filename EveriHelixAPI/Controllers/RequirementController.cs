using EveriHelixAPI.Extensions;
using EveriHelixAPI.Models;
using EveriHelixAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics;
using System.Net.Mime;
using System.Reflection;

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

        [HttpGet("/requirements/")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(RequirementList), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllAsync()
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            RequirementList result = await helixService.GetRequirementsAsync();

            return Ok(result);
        }

        [HttpGet("/requirements/{id}/")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Requirement), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetById(int id)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            Requirement requirement = await helixService.GetRequirementAsync(id);
            if (requirement != null)
            {
                return Ok(requirement);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
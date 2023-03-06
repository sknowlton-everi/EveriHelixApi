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
    public class ProjectController : ControllerBase
    {
        private readonly IHelixService helixService;

        public ProjectController(IHelixService helixService)
        {
            this.helixService = helixService;
        }

        [HttpGet("/projects/")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IList<ProjectList>), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllAsync()
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            ProjectList result = await helixService.GetProjectsAsync();

            return Ok(result);
        }
    }
}
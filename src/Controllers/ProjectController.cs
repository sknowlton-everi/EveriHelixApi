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
    public class ProjectController : ControllerBase
    {
        private readonly IHelixService helixService;
        private readonly IUserService userService;

        public ProjectController(IHelixService helixService, IUserService userService)
        {
            this.helixService = helixService;
            this.userService = userService;
        }

        [HttpPost("login")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Token), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> LoginAsync(UserCredentials credentials)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            Token result = await userService.GetTokenAsync(credentials);

            return Ok(result);
        }

        [HttpGet("projects")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ProjectList), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProjectsAsync()
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            ProjectList result = await helixService.GetProjectsAsync();

            return Ok(result);
        }
    }
}
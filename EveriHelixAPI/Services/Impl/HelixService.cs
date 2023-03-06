using EveriHelixAPI.Controllers.v1;
using EveriHelixAPI.Extensions;
using EveriHelixAPI.Models;
using Microsoft.Net.Http.Headers;
using Serilog;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace EveriHelixAPI.Services.Impl
{
    public class HelixService : IHelixService
    {
        private static string HELIX_REST_URL = "https://127.0.0.1:8443/helix-alm/api/v0";
        private static string USERNAME = "Administrator";
        private static string PASSWORD = "Atilla455";

        private static int PROJECT_ID = 2;

        public HelixService()
        {
        }

        public async Task<ProjectList> GetProjectsAsync()
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthenticationSchemes.Basic.ToString(), USERNAME.getBasicAuth(PASSWORD));

            HttpResponseMessage response = await httpClient.GetAsync($"{HELIX_REST_URL}/projects");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            ProjectList result = JsonSerializer.Deserialize<ProjectList>(jsonString);

            return result;
        }

        public async Task<Requirement> GetRequirementAsync(int id)
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            //bool itemExists = list.Any(x => x.id == id);
            //if (itemExists)
            //{
            //    result = list.Single(x => x.id == id);
            //}

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", "bearer token here");

            HttpResponseMessage response = await httpClient.GetAsync($"{HELIX_REST_URL}/{PROJECT_ID}/requirement/{id}?formattedText=true");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            Requirement result = JsonSerializer.Deserialize<Requirement>(jsonString);

            return result;
        }

        public async Task<RequirementList> GetRequirementsAsync()
        {
            Log.Debug($"Executing {new StackTrace().Caller}...");

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Manual;
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, policyErrors) =>
            {
                return true;
            };

            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer ", "bearer token here");

            HttpResponseMessage response = await httpClient.GetAsync($"{HELIX_REST_URL}/{PROJECT_ID}/requirements?page=1&per_page=300&formattedText=true");
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            RequirementList result = JsonSerializer.Deserialize<RequirementList>(jsonString);

            return result;
        }
    }
}
using EveriHelixAPI.Infrastructure.Filters;
using EveriHelixAPI.Models;
using EveriHelixAPI.Services;
using EveriHelixAPI.Services.Impl;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.OpenApi.Models;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;

namespace EveriHelixAPI.Extensions
{
    public static class HelixExtensions
    {
        // //private static string HELIX_REST_URL = "http://help.seapine.com/helixalm/rest-api/"; //private static
        // string HELIX_REST_URL = "https://tryhelixalm.perforce.com/ttweb/"; //private static string HELIX_REST_URL = "http://10.208.37.10/ttweb/";

        // //http://10.208.37.10/ttweb/

        // //https://localhost:8443/helix-alm/api/v0/projects

        // //http://10.208.37.10/helix-alm/api/v0/projects

        // //"basic QWRtaW5pc3RyYXRvcjpBdGlsbGE0NTU=" private static string username = "Administrator";

        // private static string password = "Atilla455";

        // //basic cmljaGFyZC5oZW5yeUBldmVyaS5jb206bnU1ZGlt //private static string username =
        // "richard.henry@everi.com"; //private static string password = "nu5dim";

        // //basic cmhlbnJ5OnJoZW5yeQ== //private static string username = "rhenry"; //private static string password = "rhenry";

        // //Key Id //790202c9d2d90159b4cbf334bbaa2dcdb739cea9844a968b5ea2397ebbe43b79 //Secret
        // //49644c89fd85b9d785317431d8bdafab03afa25a241cc6bd232317f7ab47071c //private static string apiKey =
        // "5f5be403382fe8cf5d5279806f77acf6be1af6dfe5c4768701a73b578ac75a2a"; private static string apiKey = "ApiKey 9f9c7c986035aa84f27dadf273aa529d557c1c5b127c192433b1ca21e25b2430:ce61eac227f1bcd531a9b6d1660e6d13acad59a037c4f6fb5c621298bb8675e2";

        // private static HttpClient client = null;

        // //private static string projectName = "Traditional Template"; private static int projectId = 2;

        // public static void UseHelix(this WebApplication app) { initializeClient();

        // // Gets the list of projects //ProjectList projectList = getProjectList().Result;

        // // Gets an authorization token AccessToken accessToken = getAuthorizationToken();

        // // Gets a list of issues var requirementsList = getRequirementsList(accessToken);

        // // Gets issue 1 and changes a value //UpdateIssuePriorityExample(accessToken);

        // // Adds a new Reported by record //AddReportedByRecordExample(accessToken);

        // // Adds a workflow event //AddWorkflowEventExample(accessToken);

        // // Generates and passes a test run //GenerateAndPassTestRun(accessToken); }

        // private static void initializeClient() { // Sets up a custom HttpClientHandler that allows self signed
        // certificates AppContext.SetSwitch("System.Net.Http.useSocketsHttpHandler", false);

        // HttpClientHandler handler = new HttpClientHandler(); handler.ClientCertificateOptions =
        // ClientCertificateOption.Automatic; //handler.ServerCertificateCustomValidationCallback = (httpRequestMessage,
        // cert, certChain, policyErrors) => //{ // // If no errors, or specifically we are communicating with the
        // configured server and the error is a // // certificate chain error, allow the connection // if (policyErrors
        // == System.Net.Security.SslPolicyErrors.None || //
        // (httpRequestMessage.RequestUri.AbsoluteUri.StartsWith(HELIX_REST_URL) && policyErrors ==
        // System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors)) // { // return true; // } // // Otherwise,
        // reject the connection // return false; //};

        // // Create the HttpClient passing in the handler client = new HttpClient(handler);

        // // Update the port number in the following line client.BaseAddress = new Uri(HELIX_REST_URL);
        // client.DefaultRequestHeaders.Accept.Clear(); client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // // Write all messages to the console //System.Diagnostics.TraceListener listener = new
        // System.Diagnostics.ConsoleTraceListener(); //System.Diagnostics.Debug.Listeners.Add(listener); }

        // private static async Task<ProjectList> getProjectList() { ProjectList result = null;

        // try { // Builds the request var request = new HttpRequestMessage(HttpMethod.Get, "projects");
        // addBasicAuthToHeader(ref request); result = await sendRequest<ProjectList>(request); } catch (Exception e) {
        // System.Diagnostics.Debug.WriteLine(e.Message); }

        // if (result != null) { for (int index = 0; index < result.projects.Length; index++)
        // System.Diagnostics.Debug.WriteLine(result.projects[index].name); } return result; }

        // private static void addBasicAuthToHeader(ref HttpRequestMessage request) { string authorization = "basic " +
        // base64EncodeString(username + ":" + password); request.Headers.Authorization = new
        // AuthenticationHeaderValue(authorization); }

        // private static string base64EncodeString(string inString) { byte[] data =
        // System.Text.ASCIIEncoding.ASCII.GetBytes(inString); return System.Convert.ToBase64String(data); }

        // private static async Task<T> sendRequest<T>(HttpRequestMessage inRequest) { T result = default(T);

        // try { // Sends the request HttpResponseMessage response = await client.SendAsync(inRequest); // Reads the
        // response DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(T)); var responseString =
        // await response.Content.ReadAsStringAsync(); if (response.IsSuccessStatusCode) { if (responseString.Length >
        // 0) { MemoryStream responseStream = new
        // MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(responseString)); responseStream.Position = 0; result =
        // (T)json.ReadObject(responseStream); } } else { System.Diagnostics.Debug.WriteLine(responseString);
        // response.EnsureSuccessStatusCode(); } } catch (Exception e) { string errorMessage = e.Message;

        // if (e.InnerException != null) { errorMessage += " " + e.InnerException.Message; }

        // System.Diagnostics.Debug.WriteLine(errorMessage); }

        // return result; }

        // private static AccessToken getAuthorizationToken() { AccessToken responseBody = null;

        // try { // Builds the request var url = projectId + "/token"; var request = new
        // HttpRequestMessage(HttpMethod.Get, url); addBasicAuthToHeader(ref request); responseBody =
        // sendRequest<AccessToken>(request).Result; } catch (Exception e) {
        // System.Diagnostics.Debug.WriteLine(e.Message); }

        // return responseBody; }

        // private static IList<Requirement> getRequirementsList(AccessToken accessToken) { IList<Requirement> result = null;

        // try { // Builds the request var url = projectId + "/requirements?page=1&per_page=300&formattedText=true"; var
        // request = new HttpRequestMessage(HttpMethod.Get, url); addBearerTokenToHeader(ref request, accessToken);
        // result = sendRequest<IList<Requirement>>(request).Result; } catch (Exception e) {
        // System.Diagnostics.Debug.WriteLine(e.Message); }

        // if (result != null) { for (int index = 0; index < result.Count; index++) {
        // //System.Diagnostics.Debug.WriteLine(result.issues[index].tag); } }

        // return result; }

        // private static IssuesList getIssuesList(AccessToken accessToken) { IssuesList responseBody = null;

        // try { // Builds the request var url = projectId + "/issues"; var request = new
        // HttpRequestMessage(HttpMethod.Get, url); addBearerTokenToHeader(ref request, accessToken); responseBody =
        // sendRequest<IssuesList>(request).Result; } catch (Exception e) {
        // System.Diagnostics.Debug.WriteLine(e.Message); }

        // if (responseBody != null) { for (int index = 0; index < responseBody.issues.Length; index++)
        // System.Diagnostics.Debug.WriteLine(responseBody.issues[index].tag); }

        // return responseBody; }

        //    private static void addBearerTokenToHeader(ref HttpRequestMessage request, AccessToken accessToken)
        //    {
        //        if (accessToken != null)
        //        {
        //            string authorization = "Bearer " + accessToken.accessToken;
        //            request.Headers.Authorization = new AuthenticationHeaderValue(authorization);
        //        }
        //    }
        //}
    }
}
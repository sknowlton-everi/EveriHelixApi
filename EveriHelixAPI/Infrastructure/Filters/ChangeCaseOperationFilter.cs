using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;

namespace EveriHelixAPI.Infrastructure.Filters
{
    public class ChangeCaseOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            //RH WIP operation.Tags.ToList().ForEach(x => { x.Name = x.Name.ToLower(); });
        }
    }
}
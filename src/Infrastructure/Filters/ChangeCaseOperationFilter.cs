using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

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
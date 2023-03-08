using EveriHelixAPI.Controllers;
using EveriHelixAPI.Infrastructure.Filters;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;

namespace EveriHelixAPI.Extensions
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddSwaggerGen(x =>
            {
                //see for implementing a v2 version of our API
                //https://www.talkingdotnet.com/clean-way-to-add-swagger-asp-net-core-application/
                //https://www.c-sharpcorner.com/article/basic-authentication-in-swagger-open-api-net-5/

                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Everi Helix API",
                    Description = "Use this site for interacting with Requirements and/or Test Cases from Helix",
                    Contact = new OpenApiContact() { Name = "Rich Henry", Email = "richard.henry@everi.com" }
                });

                x.OperationFilter<ChangeCaseOperationFilter>();
                x.EnableAnnotations();

                x.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                x.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });
        }

        public static void UseCustomSwagger(this IApplicationBuilder app)
        {
            //see for implementing a v2 version of our API
            //https://www.talkingdotnet.com/clean-way-to-add-swagger-asp-net-core-application/

            app.UseSwagger();
            //enables the swagger middleware to serve up the page
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Everi Helix API V1");
            });
        }
    }
}
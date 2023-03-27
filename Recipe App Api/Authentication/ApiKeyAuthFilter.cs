using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Recipe_App_Api.Authentication
{
    public class ApiKeyAuthFilter : IAuthorizationFilter
    {
        private readonly IConfiguration _configuration;

        public ApiKeyAuthFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Check if header contains "X-Api-Key"
            if (!context.HttpContext.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName, out var extactedApiKey))
            {
                context.Result = new UnauthorizedObjectResult("Api Key Missing");
                return;
            }

            var apiKey = _configuration.GetValue<string>(AuthConstants.ApiKeySectionName);

            // Check if Api key is valid
            if (!apiKey.Equals(extactedApiKey))
            {
                context.Result = new UnauthorizedObjectResult("Invalid Api Key");
                return; ;
            }
        }
    }
}

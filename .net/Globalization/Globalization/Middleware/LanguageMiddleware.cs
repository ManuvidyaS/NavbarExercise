using System.Globalization;

namespace Globalization.Middleware
{
    public class LanguageMiddleware
    {
        private readonly RequestDelegate _next;

        public LanguageMiddleware(RequestDelegate next)

        {

            _next = next;

        }

        public async Task InvokeAsync(HttpContext context)

        {

            var cultureQuery = context.Request.Query["culture"];

            if (!string.IsNullOrEmpty(cultureQuery))

            {

                var culture = new CultureInfo(cultureQuery);

                CultureInfo.CurrentCulture = culture;

                CultureInfo.CurrentUICulture = culture;

            }

            // Call the next delegate/middleware in the pipeline

            await _next(context);

        }
    }
}

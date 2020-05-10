using Microsoft.AspNetCore.Http;

namespace Datting.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse responde, string message)
        {
            responde.Headers.Add("ApplicationError", message);
            responde.Headers.Add("Acess-Control-Expose-Headers","ApplicationError");
            responde.Headers.Add("Acess-Control-Allow-Origin", "*");
        }
    }
}
using System.Net;
using System.Web;

namespace UniversalConverter.Web
{
    public class HttpHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.StatusCode = (int) HttpStatusCode.OK;
        }

        public bool IsReusable { get; private set; }
    }
}
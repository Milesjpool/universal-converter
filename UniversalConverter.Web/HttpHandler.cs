using Nancy;

namespace UniversalConverter.Web
{
    public class HttpHandler : NancyModule
    {
        public HttpHandler()
        {
            Get["/"] = _ => HttpStatusCode.OK;
            Get["/convert/{input}"] = parameters => parameters.Input;
        }
    }
}
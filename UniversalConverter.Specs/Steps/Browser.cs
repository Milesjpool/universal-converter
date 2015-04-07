using System;
using System.Net;

namespace UniversalConverter.Specs.Steps
{
    internal class Browser
    {
        public WebResponse GetResponseFromUrl(Uri url)
        {
            var webRequest = WebRequest.Create(url);
            return webRequest.GetResponse();
        }
    }
}
using System;
using System.Net;
using NUnit.Framework;

namespace UniversalConverter.Specs.Steps
{
    public class WalkingSkeletonStepsDriver
    {
        private WebResponse _webResponse;
        private readonly Browser _browser = new Browser();

        public void NavigateToRoot()
        {
            var uri = new Uri("Http://universal-converter.local/");
            _webResponse = _browser.GetResponseFromUrl(uri);

        }

        public void AssertStatusCodeIsOk()
        {
            var httpResponse = (HttpWebResponse) _webResponse;
            Assert.That(httpResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }   
    }
}
using System;
using System.IO;
using System.Net;
using NUnit.Framework;
using Nancy;

namespace UniversalConverter.Specs.Steps
{
    internal class ConversionStepsDriver
    {
        private WebResponse _webResponse;
        private readonly Browser _browser = new Browser();

        public void NavigateToConvert(string conversionInput)
        {
            var conversionUrl = new Uri("http://universal-converter.local/convert/" + conversionInput);
            _webResponse = _browser.GetResponseFromUrl(conversionUrl);
        }

        public void AssertConvertedInputEquals(string expectedOutput)
        {
            var responseStream = _webResponse.GetResponseStream();
            var streamReader = new StreamReader(responseStream);
            var actualOutput = streamReader.ReadToEnd();
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
    }
}
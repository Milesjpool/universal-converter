using System;
using System.Net;
using NUnit.Framework;

namespace UniversalConverter.Tests
{
	[TestFixture]
    public class WalkingSkeleton
    {
		[Test]
		public void Should_get_an_okay_response_from_the_server()
		{
			var uri = new Uri("Http://universal-converter.local/");
			var webRequest = WebRequest.Create(uri);
			var webResponse = (HttpWebResponse) webRequest.GetResponse();
			Assert.That(webResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
		}

	}
}
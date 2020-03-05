using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Setup
{
	public class RestartClusterPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:30")]
		public void Line30()
		{
			// tag::1cd3b9d65576a9212eef898eb3105758[]
			var response0 = new SearchResponse<object>();
			// end::1cd3b9d65576a9212eef898eb3105758[]

			response0.MatchesExample(@"PUT _cluster/settings
			{
			  ""persistent"": {
			    ""cluster.routing.allocation.enable"": ""primaries""
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:30")]
		public void Line30() // Manually changed due to: https://github.com/elastic/docs/issues/1760
		{
			// tag::f27c28ddbf4c266b5f42d14da837b8de[]
			var response0 = new SearchResponse<object>();
			// end::f27c28ddbf4c266b5f42d14da837b8de[]

			response0.MatchesExample(@"POST /_flush");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:50")]
		public void Line50()
		{
			// tag::a21a7bf052b41f5b996dc58f7b69770f[]
			var response0 = new SearchResponse<object>();
			// end::a21a7bf052b41f5b996dc58f7b69770f[]

			response0.MatchesExample(@"POST _ml/set_upgrade_mode?enabled=true");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:89")]
		public void Line89()
		{
			// tag::c0a4b0c1c6eff14da8b152ceb19c1c31[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::c0a4b0c1c6eff14da8b152ceb19c1c31[]

			response0.MatchesExample(@"GET _cat/health");

			response1.MatchesExample(@"GET _cat/nodes");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:123")]
		public void Line123()
		{
			// tag::45ef5156dbd2d3fd4fd22b8d99f7aad4[]
			var response0 = new SearchResponse<object>();
			// end::45ef5156dbd2d3fd4fd22b8d99f7aad4[]

			response0.MatchesExample(@"PUT _cluster/settings
			{
			  ""persistent"": {
			    ""cluster.routing.allocation.enable"": null
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:143")]
		public void Line143()
		{
			// tag::2d9b30acd6b5683f39d53494c0dd779c[]
			var response0 = new SearchResponse<object>();

			var response1 = new SearchResponse<object>();
			// end::2d9b30acd6b5683f39d53494c0dd779c[]

			response0.MatchesExample(@"GET _cat/health");

			response1.MatchesExample(@"GET _cat/recovery");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:158")]
		public void Line158()
		{
			// tag::3c5d5a5c34a62724942329658c688f5e[]
			var response0 = new SearchResponse<object>();
			// end::3c5d5a5c34a62724942329658c688f5e[]

			response0.MatchesExample(@"POST _ml/set_upgrade_mode?enabled=false");
		}

		[U(Skip = "Example not implemented")]
		[Description("setup/restart-cluster.asciidoc:204")]
		public void Line204()
		{
			// tag::7e49705769c42895fb7b1e2ca028ff47[]
			var response0 = new SearchResponse<object>();
			// end::7e49705769c42895fb7b1e2ca028ff47[]

			response0.MatchesExample(@"GET _cat/nodes");
		}
	}
}
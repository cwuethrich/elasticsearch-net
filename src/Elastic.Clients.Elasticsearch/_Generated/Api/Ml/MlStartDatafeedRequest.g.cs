// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlStartDatafeedRequestParameters : RequestParameters<MlStartDatafeedRequestParameters>
	{
	}

	public partial class MlStartDatafeedRequest : PlainRequestBase<MlStartDatafeedRequestParameters>
	{
		public MlStartDatafeedRequest(Elastic.Clients.Elasticsearch.Id datafeed_id) : base(r => r.Required("datafeed_id", datafeed_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningStartDatafeed;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("end")]
		public DateTimeOffset? End { get; set; }

		[JsonInclude]
		[JsonPropertyName("start")]
		public DateTimeOffset? Start { get; set; }

		[JsonInclude]
		[JsonPropertyName("timeout")]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get; set; }
	}

	public sealed partial class MlStartDatafeedRequestDescriptor : RequestDescriptorBase<MlStartDatafeedRequestDescriptor, MlStartDatafeedRequestParameters>
	{
		internal MlStartDatafeedRequestDescriptor(Action<MlStartDatafeedRequestDescriptor> configure) => configure.Invoke(this);
		public MlStartDatafeedRequestDescriptor(Elastic.Clients.Elasticsearch.Id datafeed_id) : base(r => r.Required("datafeed_id", datafeed_id))
		{
		}

		internal MlStartDatafeedRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningStartDatafeed;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlStartDatafeedRequestDescriptor DatafeedId(Elastic.Clients.Elasticsearch.Id datafeed_id)
		{
			RouteValues.Required("datafeed_id", datafeed_id);
			return Self;
		}

		private DateTimeOffset? EndValue { get; set; }

		private DateTimeOffset? StartValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? TimeoutValue { get; set; }

		public MlStartDatafeedRequestDescriptor End(DateTimeOffset? end)
		{
			EndValue = end;
			return Self;
		}

		public MlStartDatafeedRequestDescriptor Start(DateTimeOffset? start)
		{
			StartValue = start;
			return Self;
		}

		public MlStartDatafeedRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout)
		{
			TimeoutValue = timeout;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (EndValue is not null)
			{
				writer.WritePropertyName("end");
				JsonSerializer.Serialize(writer, EndValue, options);
			}

			if (StartValue is not null)
			{
				writer.WritePropertyName("start");
				JsonSerializer.Serialize(writer, StartValue, options);
			}

			if (TimeoutValue is not null)
			{
				writer.WritePropertyName("timeout");
				JsonSerializer.Serialize(writer, TimeoutValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class SpanFirstQuery : QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "span_first";
		[JsonIgnore]
		string ISpanQueryVariant.SpanQueryVariantName => "span_first";
		[JsonInclude]
		[JsonPropertyName("end")]
		public int End { get; set; }

		[JsonInclude]
		[JsonPropertyName("match")]
		public Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery Match { get; set; }
	}

	public sealed partial class SpanFirstQueryDescriptor<TDocument> : SerializableDescriptorBase<SpanFirstQueryDescriptor<TDocument>>
	{
		internal SpanFirstQueryDescriptor(Action<SpanFirstQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SpanFirstQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery MatchValue { get; set; }

		private SpanQueryDescriptor<TDocument> MatchDescriptor { get; set; }

		private Action<SpanQueryDescriptor<TDocument>> MatchDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private int EndValue { get; set; }

		public SpanFirstQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery match)
		{
			MatchDescriptor = null;
			MatchDescriptorAction = null;
			MatchValue = match;
			return Self;
		}

		public SpanFirstQueryDescriptor<TDocument> Match(SpanQueryDescriptor<TDocument> descriptor)
		{
			MatchValue = null;
			MatchDescriptorAction = null;
			MatchDescriptor = descriptor;
			return Self;
		}

		public SpanFirstQueryDescriptor<TDocument> Match(Action<SpanQueryDescriptor<TDocument>> configure)
		{
			MatchValue = null;
			MatchDescriptor = null;
			MatchDescriptorAction = configure;
			return Self;
		}

		public SpanFirstQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanFirstQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanFirstQueryDescriptor<TDocument> End(int end)
		{
			EndValue = end;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MatchDescriptor is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchDescriptor, options);
			}
			else if (MatchDescriptorAction is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, new SpanQueryDescriptor<TDocument>(MatchDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("end");
			writer.WriteNumberValue(EndValue);
			writer.WriteEndObject();
		}
	}

	public sealed partial class SpanFirstQueryDescriptor : SerializableDescriptorBase<SpanFirstQueryDescriptor>
	{
		internal SpanFirstQueryDescriptor(Action<SpanFirstQueryDescriptor> configure) => configure.Invoke(this);
		public SpanFirstQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery MatchValue { get; set; }

		private SpanQueryDescriptor MatchDescriptor { get; set; }

		private Action<SpanQueryDescriptor> MatchDescriptorAction { get; set; }

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private int EndValue { get; set; }

		public SpanFirstQueryDescriptor Match(Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery match)
		{
			MatchDescriptor = null;
			MatchDescriptorAction = null;
			MatchValue = match;
			return Self;
		}

		public SpanFirstQueryDescriptor Match(SpanQueryDescriptor descriptor)
		{
			MatchValue = null;
			MatchDescriptorAction = null;
			MatchDescriptor = descriptor;
			return Self;
		}

		public SpanFirstQueryDescriptor Match(Action<SpanQueryDescriptor> configure)
		{
			MatchValue = null;
			MatchDescriptor = null;
			MatchDescriptorAction = configure;
			return Self;
		}

		public SpanFirstQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanFirstQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanFirstQueryDescriptor End(int end)
		{
			EndValue = end;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MatchDescriptor is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchDescriptor, options);
			}
			else if (MatchDescriptorAction is not null)
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, new SpanQueryDescriptor(MatchDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("match");
				JsonSerializer.Serialize(writer, MatchValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("end");
			writer.WriteNumberValue(EndValue);
			writer.WriteEndObject();
		}
	}
}
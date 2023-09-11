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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

internal sealed class BucketSortAggregationConverter : JsonConverter<BucketSortAggregation>
{
	public override BucketSortAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "bucket_sort")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new BucketSortAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("from"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.From = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("gap_policy"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GapPolicy?>(ref reader, options);
					if (value is not null)
					{
						agg.GapPolicy = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("size"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<int?>(ref reader, options);
					if (value is not null)
					{
						agg.Size = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("sort"))
				{
					reader.Read();
					var value = SingleOrManySerializationHelper.Deserialize<Elastic.Clients.Elasticsearch.SortOptions>(ref reader, options);
					if (value is not null)
					{
						agg.Sort = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, BucketSortAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("bucket_sort");
		writer.WriteStartObject();
		if (value.From.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(value.From.Value);
		}

		if (value.GapPolicy is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, value.GapPolicy, options);
		}

		if (value.Size.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(value.Size.Value);
		}

		if (value.Sort is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(value.Sort, writer, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(BucketSortAggregationConverter))]
public sealed partial class BucketSortAggregation : SearchAggregation
{
	public BucketSortAggregation(string name) => Name = name;

	internal BucketSortAggregation()
	{
	}

	/// <summary>
	/// <para>Buckets in positions prior to `from` will be truncated.</para>
	/// </summary>
	public int? From { get; set; }

	/// <summary>
	/// <para>The policy to apply when gaps are found in the data.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicy { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>The number of buckets to return.<br/>Defaults to all buckets of the parent aggregation.</para>
	/// </summary>
	public int? Size { get; set; }

	/// <summary>
	/// <para>The list of fields to sort on.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.SortOptions>? Sort { get; set; }
}

public sealed partial class BucketSortAggregationDescriptor<TDocument> : SerializableDescriptor<BucketSortAggregationDescriptor<TDocument>>
{
	internal BucketSortAggregationDescriptor(Action<BucketSortAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public BucketSortAggregationDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private SortOptionsDescriptor<TDocument> SortDescriptor { get; set; }
	private Action<SortOptionsDescriptor<TDocument>> SortDescriptorAction { get; set; }
	private Action<SortOptionsDescriptor<TDocument>>[] SortDescriptorActions { get; set; }
	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? SizeValue { get; set; }

	/// <summary>
	/// <para>The list of fields to sort on.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Sort(SortOptionsDescriptor<TDocument> descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Sort(Action<SortOptionsDescriptor<TDocument>> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Sort(params Action<SortOptionsDescriptor<TDocument>>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Buckets in positions prior to `from` will be truncated.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> From(int? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>The policy to apply when gaps are found in the data.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public BucketSortAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets to return.<br/>Defaults to all buckets of the parent aggregation.</para>
	/// </summary>
	public BucketSortAggregationDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("bucket_sort");
		writer.WriteStartObject();
		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new SortOptionsDescriptor<TDocument>(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new SortOptionsDescriptor<TDocument>(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (FromValue.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(FromValue.Value);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class BucketSortAggregationDescriptor : SerializableDescriptor<BucketSortAggregationDescriptor>
{
	internal BucketSortAggregationDescriptor(Action<BucketSortAggregationDescriptor> configure) => configure.Invoke(this);

	public BucketSortAggregationDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.SortOptions>? SortValue { get; set; }
	private SortOptionsDescriptor SortDescriptor { get; set; }
	private Action<SortOptionsDescriptor> SortDescriptorAction { get; set; }
	private Action<SortOptionsDescriptor>[] SortDescriptorActions { get; set; }
	private int? FromValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private int? SizeValue { get; set; }

	/// <summary>
	/// <para>The list of fields to sort on.</para>
	/// </summary>
	public BucketSortAggregationDescriptor Sort(ICollection<Elastic.Clients.Elasticsearch.SortOptions>? sort)
	{
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortValue = sort;
		return Self;
	}

	public BucketSortAggregationDescriptor Sort(SortOptionsDescriptor descriptor)
	{
		SortValue = null;
		SortDescriptorAction = null;
		SortDescriptorActions = null;
		SortDescriptor = descriptor;
		return Self;
	}

	public BucketSortAggregationDescriptor Sort(Action<SortOptionsDescriptor> configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorActions = null;
		SortDescriptorAction = configure;
		return Self;
	}

	public BucketSortAggregationDescriptor Sort(params Action<SortOptionsDescriptor>[] configure)
	{
		SortValue = null;
		SortDescriptor = null;
		SortDescriptorAction = null;
		SortDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Buckets in positions prior to `from` will be truncated.</para>
	/// </summary>
	public BucketSortAggregationDescriptor From(int? from)
	{
		FromValue = from;
		return Self;
	}

	/// <summary>
	/// <para>The policy to apply when gaps are found in the data.</para>
	/// </summary>
	public BucketSortAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
	{
		GapPolicyValue = gapPolicy;
		return Self;
	}

	public BucketSortAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The number of buckets to return.<br/>Defaults to all buckets of the parent aggregation.</para>
	/// </summary>
	public BucketSortAggregationDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("bucket_sort");
		writer.WriteStartObject();
		if (SortDescriptor is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, SortDescriptor, options);
		}
		else if (SortDescriptorAction is not null)
		{
			writer.WritePropertyName("sort");
			JsonSerializer.Serialize(writer, new SortOptionsDescriptor(SortDescriptorAction), options);
		}
		else if (SortDescriptorActions is not null)
		{
			writer.WritePropertyName("sort");
			if (SortDescriptorActions.Length > 1)
				writer.WriteStartArray();
			foreach (var action in SortDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new SortOptionsDescriptor(action), options);
			}

			if (SortDescriptorActions.Length > 1)
				writer.WriteEndArray();
		}
		else if (SortValue is not null)
		{
			writer.WritePropertyName("sort");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.SortOptions>(SortValue, writer, options);
		}

		if (FromValue.HasValue)
		{
			writer.WritePropertyName("from");
			writer.WriteNumberValue(FromValue.Value);
		}

		if (GapPolicyValue is not null)
		{
			writer.WritePropertyName("gap_policy");
			JsonSerializer.Serialize(writer, GapPolicyValue, options);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}
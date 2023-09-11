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

internal sealed class MatrixStatsAggregationConverter : JsonConverter<MatrixStatsAggregation>
{
	public override MatrixStatsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "matrix_stats")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new MatrixStatsAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("fields"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fields?>(ref reader, options);
					if (value is not null)
					{
						agg.Fields = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<IDictionary<Elastic.Clients.Elasticsearch.Field, double>?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("mode"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SortMode?>(ref reader, options);
					if (value is not null)
					{
						agg.Mode = value;
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

	public override void Write(Utf8JsonWriter writer, MatrixStatsAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("matrix_stats");
		writer.WriteStartObject();
		if (value.Fields is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, value.Fields, options);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.Mode is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, value.Mode, options);
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

[JsonConverter(typeof(MatrixStatsAggregationConverter))]
public sealed partial class MatrixStatsAggregation : SearchAggregation
{
	public MatrixStatsAggregation(string name) => Name = name;

	internal MatrixStatsAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	public IDictionary<Elastic.Clients.Elasticsearch.Field, double>? Missing { get; set; }

	/// <summary>
	/// <para>Array value the aggregation will use for array or multi-valued fields.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.SortMode? Mode { get; set; }
	override public string? Name { get; internal set; }
}

public sealed partial class MatrixStatsAggregationDescriptor<TDocument> : SerializableDescriptor<MatrixStatsAggregationDescriptor<TDocument>>
{
	internal MatrixStatsAggregationDescriptor(Action<MatrixStatsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MatrixStatsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, double>? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }

	public MatrixStatsAggregationDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public MatrixStatsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MatrixStatsAggregationDescriptor<TDocument> Missing(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>> selector)
	{
		MissingValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>());
		return Self;
	}

	/// <summary>
	/// <para>Array value the aggregation will use for array or multi-valued fields.</para>
	/// </summary>
	public MatrixStatsAggregationDescriptor<TDocument> Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("matrix_stats");
		writer.WriteStartObject();
		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
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

public sealed partial class MatrixStatsAggregationDescriptor : SerializableDescriptor<MatrixStatsAggregationDescriptor>
{
	internal MatrixStatsAggregationDescriptor(Action<MatrixStatsAggregationDescriptor> configure) => configure.Invoke(this);

	public MatrixStatsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, double>? MissingValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortMode? ModeValue { get; set; }

	public MatrixStatsAggregationDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public MatrixStatsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public MatrixStatsAggregationDescriptor Missing(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>> selector)
	{
		MissingValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, double>());
		return Self;
	}

	/// <summary>
	/// <para>Array value the aggregation will use for array or multi-valued fields.</para>
	/// </summary>
	public MatrixStatsAggregationDescriptor Mode(Elastic.Clients.Elasticsearch.SortMode? mode)
	{
		ModeValue = mode;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("matrix_stats");
		writer.WriteStartObject();
		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ModeValue is not null)
		{
			writer.WritePropertyName("mode");
			JsonSerializer.Serialize(writer, ModeValue, options);
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
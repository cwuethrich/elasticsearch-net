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
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.QueryDsl;

[JsonConverter(typeof(IntervalsQueryConverter))]
public sealed partial class IntervalsQuery
{
	internal IntervalsQuery(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static IntervalsQuery AllOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf intervalsAllOf) => new IntervalsQuery("all_of", intervalsAllOf);
	public static IntervalsQuery AnyOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf intervalsAnyOf) => new IntervalsQuery("any_of", intervalsAnyOf);
	public static IntervalsQuery Fuzzy(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy intervalsFuzzy) => new IntervalsQuery("fuzzy", intervalsFuzzy);
	public static IntervalsQuery Match(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch intervalsMatch) => new IntervalsQuery("match", intervalsMatch);
	public static IntervalsQuery Prefix(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix intervalsPrefix) => new IntervalsQuery("prefix", intervalsPrefix);
	public static IntervalsQuery Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard intervalsWildcard) => new IntervalsQuery("wildcard", intervalsWildcard);

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class IntervalsQueryConverter : JsonConverter<IntervalsQuery>
{
	public override IntervalsQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		object? variantValue = default;
		string? variantNameValue = default;
		float? boostValue = default;
		string? queryNameValue = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token.");
			}

			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the name of an Elasticsearch field.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "boost")
			{
				boostValue = JsonSerializer.Deserialize<float?>(ref reader, options);
				continue;
			}

			if (propertyName == "_name")
			{
				queryNameValue = JsonSerializer.Deserialize<string?>(ref reader, options);
				continue;
			}

			if (propertyName == "all_of")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "any_of")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "fuzzy")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "match")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "prefix")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "wildcard")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'IntervalsQuery' from the response.");
		}

		reader.Read();
		var result = new IntervalsQuery(variantNameValue, variantValue);
		result.Boost = boostValue;
		result.Field = fieldName;
		result.QueryName = queryNameValue;
		return result;
	}

	public override void Write(Utf8JsonWriter writer, IntervalsQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize IntervalsQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (!options.TryGetClientSettings(out var settings))
			throw new JsonException("Unable to retrieve client settings required to infer field.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(value.Field));
		writer.WriteStartObject();
		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "all_of":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf)value.Variant, options);
					break;
				case "any_of":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf)value.Variant, options);
					break;
				case "fuzzy":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy)value.Variant, options);
					break;
				case "match":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch)value.Variant, options);
					break;
				case "prefix":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix)value.Variant, options);
					break;
				case "wildcard":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class IntervalsQueryDescriptor<TDocument> : SerializableDescriptor<IntervalsQueryDescriptor<TDocument>>
{
	internal IntervalsQueryDescriptor(Action<IntervalsQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public IntervalsQueryDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private IntervalsQueryDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private IntervalsQueryDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public IntervalsQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public IntervalsQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public IntervalsQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public IntervalsQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public IntervalsQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public IntervalsQueryDescriptor<TDocument> AllOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf intervalsAllOf) => Set(intervalsAllOf, "all_of");
	public IntervalsQueryDescriptor<TDocument> AllOf(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOfDescriptor<TDocument>> configure) => Set(configure, "all_of");
	public IntervalsQueryDescriptor<TDocument> AnyOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf intervalsAnyOf) => Set(intervalsAnyOf, "any_of");
	public IntervalsQueryDescriptor<TDocument> AnyOf(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOfDescriptor<TDocument>> configure) => Set(configure, "any_of");
	public IntervalsQueryDescriptor<TDocument> Fuzzy(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy intervalsFuzzy) => Set(intervalsFuzzy, "fuzzy");
	public IntervalsQueryDescriptor<TDocument> Fuzzy(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzyDescriptor<TDocument>> configure) => Set(configure, "fuzzy");
	public IntervalsQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch intervalsMatch) => Set(intervalsMatch, "match");
	public IntervalsQueryDescriptor<TDocument> Match(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatchDescriptor<TDocument>> configure) => Set(configure, "match");
	public IntervalsQueryDescriptor<TDocument> Prefix(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix intervalsPrefix) => Set(intervalsPrefix, "prefix");
	public IntervalsQueryDescriptor<TDocument> Prefix(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefixDescriptor<TDocument>> configure) => Set(configure, "prefix");
	public IntervalsQueryDescriptor<TDocument> Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard intervalsWildcard) => Set(intervalsWildcard, "wildcard");
	public IntervalsQueryDescriptor<TDocument> Wildcard(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcardDescriptor<TDocument>> configure) => Set(configure, "wildcard");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class IntervalsQueryDescriptor : SerializableDescriptor<IntervalsQueryDescriptor>
{
	internal IntervalsQueryDescriptor(Action<IntervalsQueryDescriptor> configure) => configure.Invoke(this);

	public IntervalsQueryDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private IntervalsQueryDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private IntervalsQueryDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public IntervalsQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public IntervalsQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public IntervalsQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public IntervalsQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public IntervalsQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public IntervalsQueryDescriptor AllOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf intervalsAllOf) => Set(intervalsAllOf, "all_of");
	public IntervalsQueryDescriptor AllOf<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOfDescriptor> configure) => Set(configure, "all_of");
	public IntervalsQueryDescriptor AnyOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf intervalsAnyOf) => Set(intervalsAnyOf, "any_of");
	public IntervalsQueryDescriptor AnyOf<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOfDescriptor> configure) => Set(configure, "any_of");
	public IntervalsQueryDescriptor Fuzzy(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy intervalsFuzzy) => Set(intervalsFuzzy, "fuzzy");
	public IntervalsQueryDescriptor Fuzzy<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzyDescriptor> configure) => Set(configure, "fuzzy");
	public IntervalsQueryDescriptor Match(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch intervalsMatch) => Set(intervalsMatch, "match");
	public IntervalsQueryDescriptor Match<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatchDescriptor> configure) => Set(configure, "match");
	public IntervalsQueryDescriptor Prefix(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix intervalsPrefix) => Set(intervalsPrefix, "prefix");
	public IntervalsQueryDescriptor Prefix<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefixDescriptor> configure) => Set(configure, "prefix");
	public IntervalsQueryDescriptor Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard intervalsWildcard) => Set(intervalsWildcard, "wildcard");
	public IntervalsQueryDescriptor Wildcard<TDocument>(Action<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcardDescriptor> configure) => Set(configure, "wildcard");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}
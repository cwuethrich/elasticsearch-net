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

namespace Elastic.Clients.Elasticsearch.QueryDsl;

internal sealed partial class GeoBoundingBoxQueryConverter : JsonConverter<GeoBoundingBoxQuery>
{
	public override GeoBoundingBoxQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		var variant = new GeoBoundingBoxQuery();
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				if (property == "ignore_unmapped")
				{
					variant.IgnoreUnmapped = JsonSerializer.Deserialize<bool?>(ref reader, options);
					continue;
				}

				if (property == "validation_method")
				{
					variant.ValidationMethod = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod?>(ref reader, options);
					continue;
				}

				variant.Field = property;
				reader.Read();
				variant.BoundingBox = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.GeoBounds>(ref reader, options);
			}
		}

		return variant;
	}

	public override void Write(Utf8JsonWriter writer, GeoBoundingBoxQuery value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.Field is not null && value.BoundingBox is not null)
		{
			if (!options.TryGetClientSettings(out var settings))
			{
				ThrowHelper.ThrowJsonExceptionForMissingSettings();
			}

			var propertyName = settings.Inferrer.Field(value.Field);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, value.BoundingBox, options);
		}

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		if (value.IgnoreUnmapped.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(value.IgnoreUnmapped.Value);
		}

		if (value.ValidationMethod is not null)
		{
			writer.WritePropertyName("validation_method");
			JsonSerializer.Serialize(writer, value.ValidationMethod, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(GeoBoundingBoxQueryConverter))]
public sealed partial class GeoBoundingBoxQuery : SearchQuery
{
	public string? QueryName { get; set; }
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.GeoBounds BoundingBox { get; set; }
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	/// <summary>
	/// <para>Set to `true` to ignore an unmapped field and not match any documents for this query.<br/>Set to `false` to throw an exception if the field is not mapped.</para>
	/// </summary>
	public bool? IgnoreUnmapped { get; set; }

	/// <summary>
	/// <para>Set to `IGNORE_MALFORMED` to accept geo points with invalid latitude or longitude.<br/>Set to `COERCE` to also try to infer correct latitude or longitude.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethod { get; set; }

	public static implicit operator Query(GeoBoundingBoxQuery geoBoundingBoxQuery) => QueryDsl.Query.GeoBoundingBox(geoBoundingBoxQuery);

	internal override void InternalWrapInContainer(Query container) => container.WrapVariant("geo_bounding_box", this);
}

public sealed partial class GeoBoundingBoxQueryDescriptor<TDocument> : SerializableDescriptor<GeoBoundingBoxQueryDescriptor<TDocument>>
{
	internal GeoBoundingBoxQueryDescriptor(Action<GeoBoundingBoxQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GeoBoundingBoxQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethodValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeoBounds BoundingBoxValue { get; set; }

	public GeoBoundingBoxQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Set to `true` to ignore an unmapped field and not match any documents for this query.<br/>Set to `false` to throw an exception if the field is not mapped.</para>
	/// </summary>
	public GeoBoundingBoxQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	/// <summary>
	/// <para>Set to `IGNORE_MALFORMED` to accept geo points with invalid latitude or longitude.<br/>Set to `COERCE` to also try to infer correct latitude or longitude.</para>
	/// </summary>
	public GeoBoundingBoxQueryDescriptor<TDocument> ValidationMethod(Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? validationMethod)
	{
		ValidationMethodValue = validationMethod;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor<TDocument> BoundingBox(Elastic.Clients.Elasticsearch.GeoBounds boundingBox)
	{
		BoundingBoxValue = boundingBox;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && BoundingBoxValue is not null)
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, BoundingBoxValue, options);
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

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (ValidationMethodValue is not null)
		{
			writer.WritePropertyName("validation_method");
			JsonSerializer.Serialize(writer, ValidationMethodValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class GeoBoundingBoxQueryDescriptor : SerializableDescriptor<GeoBoundingBoxQueryDescriptor>
{
	internal GeoBoundingBoxQueryDescriptor(Action<GeoBoundingBoxQueryDescriptor> configure) => configure.Invoke(this);

	public GeoBoundingBoxQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }
	private float? BoostValue { get; set; }
	private bool? IgnoreUnmappedValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethodValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.GeoBounds BoundingBoxValue { get; set; }

	public GeoBoundingBoxQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Set to `true` to ignore an unmapped field and not match any documents for this query.<br/>Set to `false` to throw an exception if the field is not mapped.</para>
	/// </summary>
	public GeoBoundingBoxQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	/// <summary>
	/// <para>Set to `IGNORE_MALFORMED` to accept geo points with invalid latitude or longitude.<br/>Set to `COERCE` to also try to infer correct latitude or longitude.</para>
	/// </summary>
	public GeoBoundingBoxQueryDescriptor ValidationMethod(Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? validationMethod)
	{
		ValidationMethodValue = validationMethod;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor BoundingBox(Elastic.Clients.Elasticsearch.GeoBounds boundingBox)
	{
		BoundingBoxValue = boundingBox;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public GeoBoundingBoxQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && BoundingBoxValue is not null)
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, BoundingBoxValue, options);
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

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (ValidationMethodValue is not null)
		{
			writer.WritePropertyName("validation_method");
			JsonSerializer.Serialize(writer, ValidationMethodValue, options);
		}

		writer.WriteEndObject();
	}
}
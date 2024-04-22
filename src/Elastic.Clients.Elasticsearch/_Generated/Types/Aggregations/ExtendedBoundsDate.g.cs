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

public sealed partial class ExtendedBoundsDate
{
	/// <summary>
	/// <para>Maximum value for the bound.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max")]
	public Elastic.Clients.Elasticsearch.Aggregations.FieldDateMath? Max { get; set; }

	/// <summary>
	/// <para>Minimum value for the bound.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("min")]
	public Elastic.Clients.Elasticsearch.Aggregations.FieldDateMath? Min { get; set; }
}

public sealed partial class ExtendedBoundsDateDescriptor : SerializableDescriptor<ExtendedBoundsDateDescriptor>
{
	internal ExtendedBoundsDateDescriptor(Action<ExtendedBoundsDateDescriptor> configure) => configure.Invoke(this);

	public ExtendedBoundsDateDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.FieldDateMath? MaxValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.FieldDateMath? MinValue { get; set; }

	/// <summary>
	/// <para>Maximum value for the bound.</para>
	/// </summary>
	public ExtendedBoundsDateDescriptor Max(Elastic.Clients.Elasticsearch.Aggregations.FieldDateMath? max)
	{
		MaxValue = max;
		return Self;
	}

	/// <summary>
	/// <para>Minimum value for the bound.</para>
	/// </summary>
	public ExtendedBoundsDateDescriptor Min(Elastic.Clients.Elasticsearch.Aggregations.FieldDateMath? min)
	{
		MinValue = min;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxValue is not null)
		{
			writer.WritePropertyName("max");
			JsonSerializer.Serialize(writer, MaxValue, options);
		}

		if (MinValue is not null)
		{
			writer.WritePropertyName("min");
			JsonSerializer.Serialize(writer, MinValue, options);
		}

		writer.WriteEndObject();
	}
}
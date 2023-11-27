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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Core.MSearchTemplate;

public sealed partial class TemplateConfig
{
	/// <summary>
	/// <para>If `true`, returns detailed information about score calculation as part of each hit.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("explain")]
	public bool? Explain { get; set; }

	/// <summary>
	/// <para>ID of the search template to use. If no source is specified,<br/>this parameter is required.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Serverless.Id? Id { get; set; }

	/// <summary>
	/// <para>Key-value pairs used to replace Mustache variables in the template.<br/>The key is the variable name.<br/>The value is the variable value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }

	/// <summary>
	/// <para>If `true`, the query execution is profiled.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("profile")]
	public bool? Profile { get; set; }

	/// <summary>
	/// <para>An inline search template. Supports the same parameters as the search API's<br/>request body. Also supports Mustache variables. If no id is specified, this<br/>parameter is required.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("source")]
	public string? Source { get; set; }
}

public sealed partial class TemplateConfigDescriptor : SerializableDescriptor<TemplateConfigDescriptor>
{
	internal TemplateConfigDescriptor(Action<TemplateConfigDescriptor> configure) => configure.Invoke(this);

	public TemplateConfigDescriptor() : base()
	{
	}

	private bool? ExplainValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Id? IdValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private bool? ProfileValue { get; set; }
	private string? SourceValue { get; set; }

	/// <summary>
	/// <para>If `true`, returns detailed information about score calculation as part of each hit.</para>
	/// </summary>
	public TemplateConfigDescriptor Explain(bool? explain = true)
	{
		ExplainValue = explain;
		return Self;
	}

	/// <summary>
	/// <para>ID of the search template to use. If no source is specified,<br/>this parameter is required.</para>
	/// </summary>
	public TemplateConfigDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Key-value pairs used to replace Mustache variables in the template.<br/>The key is the variable name.<br/>The value is the variable value.</para>
	/// </summary>
	public TemplateConfigDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>If `true`, the query execution is profiled.</para>
	/// </summary>
	public TemplateConfigDescriptor Profile(bool? profile = true)
	{
		ProfileValue = profile;
		return Self;
	}

	/// <summary>
	/// <para>An inline search template. Supports the same parameters as the search API's<br/>request body. Also supports Mustache variables. If no id is specified, this<br/>parameter is required.</para>
	/// </summary>
	public TemplateConfigDescriptor Source(string? source)
	{
		SourceValue = source;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExplainValue.HasValue)
		{
			writer.WritePropertyName("explain");
			writer.WriteBooleanValue(ExplainValue.Value);
		}

		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ProfileValue.HasValue)
		{
			writer.WritePropertyName("profile");
			writer.WriteBooleanValue(ProfileValue.Value);
		}

		if (!string.IsNullOrEmpty(SourceValue))
		{
			writer.WritePropertyName("source");
			writer.WriteStringValue(SourceValue);
		}

		writer.WriteEndObject();
	}
}
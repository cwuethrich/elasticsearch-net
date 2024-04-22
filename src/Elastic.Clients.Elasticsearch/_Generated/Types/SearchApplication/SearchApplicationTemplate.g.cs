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

namespace Elastic.Clients.Elasticsearch.SearchApplication;

public sealed partial class SearchApplicationTemplate
{
	/// <summary>
	/// <para>The associated mustache template.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.InlineScript Script { get; set; }
}

public sealed partial class SearchApplicationTemplateDescriptor : SerializableDescriptor<SearchApplicationTemplateDescriptor>
{
	internal SearchApplicationTemplateDescriptor(Action<SearchApplicationTemplateDescriptor> configure) => configure.Invoke(this);

	public SearchApplicationTemplateDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.InlineScript ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.InlineScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.InlineScriptDescriptor> ScriptDescriptorAction { get; set; }

	/// <summary>
	/// <para>The associated mustache template.</para>
	/// </summary>
	public SearchApplicationTemplateDescriptor Script(Elastic.Clients.Elasticsearch.InlineScript script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public SearchApplicationTemplateDescriptor Script(Elastic.Clients.Elasticsearch.InlineScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public SearchApplicationTemplateDescriptor Script(Action<Elastic.Clients.Elasticsearch.InlineScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.InlineScriptDescriptor(ScriptDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}
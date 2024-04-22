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

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class SettingsSimilarityBoolean : ISettingsSimilarity
{
	[JsonInclude, JsonPropertyName("type")]
	public string Type => "boolean";
}

public sealed partial class SettingsSimilarityBooleanDescriptor : SerializableDescriptor<SettingsSimilarityBooleanDescriptor>, IBuildableDescriptor<SettingsSimilarityBoolean>
{
	internal SettingsSimilarityBooleanDescriptor(Action<SettingsSimilarityBooleanDescriptor> configure) => configure.Invoke(this);

	public SettingsSimilarityBooleanDescriptor() : base()
	{
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("type");
		writer.WriteStringValue("boolean");
		writer.WriteEndObject();
	}

	SettingsSimilarityBoolean IBuildableDescriptor<SettingsSimilarityBoolean>.Build() => new()
	{
	};
}
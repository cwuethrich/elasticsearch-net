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

namespace Elastic.Clients.Elasticsearch.Serverless.Snapshot;

public sealed partial class ReadOnlyUrlRepository : IRepository
{
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettings Settings { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "url";

	[JsonInclude, JsonPropertyName("uuid")]
	public string? Uuid { get; set; }
}

public sealed partial class ReadOnlyUrlRepositoryDescriptor : SerializableDescriptor<ReadOnlyUrlRepositoryDescriptor>, IBuildableDescriptor<ReadOnlyUrlRepository>
{
	internal ReadOnlyUrlRepositoryDescriptor(Action<ReadOnlyUrlRepositoryDescriptor> configure) => configure.Invoke(this);

	public ReadOnlyUrlRepositoryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettings SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettingsDescriptor> SettingsDescriptorAction { get; set; }
	private string? UuidValue { get; set; }

	public ReadOnlyUrlRepositoryDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettings settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public ReadOnlyUrlRepositoryDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public ReadOnlyUrlRepositoryDescriptor Settings(Action<Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	public ReadOnlyUrlRepositoryDescriptor Uuid(string? uuid)
	{
		UuidValue = uuid;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettingsDescriptor(SettingsDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("url");
		if (!string.IsNullOrEmpty(UuidValue))
		{
			writer.WritePropertyName("uuid");
			writer.WriteStringValue(UuidValue);
		}

		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettings BuildSettings()
	{
		if (SettingsValue is not null)
		{
			return SettingsValue;
		}

		if ((object)SettingsDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettings> buildable)
		{
			return buildable.Build();
		}

		if (SettingsDescriptorAction is not null)
		{
			var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettingsDescriptor(SettingsDescriptorAction);
			if ((object)descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Serverless.Snapshot.ReadOnlyUrlRepositorySettings> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	ReadOnlyUrlRepository IBuildableDescriptor<ReadOnlyUrlRepository>.Build() => new()
	{
		Settings = BuildSettings(),
		Uuid = UuidValue
	};
}
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

namespace Elastic.Clients.Elasticsearch.TransformManagement;

public sealed partial class Source
{
	/// <summary>
	/// <para>The source indices for the transform. It can be a single index, an index pattern (for example, `"my-index-*""`), an<br/>array of indices (for example, `["my-index-000001", "my-index-000002"]`), or an array of index patterns (for<br/>example, `["my-index-*", "my-other-index-*"]`. For remote indices use the syntax `"remote_name:index_name"`. If<br/>any indices are in remote clusters then the master node and at least one transform node must have the `remote_cluster_client` node role.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Indices Indices { get; set; }

	/// <summary>
	/// <para>A query clause that retrieves a subset of data from the source index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }

	/// <summary>
	/// <para>Definitions of search-time runtime fields that can be used by the transform. For search runtime fields all data<br/>nodes, including remote nodes, must be 7.12 or later.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("runtime_mappings")]
	public IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappings { get; set; }
}

public sealed partial class SourceDescriptor<TDocument> : SerializableDescriptor<SourceDescriptor<TDocument>>
{
	internal SourceDescriptor(Action<SourceDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SourceDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Indices IndicesValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>> RuntimeMappingsValue { get; set; }

	/// <summary>
	/// <para>The source indices for the transform. It can be a single index, an index pattern (for example, `"my-index-*""`), an<br/>array of indices (for example, `["my-index-000001", "my-index-000002"]`), or an array of index patterns (for<br/>example, `["my-index-*", "my-other-index-*"]`. For remote indices use the syntax `"remote_name:index_name"`. If<br/>any indices are in remote clusters then the master node and at least one transform node must have the `remote_cluster_client` node role.</para>
	/// </summary>
	public SourceDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		IndicesValue = indices;
		return Self;
	}

	/// <summary>
	/// <para>A query clause that retrieves a subset of data from the source index.</para>
	/// </summary>
	public SourceDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public SourceDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public SourceDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Definitions of search-time runtime fields that can be used by the transform. For search runtime fields all data<br/>nodes, including remote nodes, must be 7.12 or later.</para>
	/// </summary>
	public SourceDescriptor<TDocument> RuntimeMappings(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor<TDocument>>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("index");
		JsonSerializer.Serialize(writer, IndicesValue, options);
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SourceDescriptor : SerializableDescriptor<SourceDescriptor>
{
	internal SourceDescriptor(Action<SourceDescriptor> configure) => configure.Invoke(this);

	public SourceDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Indices IndicesValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor> RuntimeMappingsValue { get; set; }

	/// <summary>
	/// <para>The source indices for the transform. It can be a single index, an index pattern (for example, `"my-index-*""`), an<br/>array of indices (for example, `["my-index-000001", "my-index-000002"]`), or an array of index patterns (for<br/>example, `["my-index-*", "my-other-index-*"]`. For remote indices use the syntax `"remote_name:index_name"`. If<br/>any indices are in remote clusters then the master node and at least one transform node must have the `remote_cluster_client` node role.</para>
	/// </summary>
	public SourceDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		IndicesValue = indices;
		return Self;
	}

	/// <summary>
	/// <para>A query clause that retrieves a subset of data from the source index.</para>
	/// </summary>
	public SourceDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public SourceDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public SourceDescriptor Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Definitions of search-time runtime fields that can be used by the transform. For search runtime fields all data<br/>nodes, including remote nodes, must be 7.12 or later.</para>
	/// </summary>
	public SourceDescriptor RuntimeMappings(Func<FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor>, FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor>> selector)
	{
		RuntimeMappingsValue = selector?.Invoke(new FluentDescriptorDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldDescriptor>());
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("index");
		JsonSerializer.Serialize(writer, IndicesValue, options);
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (RuntimeMappingsValue is not null)
		{
			writer.WritePropertyName("runtime_mappings");
			JsonSerializer.Serialize(writer, RuntimeMappingsValue, options);
		}

		writer.WriteEndObject();
	}
}
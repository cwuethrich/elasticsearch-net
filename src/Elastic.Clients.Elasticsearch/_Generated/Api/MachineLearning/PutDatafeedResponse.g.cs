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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class PutDatafeedResponse : ElasticsearchResponse
{
	[JsonInclude, JsonPropertyName("aggregations")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Aggregations.Aggregation>? Aggregations { get; init; }
	[JsonInclude, JsonPropertyName("authorization")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DatafeedAuthorization? Authorization { get; init; }
	[JsonInclude, JsonPropertyName("chunking_config")]
	public Elastic.Clients.Elasticsearch.MachineLearning.ChunkingConfig ChunkingConfig { get; init; }
	[JsonInclude, JsonPropertyName("datafeed_id")]
	public string DatafeedId { get; init; }
	[JsonInclude, JsonPropertyName("delayed_data_check_config")]
	public Elastic.Clients.Elasticsearch.MachineLearning.DelayedDataCheckConfig? DelayedDataCheckConfig { get; init; }
	[JsonInclude, JsonPropertyName("frequency")]
	public Elastic.Clients.Elasticsearch.Duration? Frequency { get; init; }
	[JsonInclude, JsonPropertyName("indices")]
	public IReadOnlyCollection<string> Indices { get; init; }
	[JsonInclude, JsonPropertyName("indices_options")]
	public Elastic.Clients.Elasticsearch.IndicesOptions? IndicesOptions { get; init; }
	[JsonInclude, JsonPropertyName("job_id")]
	public string JobId { get; init; }
	[JsonInclude, JsonPropertyName("max_empty_searches")]
	public int? MaxEmptySearches { get; init; }
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query Query { get; init; }
	[JsonInclude, JsonPropertyName("query_delay")]
	public Elastic.Clients.Elasticsearch.Duration QueryDelay { get; init; }
	[JsonInclude, JsonPropertyName("runtime_mappings")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappings { get; init; }
	[JsonInclude, JsonPropertyName("script_fields")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; init; }
	[JsonInclude, JsonPropertyName("scroll_size")]
	public int ScrollSize { get; init; }
}
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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class DataStreamsStatsRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Type of data stream that wildcard patterns can match.<br/>Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }
}

/// <summary>
/// <para>Retrieves statistics for one or more data streams.</para>
/// </summary>
public sealed partial class DataStreamsStatsRequest : PlainRequest<DataStreamsStatsRequestParameters>
{
	public DataStreamsStatsRequest()
	{
	}

	public DataStreamsStatsRequest(Elastic.Clients.Elasticsearch.Serverless.IndexName? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementDataStreamsStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.data_streams_stats";

	/// <summary>
	/// <para>Type of data stream that wildcard patterns can match.<br/>Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }
}

/// <summary>
/// <para>Retrieves statistics for one or more data streams.</para>
/// </summary>
public sealed partial class DataStreamsStatsRequestDescriptor : RequestDescriptor<DataStreamsStatsRequestDescriptor, DataStreamsStatsRequestParameters>
{
	internal DataStreamsStatsRequestDescriptor(Action<DataStreamsStatsRequestDescriptor> configure) => configure.Invoke(this);

	public DataStreamsStatsRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.IndexName? name) : base(r => r.Optional("name", name))
	{
	}

	public DataStreamsStatsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementDataStreamsStats;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.data_streams_stats";

	public DataStreamsStatsRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);

	public DataStreamsStatsRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.IndexName? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}
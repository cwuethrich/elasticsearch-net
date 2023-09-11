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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class DocStats
{
	/// <summary>
	/// <para>Total number of non-deleted documents across all primary shards assigned to selected nodes.<br/>This number is based on documents in Lucene segments and may include documents from nested fields.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("count")]
	public long Count { get; init; }

	/// <summary>
	/// <para>Total number of deleted documents across all primary shards assigned to selected nodes.<br/>This number is based on documents in Lucene segments.<br/>Elasticsearch reclaims the disk space of deleted Lucene documents when a segment is merged.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("deleted")]
	public long? Deleted { get; init; }
}
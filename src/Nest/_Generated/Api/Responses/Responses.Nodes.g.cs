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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Nodes
{
	public partial class HotThreadsResponse : ResponseBase
	{
		[JsonPropertyName("hot_threads")]
		public IReadOnlyCollection<Nest.Nodes.HotThreads.HotThread> HotThreads
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InfoResponse : NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Nest.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.Nodes.Info.NodeInfo> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ReloadSecureSettingsResponse : NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Nest.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Union<Nest.Nodes.Stats, Nest.Nodes.ReloadSecureSettings.NodeReloadException>> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class StatsResponse : NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Nest.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.Nodes.Stats> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class UsageResponse : NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Nest.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Nest.Nodes.Usage.NodeUsage> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}
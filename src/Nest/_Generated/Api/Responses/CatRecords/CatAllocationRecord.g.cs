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

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatAllocationRecord
	{
		[JsonInclude, JsonPropertyName("da")]
		private ByteSize? _da = default;
		[JsonInclude, JsonPropertyName("di")]
		private ByteSize? _di = default;
		[JsonInclude, JsonPropertyName("disk.avail")]
		private ByteSize? _disk_avail = default;
		[JsonInclude, JsonPropertyName("disk.indices")]
		private ByteSize? _disk_indices = default;
		[JsonInclude, JsonPropertyName("disk.percent")]
		private Percentage? _disk_percent = default;
		[JsonInclude, JsonPropertyName("disk.total")]
		private ByteSize? _disk_total = default;
		[JsonInclude, JsonPropertyName("disk.used")]
		private ByteSize? _disk_used = default;
		[JsonInclude, JsonPropertyName("diskAvail")]
		private ByteSize? _diskAvail = default;
		[JsonInclude, JsonPropertyName("diskIndices")]
		private ByteSize? _diskIndices = default;
		[JsonInclude, JsonPropertyName("diskPercent")]
		private Percentage? _diskPercent = default;
		[JsonInclude, JsonPropertyName("diskTotal")]
		private ByteSize? _diskTotal = default;
		[JsonInclude, JsonPropertyName("diskUsed")]
		private ByteSize? _diskUsed = default;
		[JsonInclude, JsonPropertyName("dp")]
		private Percentage? _dp = default;
		[JsonInclude, JsonPropertyName("dt")]
		private ByteSize? _dt = default;
		[JsonInclude, JsonPropertyName("du")]
		private ByteSize? _du = default;
		[JsonInclude, JsonPropertyName("h")]
		private string? _h = default;
		[JsonInclude, JsonPropertyName("host")]
		private string? _host = default;
		[JsonInclude, JsonPropertyName("n")]
		private string? _n = default;
		[JsonInclude, JsonPropertyName("node")]
		private string? _node = default;
		[JsonInclude, JsonPropertyName("s")]
		private string? _s = default;
		[JsonInclude, JsonPropertyName("shards")]
		private string? _shards = default;
		public ByteSize? DiskAvail => _disk_avail ?? _da ?? _diskAvail;
		public ByteSize? DiskIndices => _disk_indices ?? _di ?? _diskIndices;
		public Percentage? DiskPercent => _disk_percent ?? _dp ?? _diskPercent;
		public ByteSize? DiskTotal => _disk_total ?? _dt ?? _diskTotal;
		public ByteSize? DiskUsed => _disk_used ?? _du ?? _diskUsed;
		public string? Host => _h ?? _host;
		[JsonPropertyName("ip")]
		public string? Ip
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? Node => _n ?? _node;
		public string? Shards => _s ?? _shards;
	}
}
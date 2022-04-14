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

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Migration
{
	public class MigrationNamespace : NamespacedClientProxy
	{
		internal MigrationNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public MigrationDeprecationsResponse Deprecations(MigrationDeprecationsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<MigrationDeprecationsRequest, MigrationDeprecationsResponse>(request);
		}

		public Task<MigrationDeprecationsResponse> DeprecationsAsync(MigrationDeprecationsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<MigrationDeprecationsRequest, MigrationDeprecationsResponse>(request, cancellationToken);
		}

		public MigrationDeprecationsResponse Deprecations(Action<MigrationDeprecationsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new MigrationDeprecationsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<MigrationDeprecationsRequestDescriptor, MigrationDeprecationsResponse>(descriptor);
		}

		public Task<MigrationDeprecationsResponse> DeprecationsAsync(Action<MigrationDeprecationsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new MigrationDeprecationsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<MigrationDeprecationsRequestDescriptor, MigrationDeprecationsResponse>(descriptor);
		}
	}
}
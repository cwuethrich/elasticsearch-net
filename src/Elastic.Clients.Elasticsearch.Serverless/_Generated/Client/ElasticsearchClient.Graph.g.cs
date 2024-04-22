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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Graph;

public partial class GraphNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>Initializes a new instance of the <see cref="GraphNamespacedClient"/> class for mocking.</para>
	/// </summary>
	protected GraphNamespacedClient() : base()
	{
	}

	internal GraphNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync(ExploreRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ExploreRequest, ExploreResponse, ExploreRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync<TDocument>(ExploreRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor<TDocument>, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Indices indices, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExploreRequestDescriptor<TDocument>(indices);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor<TDocument>, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Indices indices, Action<ExploreRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExploreRequestDescriptor<TDocument>(indices);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor<TDocument>, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new ExploreRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor<TDocument>, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync<TDocument>(Action<ExploreRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExploreRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor<TDocument>, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync(ExploreRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync(Elastic.Clients.Elasticsearch.Serverless.Indices indices, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExploreRequestDescriptor(indices);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Explore extracted and summarized information about the documents and terms in an index.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/graph-explore-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ExploreResponse> ExploreAsync(Elastic.Clients.Elasticsearch.Serverless.Indices indices, Action<ExploreRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ExploreRequestDescriptor(indices);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ExploreRequestDescriptor, ExploreResponse, ExploreRequestParameters>(descriptor, cancellationToken);
	}
}
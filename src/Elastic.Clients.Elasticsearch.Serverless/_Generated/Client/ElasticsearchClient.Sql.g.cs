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
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Sql;

public partial class SqlNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SqlNamespacedClient"/> class for mocking.
	/// </summary>
	protected SqlNamespacedClient() : base()
	{
	}

	internal SqlNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Clears the SQL cursor</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClearCursorResponse ClearCursor(ClearCursorRequest request)
	{
		request.BeforeRequest();
		return DoRequest<ClearCursorRequest, ClearCursorResponse, ClearCursorRequestParameters>(request);
	}

	/// <summary>
	/// <para>Clears the SQL cursor</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(ClearCursorRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ClearCursorRequest, ClearCursorResponse, ClearCursorRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Clears the SQL cursor</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClearCursorResponse ClearCursor(ClearCursorRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Clears the SQL cursor</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClearCursorResponse ClearCursor(Action<ClearCursorRequestDescriptor> configureRequest)
	{
		var descriptor = new ClearCursorRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Clears the SQL cursor</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(ClearCursorRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Clears the SQL cursor</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/clear-sql-cursor-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClearCursorResponse> ClearCursorAsync(Action<ClearCursorRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ClearCursorRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ClearCursorRequestDescriptor, ClearCursorResponse, ClearCursorRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncResponse DeleteAsyncSearch(DeleteAsyncRequest request)
	{
		request.BeforeRequest();
		return DoRequest<DeleteAsyncRequest, DeleteAsyncResponse, DeleteAsyncRequestParameters>(request);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncSearchAsync(DeleteAsyncRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequest, DeleteAsyncResponse, DeleteAsyncRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncResponse DeleteAsyncSearch(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		var descriptor = new DeleteAsyncRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncResponse DeleteAsyncSearch(DeleteAsyncRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncResponse DeleteAsyncSearch(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncRequestDescriptor> configureRequest)
	{
		var descriptor = new DeleteAsyncRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncResponse DeleteAsyncSearch<TDocument>(DeleteAsyncRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual DeleteAsyncResponse DeleteAsyncSearch<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new DeleteAsyncRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncSearchAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncSearchAsync(DeleteAsyncRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncSearchAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncSearchAsync<TDocument>(DeleteAsyncRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes an async SQL search or a stored synchronous SQL search. If the search is still running, the API cancels it.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteAsyncResponse> DeleteAsyncSearchAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeleteAsyncRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncRequestDescriptor<TDocument>, DeleteAsyncResponse, DeleteAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncResponse GetAsyncSearch(GetAsyncRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetAsyncRequest, GetAsyncResponse, GetAsyncRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncSearchAsync(GetAsyncRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncRequest, GetAsyncResponse, GetAsyncRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncResponse GetAsyncSearch(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		var descriptor = new GetAsyncRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncResponse GetAsyncSearch(GetAsyncRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncResponse GetAsyncSearch(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncRequestDescriptor> configureRequest)
	{
		var descriptor = new GetAsyncRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncResponse GetAsyncSearch<TDocument>(GetAsyncRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncResponse GetAsyncSearch<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new GetAsyncRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncSearchAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncSearchAsync(GetAsyncRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncSearchAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncSearchAsync<TDocument>(GetAsyncRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status and available results for an async SQL search or stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncResponse> GetAsyncSearchAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncRequestDescriptor<TDocument>, GetAsyncResponse, GetAsyncRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncStatusResponse GetAsyncSearchStatus(GetAsyncStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetAsyncStatusRequest, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncSearchStatusAsync(GetAsyncStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequest, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncStatusResponse GetAsyncSearchStatus(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncStatusResponse GetAsyncSearchStatus(GetAsyncStatusRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncStatusResponse GetAsyncSearchStatus(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncStatusResponse GetAsyncSearchStatus<TDocument>(GetAsyncStatusRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetAsyncStatusResponse GetAsyncSearchStatus<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncStatusRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncSearchStatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncSearchStatusAsync(GetAsyncStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncSearchStatusAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncSearchStatusAsync<TDocument>(GetAsyncStatusRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns the current status of an async SQL search or a stored synchronous SQL search</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetAsyncStatusResponse> GetAsyncSearchStatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<GetAsyncStatusRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncStatusRequestDescriptor<TDocument>, GetAsyncStatusResponse, GetAsyncStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual QueryResponse Query(QueryRequest request)
	{
		request.BeforeRequest();
		return DoRequest<QueryRequest, QueryResponse, QueryRequestParameters>(request);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(QueryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<QueryRequest, QueryResponse, QueryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual QueryResponse Query()
	{
		var descriptor = new QueryRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual QueryResponse Query(QueryRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual QueryResponse Query(Action<QueryRequestDescriptor> configureRequest)
	{
		var descriptor = new QueryRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual QueryResponse Query<TDocument>(QueryRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual QueryResponse Query<TDocument>(Action<QueryRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new QueryRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(QueryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync(Action<QueryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync<TDocument>(QueryRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Executes a SQL request</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-search-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<QueryResponse> QueryAsync<TDocument>(Action<QueryRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new QueryRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<QueryRequestDescriptor<TDocument>, QueryResponse, QueryRequestParameters>(descriptor, cancellationToken);
	}
}
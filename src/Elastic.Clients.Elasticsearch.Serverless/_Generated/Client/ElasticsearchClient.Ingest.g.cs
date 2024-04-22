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

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public partial class IngestNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>Initializes a new instance of the <see cref="IngestNamespacedClient"/> class for mocking.</para>
	/// </summary>
	protected IngestNamespacedClient() : base()
	{
	}

	internal IngestNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequest, DeletePipelineResponse, DeletePipelineRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync<TDocument>(DeletePipelineRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequestDescriptor<TDocument>, DeletePipelineResponse, DeletePipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeletePipelineRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequestDescriptor<TDocument>, DeletePipelineResponse, DeletePipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeletePipelineRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeletePipelineRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequestDescriptor<TDocument>, DeletePipelineResponse, DeletePipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequestDescriptor, DeletePipelineResponse, DeletePipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeletePipelineRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequestDescriptor, DeletePipelineResponse, DeletePipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Deletes a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeletePipelineResponse> DeletePipelineAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<DeletePipelineRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeletePipelineRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeletePipelineRequestDescriptor, DeletePipelineResponse, DeletePipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns statistical information about geoip databases</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geoip-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GeoIpStatsResponse> GeoIpStatsAsync(GeoIpStatsRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GeoIpStatsRequest, GeoIpStatsResponse, GeoIpStatsRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns statistical information about geoip databases</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geoip-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GeoIpStatsResponse> GeoIpStatsAsync(GeoIpStatsRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GeoIpStatsRequestDescriptor, GeoIpStatsResponse, GeoIpStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns statistical information about geoip databases</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geoip-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GeoIpStatsResponse> GeoIpStatsAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GeoIpStatsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GeoIpStatsRequestDescriptor, GeoIpStatsResponse, GeoIpStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns statistical information about geoip databases</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/geoip-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GeoIpStatsResponse> GeoIpStatsAsync(Action<GeoIpStatsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GeoIpStatsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GeoIpStatsRequestDescriptor, GeoIpStatsResponse, GeoIpStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetPipelineRequest, GetPipelineResponse, GetPipelineRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync<TDocument>(GetPipelineRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor<TDocument>, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id? id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor<TDocument>, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id? id, Action<GetPipelineRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor<TDocument>, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor<TDocument>, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync<TDocument>(Action<GetPipelineRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor<TDocument>, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync(Elastic.Clients.Elasticsearch.Serverless.Id? id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync(Elastic.Clients.Elasticsearch.Serverless.Id? id, Action<GetPipelineRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetPipelineResponse> GetPipelineAsync(Action<GetPipelineRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetPipelineRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetPipelineRequestDescriptor, GetPipelineResponse, GetPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of the built-in patterns.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/grok-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ProcessorGrokResponse> ProcessorGrokAsync(ProcessorGrokRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ProcessorGrokRequest, ProcessorGrokResponse, ProcessorGrokRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of the built-in patterns.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/grok-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ProcessorGrokResponse> ProcessorGrokAsync(ProcessorGrokRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ProcessorGrokRequestDescriptor, ProcessorGrokResponse, ProcessorGrokRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of the built-in patterns.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/grok-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ProcessorGrokResponse> ProcessorGrokAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new ProcessorGrokRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<ProcessorGrokRequestDescriptor, ProcessorGrokResponse, ProcessorGrokRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of the built-in patterns.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/grok-processor.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ProcessorGrokResponse> ProcessorGrokAsync(Action<ProcessorGrokRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ProcessorGrokRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ProcessorGrokRequestDescriptor, ProcessorGrokResponse, ProcessorGrokRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync(PutPipelineRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PutPipelineRequest, PutPipelineResponse, PutPipelineRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync<TDocument>(PutPipelineRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPipelineRequestDescriptor<TDocument>, PutPipelineResponse, PutPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPipelineRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPipelineRequestDescriptor<TDocument>, PutPipelineResponse, PutPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<PutPipelineRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPipelineRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPipelineRequestDescriptor<TDocument>, PutPipelineResponse, PutPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync(PutPipelineRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPipelineRequestDescriptor, PutPipelineResponse, PutPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPipelineRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPipelineRequestDescriptor, PutPipelineResponse, PutPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Creates or updates a pipeline.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.13/ingest.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PutPipelineResponse> PutPipelineAsync(Elastic.Clients.Elasticsearch.Serverless.Id id, Action<PutPipelineRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PutPipelineRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PutPipelineRequestDescriptor, PutPipelineResponse, PutPipelineRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync(SimulateRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<SimulateRequest, SimulateResponse, SimulateRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync<TDocument>(SimulateRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor<TDocument>, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id? id, CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor<TDocument>, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Id? id, Action<SimulateRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor<TDocument>, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor<TDocument>, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync<TDocument>(Action<SimulateRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor<TDocument>, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync(SimulateRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync(Elastic.Clients.Elasticsearch.Serverless.Id? id, CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync(Elastic.Clients.Elasticsearch.Serverless.Id? id, Action<SimulateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Allows to simulate a pipeline with example documents.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SimulateResponse> SimulateAsync(Action<SimulateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SimulateRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SimulateRequestDescriptor, SimulateResponse, SimulateRequestParameters>(descriptor, cancellationToken);
	}
}
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

using Elastic.Transport;

#nullable restore
namespace Nest.Slm
{
	public partial class DeleteLifecycleDescriptor : RequestDescriptorBase<DeleteLifecycleDescriptor, DeleteLifecycleRequestParameters, IDeleteLifecycleRequest>, IDeleteLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementDeleteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_slm/policy/{policy_id}</summary>
        public DeleteLifecycleDescriptor(Nest.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}
	}

	public partial class ExecuteLifecycleDescriptor : RequestDescriptorBase<ExecuteLifecycleDescriptor, ExecuteLifecycleRequestParameters, IExecuteLifecycleRequest>, IExecuteLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_slm/policy/{policy_id}/_execute</summary>
        public ExecuteLifecycleDescriptor(Nest.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}
	}

	public partial class ExecuteRetentionDescriptor : RequestDescriptorBase<ExecuteRetentionDescriptor, ExecuteRetentionRequestParameters, IExecuteRetentionRequest>, IExecuteRetentionRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteRetention;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_slm/_execute_retention</summary>
        public ExecuteRetentionDescriptor() : base()
		{
		}
	}

	public partial class GetLifecycleDescriptor : RequestDescriptorBase<GetLifecycleDescriptor, GetLifecycleRequestParameters, IGetLifecycleRequest>, IGetLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_slm/policy/{policy_id}</summary>
        public GetLifecycleDescriptor(Nest.Names? policy_id) : base(r => r.Optional("policy_id", policy_id))
		{
		}

		///<summary>/_slm/policy</summary>
        public GetLifecycleDescriptor() : base()
		{
		}
	}

	public partial class GetStatsDescriptor : RequestDescriptorBase<GetStatsDescriptor, GetStatsRequestParameters, IGetStatsRequest>, IGetStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_slm/stats</summary>
        public GetStatsDescriptor() : base()
		{
		}
	}

	public partial class GetStatusDescriptor : RequestDescriptorBase<GetStatusDescriptor, GetStatusRequestParameters, IGetStatusRequest>, IGetStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_slm/status</summary>
        public GetStatusDescriptor() : base()
		{
		}
	}

	public partial class PutLifecycleDescriptor : RequestDescriptorBase<PutLifecycleDescriptor, PutLifecycleRequestParameters, IPutLifecycleRequest>, IPutLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_slm/policy/{policy_id}</summary>
        public PutLifecycleDescriptor(Nest.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}
	}

	public partial class StartDescriptor : RequestDescriptorBase<StartDescriptor, StartRequestParameters, IStartRequest>, IStartRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_slm/start</summary>
        public StartDescriptor() : base()
		{
		}
	}

	public partial class StopDescriptor : RequestDescriptorBase<StopDescriptor, StopRequestParameters, IStopRequest>, IStopRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_slm/stop</summary>
        public StopDescriptor() : base()
		{
		}
	}
}
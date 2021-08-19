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
namespace Nest.Snapshot
{
	public partial class CleanupRepositoryDescriptor : RequestDescriptorBase<CleanupRepositoryDescriptor, CleanupRepositoryRequestParameters, ICleanupRepositoryRequest>, ICleanupRepositoryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCleanupRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/_cleanup</summary>
        public CleanupRepositoryDescriptor(Nest.Name repository) : base(r => r.Required("repository", repository))
		{
		}
	}

	public partial class CloneDescriptor : RequestDescriptorBase<CloneDescriptor, CloneRequestParameters, ICloneRequest>, ICloneRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotClone;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}</summary>
        public CloneDescriptor(Nest.Name repository, Nest.Name snapshot, Nest.Name target_snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot).Required("target_snapshot", target_snapshot))
		{
		}
	}

	public partial class CreateDescriptor : RequestDescriptorBase<CreateDescriptor, CreateRequestParameters, ICreateRequest>, ICreateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
        public CreateDescriptor(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}
	}

	public partial class CreateRepositoryDescriptor : RequestDescriptorBase<CreateRepositoryDescriptor, CreateRepositoryRequestParameters, ICreateRepositoryRequest>, ICreateRepositoryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreateRepository;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}</summary>
        public CreateRepositoryDescriptor(Nest.Name repository) : base(r => r.Required("repository", repository))
		{
		}
	}

	public partial class DeleteDescriptor : RequestDescriptorBase<DeleteDescriptor, DeleteRequestParameters, IDeleteRequest>, IDeleteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
        public DeleteDescriptor(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}
	}

	public partial class DeleteRepositoryDescriptor : RequestDescriptorBase<DeleteRepositoryDescriptor, DeleteRepositoryRequestParameters, IDeleteRepositoryRequest>, IDeleteRepositoryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDeleteRepository;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}</summary>
        public DeleteRepositoryDescriptor(Nest.Names repository) : base(r => r.Required("repository", repository))
		{
		}
	}

	public partial class GetDescriptor : RequestDescriptorBase<GetDescriptor, GetRequestParameters, IGetRequest>, IGetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
        public GetDescriptor(Nest.Name repository, Nest.Names snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}
	}

	public partial class GetRepositoryDescriptor : RequestDescriptorBase<GetRepositoryDescriptor, GetRepositoryRequestParameters, IGetRepositoryRequest>, IGetRepositoryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGetRepository;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot</summary>
        public GetRepositoryDescriptor() : base()
		{
		}

		///<summary>/_snapshot/{repository}</summary>
        public GetRepositoryDescriptor(Nest.Names? repository) : base(r => r.Optional("repository", repository))
		{
		}
	}

	public partial class RestoreDescriptor : RequestDescriptorBase<RestoreDescriptor, RestoreRequestParameters, IRestoreRequest>, IRestoreRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotRestore;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}/_restore</summary>
        public RestoreDescriptor(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}
	}

	public partial class StatusDescriptor : RequestDescriptorBase<StatusDescriptor, StatusRequestParameters, IStatusRequest>, IStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/_status</summary>
        public StatusDescriptor() : base()
		{
		}

		///<summary>/_snapshot/{repository}/_status</summary>
        public StatusDescriptor(Nest.Name? repository) : base(r => r.Optional("repository", repository))
		{
		}

		///<summary>/_snapshot/{repository}/{snapshot}/_status</summary>
        public StatusDescriptor(Nest.Name? repository, Nest.Names? snapshot) : base(r => r.Optional("repository", repository).Optional("snapshot", snapshot))
		{
		}
	}

	public partial class VerifyRepositoryDescriptor : RequestDescriptorBase<VerifyRepositoryDescriptor, VerifyRepositoryRequestParameters, IVerifyRepositoryRequest>, IVerifyRepositoryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotVerifyRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/_verify</summary>
        public VerifyRepositoryDescriptor(Nest.Name repository) : base(r => r.Required("repository", repository))
		{
		}
	}
}
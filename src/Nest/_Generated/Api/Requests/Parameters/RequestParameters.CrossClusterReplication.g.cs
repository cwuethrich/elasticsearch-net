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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public class DeleteAutoFollowPatternRequestParameters : RequestParameters<DeleteAutoFollowPatternRequestParameters>
    {
    }

    public class CreateFollowIndexRequestParameters : RequestParameters<CreateFollowIndexRequestParameters>
    {
        public string? WaitForActiveShards { get => Q<string?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class FollowInfoRequestParameters : RequestParameters<FollowInfoRequestParameters>
    {
    }

    public class FollowIndexStatsRequestParameters : RequestParameters<FollowIndexStatsRequestParameters>
    {
    }

    public class ForgetFollowerIndexRequestParameters : RequestParameters<ForgetFollowerIndexRequestParameters>
    {
    }

    public class GetAutoFollowPatternRequestParameters : RequestParameters<GetAutoFollowPatternRequestParameters>
    {
    }

    public class PauseAutoFollowPatternRequestParameters : RequestParameters<PauseAutoFollowPatternRequestParameters>
    {
    }

    public class PauseFollowIndexRequestParameters : RequestParameters<PauseFollowIndexRequestParameters>
    {
    }

    public class CreateAutoFollowPatternRequestParameters : RequestParameters<CreateAutoFollowPatternRequestParameters>
    {
    }

    public class ResumeAutoFollowPatternRequestParameters : RequestParameters<ResumeAutoFollowPatternRequestParameters>
    {
    }

    public class ResumeFollowIndexRequestParameters : RequestParameters<ResumeFollowIndexRequestParameters>
    {
    }

    public class CcrStatsRequestParameters : RequestParameters<CcrStatsRequestParameters>
    {
    }

    public class UnfollowIndexRequestParameters : RequestParameters<UnfollowIndexRequestParameters>
    {
    }
}
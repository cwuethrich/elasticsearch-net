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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlExplainDataFrameAnalyticsRequestParameters : RequestParameters<MlExplainDataFrameAnalyticsRequestParameters>
	{
	}

	public partial class MlExplainDataFrameAnalyticsRequest : PlainRequestBase<MlExplainDataFrameAnalyticsRequestParameters>
	{
		public MlExplainDataFrameAnalyticsRequest()
		{
		}

		public MlExplainDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningExplainDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("source")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsSource? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("dest")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsDestination? Dest { get; set; }

		[JsonInclude]
		[JsonPropertyName("analysis")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisContainer? Analysis { get; set; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_memory_limit")]
		public string? ModelMemoryLimit { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_num_threads")]
		public int? MaxNumThreads { get; set; }

		[JsonInclude]
		[JsonPropertyName("analyzed_fields")]
		public Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? AnalyzedFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("allow_lazy_start")]
		public bool? AllowLazyStart { get; set; }
	}

	public sealed partial class MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptorBase<MlExplainDataFrameAnalyticsRequestDescriptor<TDocument>, MlExplainDataFrameAnalyticsRequestParameters>
	{
		internal MlExplainDataFrameAnalyticsRequestDescriptor(Action<MlExplainDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlExplainDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningExplainDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			RouteValues.Optional("id", id);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsDestination? DestValue { get; set; }

		private DataframeAnalyticsDestinationDescriptor<TDocument> DestDescriptor { get; set; }

		private Action<DataframeAnalyticsDestinationDescriptor<TDocument>> DestDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsSource? SourceValue { get; set; }

		private DataframeAnalyticsSourceDescriptor<TDocument> SourceDescriptor { get; set; }

		private Action<DataframeAnalyticsSourceDescriptor<TDocument>> SourceDescriptorAction { get; set; }

		private bool? AllowLazyStartValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisContainer? AnalysisValue { get; set; }

		private DataframeAnalysisContainerDescriptor AnalysisDescriptor { get; set; }

		private Action<DataframeAnalysisContainerDescriptor> AnalysisDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? AnalyzedFieldsValue { get; set; }

		private DataframeAnalysisAnalyzedFieldsDescriptor AnalyzedFieldsDescriptor { get; set; }

		private Action<DataframeAnalysisAnalyzedFieldsDescriptor> AnalyzedFieldsDescriptorAction { get; set; }

		private string? DescriptionValue { get; set; }

		private int? MaxNumThreadsValue { get; set; }

		private string? ModelMemoryLimitValue { get; set; }

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Dest(Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsDestination? dest)
		{
			DestDescriptor = null;
			DestDescriptorAction = null;
			DestValue = dest;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Dest(DataframeAnalyticsDestinationDescriptor<TDocument> descriptor)
		{
			DestValue = null;
			DestDescriptorAction = null;
			DestDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Dest(Action<DataframeAnalyticsDestinationDescriptor<TDocument>> configure)
		{
			DestValue = null;
			DestDescriptor = null;
			DestDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsSource? source)
		{
			SourceDescriptor = null;
			SourceDescriptorAction = null;
			SourceValue = source;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Source(DataframeAnalyticsSourceDescriptor<TDocument> descriptor)
		{
			SourceValue = null;
			SourceDescriptorAction = null;
			SourceDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Source(Action<DataframeAnalyticsSourceDescriptor<TDocument>> configure)
		{
			SourceValue = null;
			SourceDescriptor = null;
			SourceDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> AllowLazyStart(bool? allowLazyStart = true)
		{
			AllowLazyStartValue = allowLazyStart;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Analysis(Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisContainer? analysis)
		{
			AnalysisDescriptor = null;
			AnalysisDescriptorAction = null;
			AnalysisValue = analysis;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Analysis(DataframeAnalysisContainerDescriptor descriptor)
		{
			AnalysisValue = null;
			AnalysisDescriptorAction = null;
			AnalysisDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Analysis(Action<DataframeAnalysisContainerDescriptor> configure)
		{
			AnalysisValue = null;
			AnalysisDescriptor = null;
			AnalysisDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> AnalyzedFields(Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? analyzedFields)
		{
			AnalyzedFieldsDescriptor = null;
			AnalyzedFieldsDescriptorAction = null;
			AnalyzedFieldsValue = analyzedFields;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> AnalyzedFields(DataframeAnalysisAnalyzedFieldsDescriptor descriptor)
		{
			AnalyzedFieldsValue = null;
			AnalyzedFieldsDescriptorAction = null;
			AnalyzedFieldsDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> AnalyzedFields(Action<DataframeAnalysisAnalyzedFieldsDescriptor> configure)
		{
			AnalyzedFieldsValue = null;
			AnalyzedFieldsDescriptor = null;
			AnalyzedFieldsDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> MaxNumThreads(int? maxNumThreads)
		{
			MaxNumThreadsValue = maxNumThreads;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor<TDocument> ModelMemoryLimit(string? modelMemoryLimit)
		{
			ModelMemoryLimitValue = modelMemoryLimit;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DestDescriptor is not null)
			{
				writer.WritePropertyName("dest");
				JsonSerializer.Serialize(writer, DestDescriptor, options);
			}
			else if (DestDescriptorAction is not null)
			{
				writer.WritePropertyName("dest");
				JsonSerializer.Serialize(writer, new DataframeAnalyticsDestinationDescriptor<TDocument>(DestDescriptorAction), options);
			}
			else if (DestValue is not null)
			{
				writer.WritePropertyName("dest");
				JsonSerializer.Serialize(writer, DestValue, options);
			}

			if (SourceDescriptor is not null)
			{
				writer.WritePropertyName("source");
				JsonSerializer.Serialize(writer, SourceDescriptor, options);
			}
			else if (SourceDescriptorAction is not null)
			{
				writer.WritePropertyName("source");
				JsonSerializer.Serialize(writer, new DataframeAnalyticsSourceDescriptor<TDocument>(SourceDescriptorAction), options);
			}
			else if (SourceValue is not null)
			{
				writer.WritePropertyName("source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (AllowLazyStartValue.HasValue)
			{
				writer.WritePropertyName("allow_lazy_start");
				writer.WriteBooleanValue(AllowLazyStartValue.Value);
			}

			if (AnalysisDescriptor is not null)
			{
				writer.WritePropertyName("analysis");
				JsonSerializer.Serialize(writer, AnalysisDescriptor, options);
			}
			else if (AnalysisDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis");
				JsonSerializer.Serialize(writer, new DataframeAnalysisContainerDescriptor(AnalysisDescriptorAction), options);
			}
			else if (AnalysisValue is not null)
			{
				writer.WritePropertyName("analysis");
				JsonSerializer.Serialize(writer, AnalysisValue, options);
			}

			if (AnalyzedFieldsDescriptor is not null)
			{
				writer.WritePropertyName("analyzed_fields");
				JsonSerializer.Serialize(writer, AnalyzedFieldsDescriptor, options);
			}
			else if (AnalyzedFieldsDescriptorAction is not null)
			{
				writer.WritePropertyName("analyzed_fields");
				JsonSerializer.Serialize(writer, new DataframeAnalysisAnalyzedFieldsDescriptor(AnalyzedFieldsDescriptorAction), options);
			}
			else if (AnalyzedFieldsValue is not null)
			{
				writer.WritePropertyName("analyzed_fields");
				JsonSerializer.Serialize(writer, AnalyzedFieldsValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (MaxNumThreadsValue.HasValue)
			{
				writer.WritePropertyName("max_num_threads");
				writer.WriteNumberValue(MaxNumThreadsValue.Value);
			}

			if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
			{
				writer.WritePropertyName("model_memory_limit");
				writer.WriteStringValue(ModelMemoryLimitValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class MlExplainDataFrameAnalyticsRequestDescriptor : RequestDescriptorBase<MlExplainDataFrameAnalyticsRequestDescriptor, MlExplainDataFrameAnalyticsRequestParameters>
	{
		internal MlExplainDataFrameAnalyticsRequestDescriptor(Action<MlExplainDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);
		public MlExplainDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningExplainDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlExplainDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			RouteValues.Optional("id", id);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsDestination? DestValue { get; set; }

		private DataframeAnalyticsDestinationDescriptor DestDescriptor { get; set; }

		private Action<DataframeAnalyticsDestinationDescriptor> DestDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsSource? SourceValue { get; set; }

		private DataframeAnalyticsSourceDescriptor SourceDescriptor { get; set; }

		private Action<DataframeAnalyticsSourceDescriptor> SourceDescriptorAction { get; set; }

		private bool? AllowLazyStartValue { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisContainer? AnalysisValue { get; set; }

		private DataframeAnalysisContainerDescriptor AnalysisDescriptor { get; set; }

		private Action<DataframeAnalysisContainerDescriptor> AnalysisDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? AnalyzedFieldsValue { get; set; }

		private DataframeAnalysisAnalyzedFieldsDescriptor AnalyzedFieldsDescriptor { get; set; }

		private Action<DataframeAnalysisAnalyzedFieldsDescriptor> AnalyzedFieldsDescriptorAction { get; set; }

		private string? DescriptionValue { get; set; }

		private int? MaxNumThreadsValue { get; set; }

		private string? ModelMemoryLimitValue { get; set; }

		public MlExplainDataFrameAnalyticsRequestDescriptor Dest(Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsDestination? dest)
		{
			DestDescriptor = null;
			DestDescriptorAction = null;
			DestValue = dest;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Dest(DataframeAnalyticsDestinationDescriptor descriptor)
		{
			DestValue = null;
			DestDescriptorAction = null;
			DestDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Dest(Action<DataframeAnalyticsDestinationDescriptor> configure)
		{
			DestValue = null;
			DestDescriptor = null;
			DestDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Source(Elastic.Clients.Elasticsearch.Ml.DataframeAnalyticsSource? source)
		{
			SourceDescriptor = null;
			SourceDescriptorAction = null;
			SourceValue = source;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Source(DataframeAnalyticsSourceDescriptor descriptor)
		{
			SourceValue = null;
			SourceDescriptorAction = null;
			SourceDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Source(Action<DataframeAnalyticsSourceDescriptor> configure)
		{
			SourceValue = null;
			SourceDescriptor = null;
			SourceDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor AllowLazyStart(bool? allowLazyStart = true)
		{
			AllowLazyStartValue = allowLazyStart;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Analysis(Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisContainer? analysis)
		{
			AnalysisDescriptor = null;
			AnalysisDescriptorAction = null;
			AnalysisValue = analysis;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Analysis(DataframeAnalysisContainerDescriptor descriptor)
		{
			AnalysisValue = null;
			AnalysisDescriptorAction = null;
			AnalysisDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Analysis(Action<DataframeAnalysisContainerDescriptor> configure)
		{
			AnalysisValue = null;
			AnalysisDescriptor = null;
			AnalysisDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor AnalyzedFields(Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisAnalyzedFields? analyzedFields)
		{
			AnalyzedFieldsDescriptor = null;
			AnalyzedFieldsDescriptorAction = null;
			AnalyzedFieldsValue = analyzedFields;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor AnalyzedFields(DataframeAnalysisAnalyzedFieldsDescriptor descriptor)
		{
			AnalyzedFieldsValue = null;
			AnalyzedFieldsDescriptorAction = null;
			AnalyzedFieldsDescriptor = descriptor;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor AnalyzedFields(Action<DataframeAnalysisAnalyzedFieldsDescriptor> configure)
		{
			AnalyzedFieldsValue = null;
			AnalyzedFieldsDescriptor = null;
			AnalyzedFieldsDescriptorAction = configure;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor MaxNumThreads(int? maxNumThreads)
		{
			MaxNumThreadsValue = maxNumThreads;
			return Self;
		}

		public MlExplainDataFrameAnalyticsRequestDescriptor ModelMemoryLimit(string? modelMemoryLimit)
		{
			ModelMemoryLimitValue = modelMemoryLimit;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DestDescriptor is not null)
			{
				writer.WritePropertyName("dest");
				JsonSerializer.Serialize(writer, DestDescriptor, options);
			}
			else if (DestDescriptorAction is not null)
			{
				writer.WritePropertyName("dest");
				JsonSerializer.Serialize(writer, new DataframeAnalyticsDestinationDescriptor(DestDescriptorAction), options);
			}
			else if (DestValue is not null)
			{
				writer.WritePropertyName("dest");
				JsonSerializer.Serialize(writer, DestValue, options);
			}

			if (SourceDescriptor is not null)
			{
				writer.WritePropertyName("source");
				JsonSerializer.Serialize(writer, SourceDescriptor, options);
			}
			else if (SourceDescriptorAction is not null)
			{
				writer.WritePropertyName("source");
				JsonSerializer.Serialize(writer, new DataframeAnalyticsSourceDescriptor(SourceDescriptorAction), options);
			}
			else if (SourceValue is not null)
			{
				writer.WritePropertyName("source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (AllowLazyStartValue.HasValue)
			{
				writer.WritePropertyName("allow_lazy_start");
				writer.WriteBooleanValue(AllowLazyStartValue.Value);
			}

			if (AnalysisDescriptor is not null)
			{
				writer.WritePropertyName("analysis");
				JsonSerializer.Serialize(writer, AnalysisDescriptor, options);
			}
			else if (AnalysisDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis");
				JsonSerializer.Serialize(writer, new DataframeAnalysisContainerDescriptor(AnalysisDescriptorAction), options);
			}
			else if (AnalysisValue is not null)
			{
				writer.WritePropertyName("analysis");
				JsonSerializer.Serialize(writer, AnalysisValue, options);
			}

			if (AnalyzedFieldsDescriptor is not null)
			{
				writer.WritePropertyName("analyzed_fields");
				JsonSerializer.Serialize(writer, AnalyzedFieldsDescriptor, options);
			}
			else if (AnalyzedFieldsDescriptorAction is not null)
			{
				writer.WritePropertyName("analyzed_fields");
				JsonSerializer.Serialize(writer, new DataframeAnalysisAnalyzedFieldsDescriptor(AnalyzedFieldsDescriptorAction), options);
			}
			else if (AnalyzedFieldsValue is not null)
			{
				writer.WritePropertyName("analyzed_fields");
				JsonSerializer.Serialize(writer, AnalyzedFieldsValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (MaxNumThreadsValue.HasValue)
			{
				writer.WritePropertyName("max_num_threads");
				writer.WriteNumberValue(MaxNumThreadsValue.Value);
			}

			if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
			{
				writer.WritePropertyName("model_memory_limit");
				writer.WriteStringValue(ModelMemoryLimitValue);
			}

			writer.WriteEndObject();
		}
	}
}
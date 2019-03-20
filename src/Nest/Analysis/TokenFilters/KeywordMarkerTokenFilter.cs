﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// Protects words from being modified by stemmers. Must be placed before any stemming filters.
	/// </summary>
	public interface IKeywordMarkerTokenFilter : ITokenFilter
	{
		/// <summary>
		/// Set to true to lower case all words first. Defaults to false.
		/// </summary>
		[DataMember(Name = "ignore_case")]
		[JsonFormatter(typeof(NullableStringBooleanFormatter))]
		bool? IgnoreCase { get; set; }

		/// <summary>
		/// A list of words to use.
		/// <para></para>
		/// Cannot specify both <see cref="KeywordsPattern"/> and <see cref="Keywords"/> or <see cref="KeywordsPath"/>
		/// </summary>
		[DataMember(Name = "keywords")]
		IEnumerable<string> Keywords { get; set; }

		/// <summary>
		/// A path (either relative to config location, or absolute) to a list of words.
		/// <para></para>
		/// Cannot specify both <see cref="KeywordsPattern"/> and <see cref="Keywords"/> or <see cref="KeywordsPath"/>
		/// </summary>
		[DataMember(Name = "keywords_path")]
		string KeywordsPath { get; set; }

		/// <summary>
		/// A regular expression pattern to match against words in the text.
		/// <para></para>
		/// Cannot specify both <see cref="KeywordsPattern"/> and <see cref="Keywords"/> or <see cref="KeywordsPath"/>
		/// </summary>
		[DataMember(Name = "keywords_pattern")]
		string KeywordsPattern { get; set; }
	}

	/// <inheritdoc cref="IKeywordMarkerTokenFilter" />
	public class KeywordMarkerTokenFilter : TokenFilterBase, IKeywordMarkerTokenFilter
	{
		public KeywordMarkerTokenFilter() : base("keyword_marker") { }

		/// <inheritdoc />
		public bool? IgnoreCase { get; set; }

		/// <inheritdoc />
		public IEnumerable<string> Keywords { get; set; }

		/// <inheritdoc />
		public string KeywordsPath { get; set; }

		/// <inheritdoc />
		public string KeywordsPattern { get; set; }
	}

	/// <inheritdoc cref="IKeywordMarkerTokenFilter" />
	public class KeywordMarkerTokenFilterDescriptor
		: TokenFilterDescriptorBase<KeywordMarkerTokenFilterDescriptor, IKeywordMarkerTokenFilter>, IKeywordMarkerTokenFilter
	{
		protected override string Type => "keyword_marker";
		bool? IKeywordMarkerTokenFilter.IgnoreCase { get; set; }

		IEnumerable<string> IKeywordMarkerTokenFilter.Keywords { get; set; }
		string IKeywordMarkerTokenFilter.KeywordsPath { get; set; }

		string IKeywordMarkerTokenFilter.KeywordsPattern { get; set; }

		/// <inheritdoc cref="IKeywordMarkerTokenFilter.IgnoreCase" />
		public KeywordMarkerTokenFilterDescriptor IgnoreCase(bool? ignoreCase = true) => Assign(a => a.IgnoreCase = ignoreCase);

		/// <inheritdoc cref="IKeywordMarkerTokenFilter.KeywordsPath" />
		public KeywordMarkerTokenFilterDescriptor KeywordsPath(string path) => Assign(a => a.KeywordsPath = path);

		/// <inheritdoc cref="IKeywordMarkerTokenFilter.KeywordsPattern" />
		public KeywordMarkerTokenFilterDescriptor KeywordsPattern(string pattern) => Assign(a => a.KeywordsPattern = pattern);

		/// <inheritdoc cref="IKeywordMarkerTokenFilter.Keywords" />
		public KeywordMarkerTokenFilterDescriptor Keywords(IEnumerable<string> keywords) => Assign(a => a.Keywords = keywords);

		/// <inheritdoc cref="IKeywordMarkerTokenFilter.Keywords" />
		public KeywordMarkerTokenFilterDescriptor Keywords(params string[] keywords) => Assign(a => a.Keywords = keywords);
	}
}

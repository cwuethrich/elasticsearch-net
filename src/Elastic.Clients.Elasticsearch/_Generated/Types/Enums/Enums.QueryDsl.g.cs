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

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public enum ChildScoreMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum CombinedFieldsOperator
	{
		[EnumMember(Value = "or")]
		Or,
		[EnumMember(Value = "and")]
		And
	}

	public enum CombinedFieldsZeroTerms
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "all")]
		All
	}

	public enum FieldValueFactorModifier
	{
		[EnumMember(Value = "square")]
		Square,
		[EnumMember(Value = "sqrt")]
		Sqrt,
		[EnumMember(Value = "reciprocal")]
		Reciprocal,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "log2p")]
		Log2p,
		[EnumMember(Value = "log1p")]
		Log1p,
		[EnumMember(Value = "log")]
		Log,
		[EnumMember(Value = "ln2p")]
		Ln2p,
		[EnumMember(Value = "ln1p")]
		Ln1p,
		[EnumMember(Value = "ln")]
		Ln
	}

	public enum FunctionBoostMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "replace")]
		Replace,
		[EnumMember(Value = "multiply")]
		Multiply,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum FunctionScoreMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "multiply")]
		Multiply,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "first")]
		First,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum GeoValidationMethod
	{
		[EnumMember(Value = "strict")]
		Strict,
		[EnumMember(Value = "ignore_malformed")]
		IgnoreMalformed,
		[EnumMember(Value = "coerce")]
		Coerce
	}

	public enum MultiValueMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum NestedScoreMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum Operator
	{
		[EnumMember(Value = "or")]
		Or,
		[EnumMember(Value = "and")]
		And
	}

	public enum RangeRelation
	{
		[EnumMember(Value = "within")]
		Within,
		[EnumMember(Value = "intersects")]
		Intersects,
		[EnumMember(Value = "contains")]
		Contains
	}

	public enum SimpleQueryStringFlags
	{
		[EnumMember(Value = "WHITESPACE")]
		Whitespace,
		[EnumMember(Value = "SLOP")]
		Slop,
		[EnumMember(Value = "PREFIX")]
		Prefix,
		[EnumMember(Value = "PRECEDENCE")]
		Precedence,
		[EnumMember(Value = "PHRASE")]
		Phrase,
		[EnumMember(Value = "OR")]
		Or,
		[EnumMember(Value = "NOT")]
		Not,
		[EnumMember(Value = "NONE")]
		None,
		[EnumMember(Value = "NEAR")]
		Near,
		[EnumMember(Value = "FUZZY")]
		Fuzzy,
		[EnumMember(Value = "ESCAPE")]
		Escape,
		[EnumMember(Value = "AND")]
		And,
		[EnumMember(Value = "ALL")]
		All
	}

	public enum TextQueryType
	{
		[EnumMember(Value = "phrase_prefix")]
		PhrasePrefix,
		[EnumMember(Value = "phrase")]
		Phrase,
		[EnumMember(Value = "most_fields")]
		MostFields,
		[EnumMember(Value = "cross_fields")]
		CrossFields,
		[EnumMember(Value = "bool_prefix")]
		BoolPrefix,
		[EnumMember(Value = "best_fields")]
		BestFields
	}

	public enum ZeroTermsQuery
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "all")]
		All
	}
}
using System;
using System.Runtime.Serialization;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public interface IFilterQuery
	{
		[DataMember(Name = "tag")]
		string Tag { get; set; }

		[DataMember(Name = "description")]
		string Description { get; set; }

		[DataMember(Name = "ignore_failure")]
		bool? IgnoreFailure { get; set; }

		[DataMember(Name = "query")]
		QueryContainer Query { get; set; }
	}

	public class FilterQuery : IFilterQuery
	{
		public string Tag { get; set; }
		public string Description { get; set; }
		public bool? IgnoreFailure { get; set; }
		public QueryContainer Query { get; set; }
	}

	public class FilterQueryDescriptor<TInferDocument> : DescriptorBase<FilterQueryDescriptor<TInferDocument>, IFilterQuery>, IFilterQuery where TInferDocument : class
	{
		string IFilterQuery.Tag { get; set; }
		string IFilterQuery.Description { get; set; }
		bool? IFilterQuery.IgnoreFailure { get; set; }
		QueryContainer IFilterQuery.Query { get; set; }

		public FilterQueryDescriptor<TInferDocument> Tag(string tag) => Assign(tag, (a, v) => a.Tag = v);

		public FilterQueryDescriptor<TInferDocument> Description(string description) => Assign(description, (a, v) => a.Description = v);

		public FilterQueryDescriptor<TInferDocument> IgnoreFailure(bool ignorefailure) => Assign(ignorefailure, (a, v) => a.IgnoreFailure = v);

		public FilterQueryDescriptor<TInferDocument> Query(Func<QueryContainerDescriptor<TInferDocument>, QueryContainer> selector) => Assign(selector, (a, v) => a.Query = v?.Invoke(new QueryContainerDescriptor<TInferDocument>()));
	}
}

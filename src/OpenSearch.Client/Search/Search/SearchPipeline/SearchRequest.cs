using System;
using System.Runtime.Serialization;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client
{
	public partial interface ISearchRequest
	{
		[DataMember(Name = "search_pipeline")]
		ISearchPipeline SearchPipeline { get; set; }
	}

	public partial class SearchRequest
	{
		public ISearchPipeline SearchPipeline { get; set; }
	}

	public partial class SearchDescriptor<TInferDocument> where TInferDocument : class
	{
		ISearchPipeline ISearchRequest.SearchPipeline { get; set; }

		public SearchDescriptor<TInferDocument> SearchPipeline(Func<SearchPipelineDescriptor<TInferDocument>, ISearchPipeline> selector) =>
				Assign(selector, (a, v) => a.SearchPipeline = v?.Invoke(new SearchPipelineDescriptor<TInferDocument>()));

		public SearchDescriptor<TInferDocument> SearchPipeline(string searchPipeline = "_none") => Qs("search_pipeline", searchPipeline);
	}
}

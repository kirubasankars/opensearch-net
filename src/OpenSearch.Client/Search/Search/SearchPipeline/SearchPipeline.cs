using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Timers;
using OpenSearch.Client.Search.Search.SearchPipeline;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public interface ISearchPipeline
	{
		[DataMember(Name = "request_processors")]
		List<IRequestProcessor> RequestProcessors { get; set; }

		[DataMember(Name = "response_processors")]
		List<IResponseProcessor> ResponseProcessors { get; set; }
	}

	public class SearchPipeline : ISearchPipeline
	{
		List<IRequestProcessor> ISearchPipeline.RequestProcessors { get; set; }

		List<IResponseProcessor> ISearchPipeline.ResponseProcessors { get; set; }

	}

	public class SearchPipelineDescriptor<TInferDocument> : DescriptorBase<SearchPipelineDescriptor<TInferDocument>, ISearchPipeline>, ISearchPipeline
	where TInferDocument : class
	{
		public List<IRequestProcessor> RequestProcessors { get; set; }

		public List<IResponseProcessor> ResponseProcessors { get; set; }

		public SearchPipelineDescriptor<TInferDocument> RequestProcessor(Func<RequestProcessorDescriptor<TInferDocument>, IRequestProcessor> selector) => AddRequestProcessor(selector?.Invoke(new RequestProcessorDescriptor<TInferDocument>()));

		private SearchPipelineDescriptor<TInferDocument> AddRequestProcessor(IRequestProcessor selector) => Assign(selector, (a, v) => { if (a.RequestProcessors == null) { a.RequestProcessors = new List<IRequestProcessor>(); } a.RequestProcessors.Add(v); });

		public SearchPipelineDescriptor<TInferDocument> ResponseProcessor(Func<ResponseProcessorDescriptor<TInferDocument>, IResponseProcessor> selector) => AddResponseProcessor(selector?.Invoke(new ResponseProcessorDescriptor<TInferDocument>()));

		private SearchPipelineDescriptor<TInferDocument> AddResponseProcessor(IResponseProcessor selector) => Assign(selector, (a, v) => { if (a.ResponseProcessors == null) { a.ResponseProcessors = new List<IResponseProcessor>(); } a.ResponseProcessors.Add(v); });
	}
}

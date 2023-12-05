using System;
using System.Runtime.Serialization;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public interface IRequestProcessor
	{

		[DataMember(Name = "filter_query")]
		IFilterQuery FilterQuery { get; set; }


	}

	public class RequestProcessor : IRequestProcessor
	{
		public IFilterQuery FilterQuery { get; set; }

	}

	public class RequestProcessorDescriptor<TInferDocument> : DescriptorBase<RequestProcessorDescriptor<TInferDocument>, IRequestProcessor>, IRequestProcessor
	where TInferDocument : class
	{
		IFilterQuery IRequestProcessor.FilterQuery { get; set; }

		public RequestProcessorDescriptor<TInferDocument> FilterQuery(Func<FilterQueryDescriptor<TInferDocument>, IFilterQuery> selector) => Assign(selector, (a, v) => a.FilterQuery = v?.Invoke(new FilterQueryDescriptor<TInferDocument>()));

	}
}

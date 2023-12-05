using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client.Search.Search.SearchPipeline
{
	[InterfaceDataContract]
	public interface IResponseProcessor
	{
		[DataMember(Name = "rename_field")]
		IRenameField RenameField { get; set; }
	}

	public class ResponseProcessor : IResponseProcessor
	{
		public IRenameField RenameField { get; set; }
	}

	public class ResponseProcessorDescriptor<TInferDocument> : DescriptorBase<ResponseProcessorDescriptor<TInferDocument>, IResponseProcessor>, IResponseProcessor
	where TInferDocument : class
	{
		IRenameField IResponseProcessor.RenameField { get; set; }

		public ResponseProcessorDescriptor<TInferDocument> RenameField(Func<RenameFieldDescriptor<TInferDocument>, IRenameField> selector) => Assign(selector, (a, v) => a.RenameField = v?.Invoke(new RenameFieldDescriptor<TInferDocument>()));

	}
}

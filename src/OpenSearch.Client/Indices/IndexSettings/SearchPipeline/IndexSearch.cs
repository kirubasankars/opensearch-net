using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public interface IIndexSearch
	{
		string DefaultPipeline { get; set; }
	}

	public class IndexSearch : IIndexSearch
	{
		public string DefaultPipeline { get; set; }
	}

	public class IndexSearchDescriptor : DescriptorBase<IndexSearchDescriptor, IIndexSearch>, IIndexSearch
	{
		string IIndexSearch.DefaultPipeline { get; set; }

		public IndexSearchDescriptor DefaultPipleline(string defaultPipeline) => Assign(defaultPipeline, (a, v) => a.DefaultPipeline = v);
	}
}

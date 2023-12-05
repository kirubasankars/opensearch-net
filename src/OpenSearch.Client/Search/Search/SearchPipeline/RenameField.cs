using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client
{
	[InterfaceDataContract]
	public interface IRenameField
	{
		[DataMember(Name = "field")]
		string Field { get; set; }

		[DataMember(Name = "target_field")]
		string TargetField { get; set; }

		[DataMember(Name = "description")]
		string Description { get; set; }

		[DataMember(Name = "tag")]
		string Tag { get; set; }

		[DataMember(Name = "ignore_failure")]
		bool? IgnoreFailure { get; set; }
	}

	public class RenameField : IRenameField
	{
		public string Field { get; set; }
		public string TargetField { get; set; }
		public string Tag { get; set; }
		public bool? IgnoreFailure { get; set; }
		public string Description { get; set; }
	}

	public class RenameFieldDescriptor<TInferDocument> : DescriptorBase<RenameFieldDescriptor<TInferDocument>, IRenameField>, IRenameField
	where TInferDocument : class
	{
		string IRenameField.Field { get; set; }
		string IRenameField.TargetField { get; set; }
		string IRenameField.Description { get; set; }
		string IRenameField.Tag { get; set; }
		bool? IRenameField.IgnoreFailure { get; set; }

		public RenameFieldDescriptor<TInferDocument> Field(string field) => Assign(field, (a, v) => a.Field = v);

		public RenameFieldDescriptor<TInferDocument> TargetField(string target_field) => Assign(target_field, (a, v) => a.TargetField = v);

		public RenameFieldDescriptor<TInferDocument> Description(string description) => Assign(description, (a, v) => a.Description = v);

		public RenameFieldDescriptor<TInferDocument> Tag(string tag) => Assign(tag, (a, v) => a.Tag = v);

		public RenameFieldDescriptor<TInferDocument> IgnoreFailure(bool ignore_field) => Assign(ignore_field, (a, v) => a.IgnoreFailure = v);
	}
}

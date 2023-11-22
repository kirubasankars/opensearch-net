/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Net;
using OpenSearch.Net.Specification.CatApi;
using OpenSearch.Net.Specification.ClusterApi;
using OpenSearch.Net.Specification.DanglingIndicesApi;
using OpenSearch.Net.Specification.FeaturesApi;
using OpenSearch.Net.Specification.IndicesApi;
using OpenSearch.Net.Specification.IngestApi;
using OpenSearch.Net.Specification.NodesApi;
using OpenSearch.Net.Specification.SnapshotApi;
using OpenSearch.Net.Specification.TasksApi;

namespace OpenSearch.Net
{
	///<summary>
	///OpenSearch low level client
	///</summary>
	public partial interface IOpenSearchLowLevelClient
	{
		///<summary>Cat APIs</summary>
		LowLevelCatNamespace Cat
		{
			get;
		}

		///<summary>Dangling Indices APIs</summary>
		LowLevelDanglingIndicesNamespace DanglingIndices
		{
			get;
		}

		///<summary>Features APIs</summary>
		LowLevelFeaturesNamespace Features
		{
			get;
		}

		///<summary>Ingest APIs</summary>
		LowLevelIngestNamespace Ingest
		{
			get;
		}

		///<summary>Nodes APIs</summary>
		LowLevelNodesNamespace Nodes
		{
			get;
		}

		///<summary>POST on /_bulk <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</para></summary>
		///<param name = "body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Bulk<TResponse>(PostData body, BulkRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_bulk <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</para></summary>
		///<param name = "body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> BulkAsync<TResponse>(PostData body, BulkRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_bulk <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</para></summary>
		///<param name = "index">Default index for items which don&#x27;t provide one</param>
		///<param name = "body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Bulk<TResponse>(string index, PostData body, BulkRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_bulk <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/bulk/</para></summary>
		///<param name = "index">Default index for items which don&#x27;t provide one</param>
		///<param name = "body">The operation definition and data (action-data pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> BulkAsync<TResponse>(string index, PostData body, BulkRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>DELETE on /_search/scroll <para>https://opensearch.org/docs/latest/opensearch/rest-api/scroll/</para></summary>
		///<param name = "body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse ClearScroll<TResponse>(PostData body, ClearScrollRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>DELETE on /_search/scroll <para>https://opensearch.org/docs/latest/opensearch/rest-api/scroll/</para></summary>
		///<param name = "body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> ClearScrollAsync<TResponse>(PostData body, ClearScrollRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_count <para>https://opensearch.org/docs/latest/opensearch/rest-api/count/</para></summary>
		///<param name = "body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Count<TResponse>(PostData body, CountRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_count <para>https://opensearch.org/docs/latest/opensearch/rest-api/count/</para></summary>
		///<param name = "body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> CountAsync<TResponse>(PostData body, CountRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_count <para>https://opensearch.org/docs/latest/opensearch/rest-api/count/</para></summary>
		///<param name = "index">A comma-separated list of indices to restrict the results</param>
		///<param name = "body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Count<TResponse>(string index, PostData body, CountRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_count <para>https://opensearch.org/docs/latest/opensearch/rest-api/count/</para></summary>
		///<param name = "index">A comma-separated list of indices to restrict the results</param>
		///<param name = "body">A query to restrict the results specified with the Query DSL (optional)</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> CountAsync<TResponse>(string index, PostData body, CountRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /{index}/_create/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">Document ID</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Create<TResponse>(string index, string id, PostData body, CreateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /{index}/_create/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">Document ID</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> CreateAsync<TResponse>(string index, string id, PostData body, CreateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>DELETE on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Delete<TResponse>(string index, string id, DeleteRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>DELETE on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> DeleteAsync<TResponse>(string index, string id, DeleteRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_delete_by_query <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse DeleteByQuery<TResponse>(string index, PostData body, DeleteByQueryRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_delete_by_query <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> DeleteByQueryAsync<TResponse>(string index, PostData body, DeleteByQueryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_delete_by_query/{task_id}/_rethrottle <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</para></summary>
		///<param name = "taskId">The task id to rethrottle</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse DeleteByQueryRethrottle<TResponse>(string taskId, DeleteByQueryRethrottleRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_delete_by_query/{task_id}/_rethrottle <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/delete-by-query/</para></summary>
		///<param name = "taskId">The task id to rethrottle</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> DeleteByQueryRethrottleAsync<TResponse>(string taskId, DeleteByQueryRethrottleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>DELETE on /_scripts/{id} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse DeleteScript<TResponse>(string id, DeleteScriptRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>DELETE on /_scripts/{id} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> DeleteScriptAsync<TResponse>(string id, DeleteScriptRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>HEAD on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse DocumentExists<TResponse>(string index, string id, DocumentExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>HEAD on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> DocumentExistsAsync<TResponse>(string index, string id, DocumentExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>HEAD on /{index}/_source/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse SourceExists<TResponse>(string index, string id, SourceExistsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>HEAD on /{index}/_source/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SourceExistsAsync<TResponse>(string index, string id, SourceExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_explain/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/explain/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "body">The query definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Explain<TResponse>(string index, string id, PostData body, ExplainRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_explain/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/explain/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "body">The query definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> ExplainAsync<TResponse>(string index, string id, PostData body, ExplainRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_field_caps <para></para></summary>
		///<param name = "body">An index filter specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse FieldCapabilities<TResponse>(PostData body, FieldCapabilitiesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_field_caps <para></para></summary>
		///<param name = "body">An index filter specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> FieldCapabilitiesAsync<TResponse>(PostData body, FieldCapabilitiesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_field_caps <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">An index filter specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse FieldCapabilities<TResponse>(string index, PostData body, FieldCapabilitiesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_field_caps <para></para></summary>
		///<param name = "index">A comma-separated list of index names; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">An index filter specified with the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> FieldCapabilitiesAsync<TResponse>(string index, PostData body, FieldCapabilitiesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Get<TResponse>(string index, string id, GetRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> GetAsync<TResponse>(string index, string id, GetRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /_scripts/{id} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse GetScript<TResponse>(string id, GetScriptRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /_scripts/{id} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> GetScriptAsync<TResponse>(string id, GetScriptRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /_script_context <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		TResponse GetScriptContext<TResponse>(GetScriptContextRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /_script_context <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		Task<TResponse> GetScriptContextAsync<TResponse>(GetScriptContextRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /_script_language <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		TResponse GetScriptLanguages<TResponse>(GetScriptLanguagesRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /_script_language <para></para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		Task<TResponse> GetScriptLanguagesAsync<TResponse>(GetScriptLanguagesRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /{index}/_source/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Source<TResponse>(string index, string id, SourceRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on /{index}/_source/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/get-documents/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">The document ID</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SourceAsync<TResponse>(string index, string id, SourceRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">Document ID</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Index<TResponse>(string index, string id, PostData body, IndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /{index}/_doc/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">Document ID</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> IndexAsync<TResponse>(string index, string id, PostData body, IndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_doc <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Index<TResponse>(string index, PostData body, IndexRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_doc <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/index-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> IndexAsync<TResponse>(string index, PostData body, IndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on / <para>https://opensearch.org/docs/latest/opensearch/index/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse RootNodeInfo<TResponse>(RootNodeInfoRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>GET on / <para>https://opensearch.org/docs/latest/opensearch/index/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> RootNodeInfoAsync<TResponse>(RootNodeInfoRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_mget <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</para></summary>
		///<param name = "body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiGet<TResponse>(PostData body, MultiGetRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_mget <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</para></summary>
		///<param name = "body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiGetAsync<TResponse>(PostData body, MultiGetRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_mget <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiGet<TResponse>(string index, PostData body, MultiGetRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_mget <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/multi-get/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiGetAsync<TResponse>(string index, PostData body, MultiGetRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_msearch <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiSearch<TResponse>(PostData body, MultiSearchRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_msearch <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiSearchAsync<TResponse>(PostData body, MultiSearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_msearch <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "index">A comma-separated list of index names to use as default</param>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiSearch<TResponse>(string index, PostData body, MultiSearchRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_msearch <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "index">A comma-separated list of index names to use as default</param>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiSearchAsync<TResponse>(string index, PostData body, MultiSearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_msearch/template <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiSearchTemplate<TResponse>(PostData body, MultiSearchTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_msearch/template <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiSearchTemplateAsync<TResponse>(PostData body, MultiSearchTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_msearch/template <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "index">A comma-separated list of index names to use as default</param>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiSearchTemplate<TResponse>(string index, PostData body, MultiSearchTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_msearch/template <para>https://opensearch.org/docs/latest/opensearch/rest-api/multi-search/</para></summary>
		///<param name = "index">A comma-separated list of index names to use as default</param>
		///<param name = "body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiSearchTemplateAsync<TResponse>(string index, PostData body, MultiSearchTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_mtermvectors <para></para></summary>
		///<param name = "body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiTermVectors<TResponse>(PostData body, MultiTermVectorsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_mtermvectors <para></para></summary>
		///<param name = "body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiTermVectorsAsync<TResponse>(PostData body, MultiTermVectorsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_mtermvectors <para></para></summary>
		///<param name = "index">The index in which the document resides.</param>
		///<param name = "body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse MultiTermVectors<TResponse>(string index, PostData body, MultiTermVectorsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_mtermvectors <para></para></summary>
		///<param name = "index">The index in which the document resides.</param>
		///<param name = "body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> MultiTermVectorsAsync<TResponse>(string index, PostData body, MultiTermVectorsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>HEAD on / <para>https://opensearch.org/docs/latest/opensearch/index/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Ping<TResponse>(PingRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>HEAD on / <para>https://opensearch.org/docs/latest/opensearch/index/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> PingAsync<TResponse>(PingRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /_scripts/{id} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse PutScript<TResponse>(string id, PostData body, PutScriptRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /_scripts/{id} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> PutScriptAsync<TResponse>(string id, PostData body, PutScriptRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /_scripts/{id}/{context} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "context">Script context</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse PutScript<TResponse>(string id, string context, PostData body, PutScriptRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>PUT on /_scripts/{id}/{context} <para></para></summary>
		///<param name = "id">Script ID</param>
		///<param name = "context">Script context</param>
		///<param name = "body">The document</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> PutScriptAsync<TResponse>(string id, string context, PostData body, PutScriptRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_rank_eval <para></para></summary>
		///<param name = "body">The ranking evaluation search definition, including search requests, document ratings and ranking metric definition.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		TResponse RankEval<TResponse>(PostData body, RankEvalRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_rank_eval <para></para></summary>
		///<param name = "body">The ranking evaluation search definition, including search requests, document ratings and ranking metric definition.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		Task<TResponse> RankEvalAsync<TResponse>(PostData body, RankEvalRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_rank_eval <para></para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The ranking evaluation search definition, including search requests, document ratings and ranking metric definition.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		TResponse RankEval<TResponse>(string index, PostData body, RankEvalRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_rank_eval <para></para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The ranking evaluation search definition, including search requests, document ratings and ranking metric definition.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		Task<TResponse> RankEvalAsync<TResponse>(string index, PostData body, RankEvalRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_reindex <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</para></summary>
		///<param name = "body">The search definition using the Query DSL and the prototype for the index request.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse ReindexOnServer<TResponse>(PostData body, ReindexOnServerRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_reindex <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</para></summary>
		///<param name = "body">The search definition using the Query DSL and the prototype for the index request.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> ReindexOnServerAsync<TResponse>(PostData body, ReindexOnServerRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_reindex/{task_id}/_rethrottle <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</para></summary>
		///<param name = "taskId">The task id to rethrottle</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse ReindexRethrottle<TResponse>(string taskId, ReindexRethrottleRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_reindex/{task_id}/_rethrottle <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/reindex/</para></summary>
		///<param name = "taskId">The task id to rethrottle</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> ReindexRethrottleAsync<TResponse>(string taskId, ReindexRethrottleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_render/template <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse RenderSearchTemplate<TResponse>(PostData body, RenderSearchTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_render/template <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> RenderSearchTemplateAsync<TResponse>(PostData body, RenderSearchTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_render/template/{id} <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "id">The id of the stored search template</param>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse RenderSearchTemplate<TResponse>(string id, PostData body, RenderSearchTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_render/template/{id} <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "id">The id of the stored search template</param>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> RenderSearchTemplateAsync<TResponse>(string id, PostData body, RenderSearchTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_scripts/painless/_execute <para></para></summary>
		///<param name = "body">The script to execute</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		TResponse ExecutePainlessScript<TResponse>(PostData body, ExecutePainlessScriptRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_scripts/painless/_execute <para></para></summary>
		///<param name = "body">The script to execute</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		///<remarks>Note: Experimental within the OpenSearch server, this functionality is Experimental and may be changed or removed completely in a future release. OpenSearch will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features. This functionality is subject to potential breaking changes within a minor version, meaning that your referencing code may break when this library is upgraded.</remarks>
		Task<TResponse> ExecutePainlessScriptAsync<TResponse>(PostData body, ExecutePainlessScriptRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search/scroll <para>https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</para></summary>
		///<param name = "body">The scroll ID if not passed by URL or query parameter.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Scroll<TResponse>(PostData body, ScrollRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search/scroll <para>https://opensearch.org/docs/latest/opensearch/rest-api/search/#request-body</para></summary>
		///<param name = "body">The scroll ID if not passed by URL or query parameter.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> ScrollAsync<TResponse>(PostData body, ScrollRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search <para>https://opensearch.org/docs/latest/opensearch/rest-api/search/</para></summary>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Search<TResponse>(PostData body, SearchRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search <para>https://opensearch.org/docs/latest/opensearch/rest-api/search/</para></summary>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SearchAsync<TResponse>(PostData body, SearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_search <para>https://opensearch.org/docs/latest/opensearch/rest-api/search/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Search<TResponse>(string index, PostData body, SearchRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_search <para>https://opensearch.org/docs/latest/opensearch/rest-api/search/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SearchAsync<TResponse>(string index, PostData body, SearchRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search_shards <para>https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse SearchShards<TResponse>(SearchShardsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search_shards <para>https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SearchShardsAsync<TResponse>(SearchShardsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_search_shards <para>https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse SearchShards<TResponse>(string index, SearchShardsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_search_shards <para>https://opensearch.org/docs/latest/security-plugin/access-control/cross-cluster-search/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SearchShardsAsync<TResponse>(string index, SearchShardsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search/template <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse SearchTemplate<TResponse>(PostData body, SearchTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_search/template <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SearchTemplateAsync<TResponse>(PostData body, SearchTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_search/template <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse SearchTemplate<TResponse>(string index, PostData body, SearchTemplateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_search/template <para>https://opensearch.org/docs/latest/opensearch/search-template/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition template and its params</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> SearchTemplateAsync<TResponse>(string index, PostData body, SearchTemplateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_termvectors/{id} <para></para></summary>
		///<param name = "index">The index in which the document resides.</param>
		///<param name = "id">The id of the document, when not specified a doc param should be supplied.</param>
		///<param name = "body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse TermVectors<TResponse>(string index, string id, PostData body, TermVectorsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_termvectors/{id} <para></para></summary>
		///<param name = "index">The index in which the document resides.</param>
		///<param name = "id">The id of the document, when not specified a doc param should be supplied.</param>
		///<param name = "body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> TermVectorsAsync<TResponse>(string index, string id, PostData body, TermVectorsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_termvectors <para></para></summary>
		///<param name = "index">The index in which the document resides.</param>
		///<param name = "body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse TermVectors<TResponse>(string index, PostData body, TermVectorsRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_termvectors <para></para></summary>
		///<param name = "index">The index in which the document resides.</param>
		///<param name = "body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> TermVectorsAsync<TResponse>(string index, PostData body, TermVectorsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_update/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">Document ID</param>
		///<param name = "body">The request definition requires either `script` or partial `doc`</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse Update<TResponse>(string index, string id, PostData body, UpdateRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_update/{id} <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-document/</para></summary>
		///<param name = "index">The name of the index</param>
		///<param name = "id">Document ID</param>
		///<param name = "body">The request definition requires either `script` or partial `doc`</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> UpdateAsync<TResponse>(string index, string id, PostData body, UpdateRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_update_by_query <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse UpdateByQuery<TResponse>(string index, PostData body, UpdateByQueryRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /{index}/_update_by_query <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</para></summary>
		///<param name = "index">A comma-separated list of index names to search; use the special string `_all` or Indices.All to perform the operation on all indices</param>
		///<param name = "body">The search definition using the Query DSL</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> UpdateByQueryAsync<TResponse>(string index, PostData body, UpdateByQueryRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_update_by_query/{task_id}/_rethrottle <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</para></summary>
		///<param name = "taskId">The task id to rethrottle</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		TResponse UpdateByQueryRethrottle<TResponse>(string taskId, UpdateByQueryRethrottleRequestParameters requestParameters = null)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>POST on /_update_by_query/{task_id}/_rethrottle <para>https://opensearch.org/docs/latest/opensearch/rest-api/document-apis/update-by-query/</para></summary>
		///<param name = "taskId">The task id to rethrottle</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		Task<TResponse> UpdateByQueryRethrottleAsync<TResponse>(string taskId, UpdateByQueryRethrottleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IOpenSearchResponse, new();
		///<summary>Snapshot APIs</summary>
		LowLevelSnapshotNamespace Snapshot
		{
			get;
		}

		///<summary>Tasks APIs</summary>
		LowLevelTasksNamespace Tasks
		{
			get;
		}
	}
}

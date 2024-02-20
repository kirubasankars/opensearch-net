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
*   http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
//      *NIX        :   ./build.sh codegen
//      Windows     :   build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using OpenSearch.Client;
using OpenSearch.Client.Specification.CatApi;
using OpenSearch.Client.Specification.ClusterApi;
using OpenSearch.Client.Specification.DanglingIndicesApi;
using OpenSearch.Client.Specification.HttpApi;
using OpenSearch.Client.Specification.IndicesApi;
using OpenSearch.Client.Specification.IngestApi;
using OpenSearch.Client.Specification.NodesApi;
using OpenSearch.Client.Specification.SnapshotApi;
using OpenSearch.Client.Specification.TasksApi;

namespace OpenSearch.Client
{
    /// <summary>
    /// OpenSearch high level client
    /// </summary>
    public partial interface IOpenSearchClient
    {
        /// <summary>Cat APIs</summary>
        CatNamespace Cat { get; }

        /// <summary>Cluster APIs</summary>
        ClusterNamespace Cluster { get; }

        /// <summary>Dangling Indices APIs</summary>
        DanglingIndicesNamespace DanglingIndices { get; }

        /// <summary>Indices APIs</summary>
        IndicesNamespace Indices { get; }

        /// <summary>Ingest APIs</summary>
        IngestNamespace Ingest { get; }

        /// <summary>Nodes APIs</summary>
        NodesNamespace Nodes { get; }

        /// <summary>Http APIs</summary>
        HttpNamespace Http { get; }

        /// <summary>Snapshot APIs</summary>
        SnapshotNamespace Snapshot { get; }

        /// <summary>Tasks APIs</summary>
        TasksNamespace Tasks { get; }

        /// <summary>
        /// <c>POST</c> request to the <c>create_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        CreatePitResponse CreatePit(
            Indices index,
            Func<CreatePitDescriptor, ICreatePitRequest> selector = null
        );

        /// <summary>
        /// <c>POST</c> request to the <c>create_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<CreatePitResponse> CreatePitAsync(
            Indices index,
            Func<CreatePitDescriptor, ICreatePitRequest> selector = null,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>POST</c> request to the <c>create_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        CreatePitResponse CreatePit(ICreatePitRequest request);

        /// <summary>
        /// <c>POST</c> request to the <c>create_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#create-a-pit</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<CreatePitResponse> CreatePitAsync(
            ICreatePitRequest request,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        DeleteAllPitsResponse DeleteAllPits(
            Func<DeleteAllPitsDescriptor, IDeleteAllPitsRequest> selector = null
        );

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<DeleteAllPitsResponse> DeleteAllPitsAsync(
            Func<DeleteAllPitsDescriptor, IDeleteAllPitsRequest> selector = null,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        DeleteAllPitsResponse DeleteAllPits(IDeleteAllPitsRequest request);

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<DeleteAllPitsResponse> DeleteAllPitsAsync(
            IDeleteAllPitsRequest request,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        DeletePitResponse DeletePit(Func<DeletePitDescriptor, IDeletePitRequest> selector = null);

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<DeletePitResponse> DeletePitAsync(
            Func<DeletePitDescriptor, IDeletePitRequest> selector = null,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        DeletePitResponse DeletePit(IDeletePitRequest request);

        /// <summary>
        /// <c>DELETE</c> request to the <c>delete_pit</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#delete-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<DeletePitResponse> DeletePitAsync(
            IDeletePitRequest request,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>GET</c> request to the <c>get_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        GetAllPitsResponse GetAllPits(
            Func<GetAllPitsDescriptor, IGetAllPitsRequest> selector = null
        );

        /// <summary>
        /// <c>GET</c> request to the <c>get_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<GetAllPitsResponse> GetAllPitsAsync(
            Func<GetAllPitsDescriptor, IGetAllPitsRequest> selector = null,
            CancellationToken ct = default
        );

        /// <summary>
        /// <c>GET</c> request to the <c>get_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        GetAllPitsResponse GetAllPits(IGetAllPitsRequest request);

        /// <summary>
        /// <c>GET</c> request to the <c>get_all_pits</c> API, read more about this API online:
        /// <para></para>
        /// <a href="https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits">https://opensearch.org/docs/latest/search-plugins/point-in-time-api/#list-all-pits</a>
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.4.0 or greater.</remarks>
        Task<GetAllPitsResponse> GetAllPitsAsync(
            IGetAllPitsRequest request,
            CancellationToken ct = default
        );
    }
}

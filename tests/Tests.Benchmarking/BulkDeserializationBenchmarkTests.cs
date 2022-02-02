/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*
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

using System.IO;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using OpenSearch.Net;
using Nest;
using Newtonsoft.Json;
using Tests.Benchmarking.Framework;
using Tests.Core.Client;

namespace Tests.Benchmarking
{
	[BenchmarkConfig]
	public class BulkDeserializationBenchmarkTests
	{
		private static readonly IOpenSearchClient Client = TestClient.DefaultInMemoryClient;
		private byte[] _hugeResponse;
		private JsonSerializer _jsonSerializer;
		private byte[] _largeResponse;
		private byte[] _mediumResponse;
		private byte[] _tinyResponse;

		[GlobalSetup]
		public void Setup()
		{
			var serializer = Client.RequestResponseSerializer;
			_tinyResponse = serializer.SerializeToBytes(ReturnBulkResponse(1));
			_mediumResponse = serializer.SerializeToBytes(ReturnBulkResponse(100));
			_largeResponse = serializer.SerializeToBytes(ReturnBulkResponse(1000));
			_hugeResponse = serializer.SerializeToBytes(ReturnBulkResponse(100000));

			_jsonSerializer = new JsonSerializer();
		}

		[Benchmark(Description = "deserialize 1 item in bulk response")]
		public BulkResponse TinyResponse()
		{
			using (var ms = new MemoryStream(_tinyResponse))
				return Client.RequestResponseSerializer.Deserialize<BulkResponse>(ms);
		}

		[Benchmark(Description = "deserialize 100 items in bulk response")]
		public BulkResponse MediumResponse()
		{
			using (var ms = new MemoryStream(_mediumResponse))
				return Client.RequestResponseSerializer.Deserialize<BulkResponse>(ms);
		}

		[Benchmark(Description = "deserialize 1,000 items in bulk response")]
		public BulkResponse LargeResponse()
		{
			using (var ms = new MemoryStream(_largeResponse))
				return Client.RequestResponseSerializer.Deserialize<BulkResponse>(ms);
		}

		[Benchmark(Description = "deserialize 100,000 items in bulk response")]
		public BulkResponse HugeResponse()
		{
			using (var ms = new MemoryStream(_hugeResponse))
				return Client.RequestResponseSerializer.Deserialize<BulkResponse>(ms);
		}

		[Benchmark(Description = "deserialize 100,000 items in bulk response")]
		public BulkResponse HugeResponseWithStream()
		{
			using (var ms = new JsonTextReader(new StreamReader(new MemoryStream(_hugeResponse))))
				return _jsonSerializer.Deserialize<BulkResponse>(ms);
		}

		[Benchmark(Description = "deserialize 100,000 items in bulk string response")]
		public BulkResponse HugeResponseWithString()
		{
			using (var reader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(_hugeResponse))))
				return _jsonSerializer.Deserialize<BulkResponse>(reader);
		}

		[Benchmark(Description = "Baseline", Baseline = true)]
		public BulkResponse Baseline()
		{
			using (var reader = new JsonTextReader(new StreamReader(new MemoryStream(_hugeResponse))))
			{
				while (reader.Read()) { }

				return new BulkResponse();
			}
		}

		private static object BulkItemResponse() => new
		{
			index = new
			{
				_index = "nest-52cfd7aa",
				_type = "project",
				_id = "Kuhn LLC",
				_version = 1,
				_shards = new
				{
					total = 2,
					successful = 1,
					failed = 0
				},
				created = true,
				status = 201
			}
		};

		private static object ReturnBulkResponse(int numberOfItems) => new
		{
			took = 276,
			errors = false,
			items = Enumerable.Range(0, numberOfItems)
				.Select(i => BulkItemResponse())
				.ToArray()
		};
	}
}

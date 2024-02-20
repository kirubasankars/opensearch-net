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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace OpenSearch.Net
{
    [Flags, StringEnum]
    public enum ClusterStateMetric
    {
        [EnumMember(Value = "blocks")]
        Blocks = 1 << 0,

        [EnumMember(Value = "metadata")]
        Metadata = 1 << 1,

        [EnumMember(Value = "nodes")]
        Nodes = 1 << 2,

        [EnumMember(Value = "routing_table")]
        RoutingTable = 1 << 3,

        [EnumMember(Value = "routing_nodes")]
        RoutingNodes = 1 << 4,

        [EnumMember(Value = "master_node")]
        MasterNode = 1 << 5,

        [EnumMember(Value = "cluster_manager_node")]
        ClusterManagerNode = 1 << 6,

        [EnumMember(Value = "version")]
        Version = 1 << 7,

        [EnumMember(Value = "_all")]
        All = 1 << 8
    }

    [Flags, StringEnum]
    public enum NodesInfoMetric
    {
        [EnumMember(Value = "settings")]
        Settings = 1 << 0,

        [EnumMember(Value = "os")]
        Os = 1 << 1,

        [EnumMember(Value = "process")]
        Process = 1 << 2,

        [EnumMember(Value = "jvm")]
        Jvm = 1 << 3,

        [EnumMember(Value = "thread_pool")]
        ThreadPool = 1 << 4,

        [EnumMember(Value = "transport")]
        Transport = 1 << 5,

        [EnumMember(Value = "http")]
        Http = 1 << 6,

        [EnumMember(Value = "plugins")]
        Plugins = 1 << 7,

        [EnumMember(Value = "ingest")]
        Ingest = 1 << 8
    }

    [Flags, StringEnum]
    public enum NodesStatsIndexMetric
    {
        [EnumMember(Value = "store")]
        Store = 1 << 0,

        [EnumMember(Value = "indexing")]
        Indexing = 1 << 1,

        [EnumMember(Value = "get")]
        Get = 1 << 2,

        [EnumMember(Value = "search")]
        Search = 1 << 3,

        [EnumMember(Value = "merge")]
        Merge = 1 << 4,

        [EnumMember(Value = "flush")]
        Flush = 1 << 5,

        [EnumMember(Value = "refresh")]
        Refresh = 1 << 6,

        [EnumMember(Value = "query_cache")]
        QueryCache = 1 << 7,

        [EnumMember(Value = "fielddata")]
        Fielddata = 1 << 8,

        [EnumMember(Value = "docs")]
        Docs = 1 << 9,

        [EnumMember(Value = "warmer")]
        Warmer = 1 << 10,

        [EnumMember(Value = "completion")]
        Completion = 1 << 11,

        [EnumMember(Value = "segments")]
        Segments = 1 << 12,

        [EnumMember(Value = "translog")]
        Translog = 1 << 13,

        [EnumMember(Value = "suggest")]
        Suggest = 1 << 14,

        [EnumMember(Value = "request_cache")]
        RequestCache = 1 << 15,

        [EnumMember(Value = "recovery")]
        Recovery = 1 << 16,

        [EnumMember(Value = "_all")]
        All = 1 << 17
    }

    [Flags, StringEnum]
    public enum NodesStatsMetric
    {
        [EnumMember(Value = "breaker")]
        Breaker = 1 << 0,

        [EnumMember(Value = "fs")]
        Fs = 1 << 1,

        [EnumMember(Value = "http")]
        Http = 1 << 2,

        [EnumMember(Value = "indices")]
        Indices = 1 << 3,

        [EnumMember(Value = "jvm")]
        Jvm = 1 << 4,

        [EnumMember(Value = "os")]
        Os = 1 << 5,

        [EnumMember(Value = "process")]
        Process = 1 << 6,

        [EnumMember(Value = "thread_pool")]
        ThreadPool = 1 << 7,

        [EnumMember(Value = "transport")]
        Transport = 1 << 8,

        [EnumMember(Value = "discovery")]
        Discovery = 1 << 9,

        [EnumMember(Value = "indexing_pressure")]
        IndexingPressure = 1 << 10,

        [EnumMember(Value = "search_pipeline")]
        SearchPipeline = 1 << 11,

        [EnumMember(Value = "_all")]
        All = 1 << 12
    }

    [Flags, StringEnum]
    public enum NodesUsageMetric
    {
        [EnumMember(Value = "rest_actions")]
        RestActions = 1 << 0,

        [EnumMember(Value = "_all")]
        All = 1 << 1
    }

    [StringEnum]
    public enum ExpandWildcards
    {
        [EnumMember(Value = "all")]
        All,

        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "hidden")]
        Hidden,

        [EnumMember(Value = "none")]
        None
    }

    [StringEnum]
    public enum Bytes
    {
        [EnumMember(Value = "b")]
        B,

        [EnumMember(Value = "k")]
        K,

        [EnumMember(Value = "kb")]
        Kb,

        [EnumMember(Value = "m")]
        M,

        [EnumMember(Value = "mb")]
        Mb,

        [EnumMember(Value = "g")]
        G,

        [EnumMember(Value = "gb")]
        Gb,

        [EnumMember(Value = "t")]
        T,

        [EnumMember(Value = "tb")]
        Tb,

        [EnumMember(Value = "p")]
        P,

        [EnumMember(Value = "pb")]
        Pb
    }

    [StringEnum]
    public enum Health
    {
        [EnumMember(Value = "green")]
        Green,

        [EnumMember(Value = "yellow")]
        Yellow,

        [EnumMember(Value = "red")]
        Red
    }

    [StringEnum]
    public enum ClusterHealthLevel
    {
        [EnumMember(Value = "cluster")]
        Cluster,

        [EnumMember(Value = "indices")]
        Indices,

        [EnumMember(Value = "shards")]
        Shards,

        [EnumMember(Value = "awareness_attributes")]
        AwarenessAttributes
    }

    [StringEnum]
    public enum WaitForEvents
    {
        [EnumMember(Value = "immediate")]
        Immediate,

        [EnumMember(Value = "urgent")]
        Urgent,

        [EnumMember(Value = "high")]
        High,

        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "low")]
        Low,

        [EnumMember(Value = "languid")]
        Languid
    }

    [StringEnum]
    public enum WaitForStatus
    {
        [EnumMember(Value = "green")]
        Green,

        [EnumMember(Value = "yellow")]
        Yellow,

        [EnumMember(Value = "red")]
        Red
    }

    [StringEnum]
    public enum SampleType
    {
        [EnumMember(Value = "cpu")]
        Cpu,

        [EnumMember(Value = "wait")]
        Wait,

        [EnumMember(Value = "block")]
        Block
    }

    [StringEnum]
    public enum NodesStatLevel
    {
        [EnumMember(Value = "indices")]
        Indices,

        [EnumMember(Value = "node")]
        Node,

        [EnumMember(Value = "shards")]
        Shards
    }

    [StringEnum]
    public enum GroupBy
    {
        [EnumMember(Value = "nodes")]
        Nodes,

        [EnumMember(Value = "parents")]
        Parents,

        [EnumMember(Value = "none")]
        None
    }

    public static partial class KnownEnums
    {
        static partial void RegisterEnumStringResolvers()
        {
            EnumStringResolvers.TryAdd(
                typeof(ClusterStateMetric),
                e => GetStringValue((ClusterStateMetric)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(NodesInfoMetric),
                e => GetStringValue((NodesInfoMetric)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(NodesStatsIndexMetric),
                e => GetStringValue((NodesStatsIndexMetric)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(NodesStatsMetric),
                e => GetStringValue((NodesStatsMetric)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(NodesUsageMetric),
                e => GetStringValue((NodesUsageMetric)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(ExpandWildcards),
                e => GetStringValue((ExpandWildcards)e)
            );
            EnumStringResolvers.TryAdd(typeof(Bytes), e => GetStringValue((Bytes)e));
            EnumStringResolvers.TryAdd(typeof(Health), e => GetStringValue((Health)e));
            EnumStringResolvers.TryAdd(
                typeof(ClusterHealthLevel),
                e => GetStringValue((ClusterHealthLevel)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(WaitForEvents),
                e => GetStringValue((WaitForEvents)e)
            );
            EnumStringResolvers.TryAdd(
                typeof(WaitForStatus),
                e => GetStringValue((WaitForStatus)e)
            );
            EnumStringResolvers.TryAdd(typeof(SampleType), e => GetStringValue((SampleType)e));
            EnumStringResolvers.TryAdd(
                typeof(NodesStatLevel),
                e => GetStringValue((NodesStatLevel)e)
            );
            EnumStringResolvers.TryAdd(typeof(GroupBy), e => GetStringValue((GroupBy)e));
        }

        public static string GetStringValue(this ClusterStateMetric enumValue)
        {
            if ((enumValue & ClusterStateMetric.All) != 0)
                return "_all";
            var list = new List<string>();
            if ((enumValue & ClusterStateMetric.Blocks) != 0)
                list.Add("blocks");
            if ((enumValue & ClusterStateMetric.Metadata) != 0)
                list.Add("metadata");
            if ((enumValue & ClusterStateMetric.Nodes) != 0)
                list.Add("nodes");
            if ((enumValue & ClusterStateMetric.RoutingTable) != 0)
                list.Add("routing_table");
            if ((enumValue & ClusterStateMetric.RoutingNodes) != 0)
                list.Add("routing_nodes");
            if ((enumValue & ClusterStateMetric.MasterNode) != 0)
                list.Add("master_node");
            if ((enumValue & ClusterStateMetric.ClusterManagerNode) != 0)
                list.Add("cluster_manager_node");
            if ((enumValue & ClusterStateMetric.Version) != 0)
                list.Add("version");
            return string.Join(",", list);
        }

        public static string GetStringValue(this NodesInfoMetric enumValue)
        {
            var list = new List<string>();
            if ((enumValue & NodesInfoMetric.Settings) != 0)
                list.Add("settings");
            if ((enumValue & NodesInfoMetric.Os) != 0)
                list.Add("os");
            if ((enumValue & NodesInfoMetric.Process) != 0)
                list.Add("process");
            if ((enumValue & NodesInfoMetric.Jvm) != 0)
                list.Add("jvm");
            if ((enumValue & NodesInfoMetric.ThreadPool) != 0)
                list.Add("thread_pool");
            if ((enumValue & NodesInfoMetric.Transport) != 0)
                list.Add("transport");
            if ((enumValue & NodesInfoMetric.Http) != 0)
                list.Add("http");
            if ((enumValue & NodesInfoMetric.Plugins) != 0)
                list.Add("plugins");
            if ((enumValue & NodesInfoMetric.Ingest) != 0)
                list.Add("ingest");
            return string.Join(",", list);
        }

        public static string GetStringValue(this NodesStatsIndexMetric enumValue)
        {
            if ((enumValue & NodesStatsIndexMetric.All) != 0)
                return "_all";
            var list = new List<string>();
            if ((enumValue & NodesStatsIndexMetric.Store) != 0)
                list.Add("store");
            if ((enumValue & NodesStatsIndexMetric.Indexing) != 0)
                list.Add("indexing");
            if ((enumValue & NodesStatsIndexMetric.Get) != 0)
                list.Add("get");
            if ((enumValue & NodesStatsIndexMetric.Search) != 0)
                list.Add("search");
            if ((enumValue & NodesStatsIndexMetric.Merge) != 0)
                list.Add("merge");
            if ((enumValue & NodesStatsIndexMetric.Flush) != 0)
                list.Add("flush");
            if ((enumValue & NodesStatsIndexMetric.Refresh) != 0)
                list.Add("refresh");
            if ((enumValue & NodesStatsIndexMetric.QueryCache) != 0)
                list.Add("query_cache");
            if ((enumValue & NodesStatsIndexMetric.Fielddata) != 0)
                list.Add("fielddata");
            if ((enumValue & NodesStatsIndexMetric.Docs) != 0)
                list.Add("docs");
            if ((enumValue & NodesStatsIndexMetric.Warmer) != 0)
                list.Add("warmer");
            if ((enumValue & NodesStatsIndexMetric.Completion) != 0)
                list.Add("completion");
            if ((enumValue & NodesStatsIndexMetric.Segments) != 0)
                list.Add("segments");
            if ((enumValue & NodesStatsIndexMetric.Translog) != 0)
                list.Add("translog");
            if ((enumValue & NodesStatsIndexMetric.Suggest) != 0)
                list.Add("suggest");
            if ((enumValue & NodesStatsIndexMetric.RequestCache) != 0)
                list.Add("request_cache");
            if ((enumValue & NodesStatsIndexMetric.Recovery) != 0)
                list.Add("recovery");
            return string.Join(",", list);
        }

        public static string GetStringValue(this NodesStatsMetric enumValue)
        {
            if ((enumValue & NodesStatsMetric.All) != 0)
                return "_all";
            var list = new List<string>();
            if ((enumValue & NodesStatsMetric.Breaker) != 0)
                list.Add("breaker");
            if ((enumValue & NodesStatsMetric.Fs) != 0)
                list.Add("fs");
            if ((enumValue & NodesStatsMetric.Http) != 0)
                list.Add("http");
            if ((enumValue & NodesStatsMetric.Indices) != 0)
                list.Add("indices");
            if ((enumValue & NodesStatsMetric.Jvm) != 0)
                list.Add("jvm");
            if ((enumValue & NodesStatsMetric.Os) != 0)
                list.Add("os");
            if ((enumValue & NodesStatsMetric.Process) != 0)
                list.Add("process");
            if ((enumValue & NodesStatsMetric.ThreadPool) != 0)
                list.Add("thread_pool");
            if ((enumValue & NodesStatsMetric.Transport) != 0)
                list.Add("transport");
            if ((enumValue & NodesStatsMetric.Discovery) != 0)
                list.Add("discovery");
            if ((enumValue & NodesStatsMetric.IndexingPressure) != 0)
                list.Add("indexing_pressure");
            if ((enumValue & NodesStatsMetric.SearchPipeline) != 0)
                list.Add("search_pipeline");
            return string.Join(",", list);
        }

        public static string GetStringValue(this NodesUsageMetric enumValue)
        {
            if ((enumValue & NodesUsageMetric.All) != 0)
                return "_all";
            var list = new List<string>();
            if ((enumValue & NodesUsageMetric.RestActions) != 0)
                list.Add("rest_actions");
            return string.Join(",", list);
        }

        public static string GetStringValue(this ExpandWildcards enumValue)
        {
            switch (enumValue)
            {
                case ExpandWildcards.All:
                    return "all";
                case ExpandWildcards.Open:
                    return "open";
                case ExpandWildcards.Closed:
                    return "closed";
                case ExpandWildcards.Hidden:
                    return "hidden";
                case ExpandWildcards.None:
                    return "none";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'ExpandWildcards'"
            );
        }

        public static string GetStringValue(this Bytes enumValue)
        {
            switch (enumValue)
            {
                case Bytes.B:
                    return "b";
                case Bytes.K:
                    return "k";
                case Bytes.Kb:
                    return "kb";
                case Bytes.M:
                    return "m";
                case Bytes.Mb:
                    return "mb";
                case Bytes.G:
                    return "g";
                case Bytes.Gb:
                    return "gb";
                case Bytes.T:
                    return "t";
                case Bytes.Tb:
                    return "tb";
                case Bytes.P:
                    return "p";
                case Bytes.Pb:
                    return "pb";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'Bytes'"
            );
        }

        public static string GetStringValue(this Health enumValue)
        {
            switch (enumValue)
            {
                case Health.Green:
                    return "green";
                case Health.Yellow:
                    return "yellow";
                case Health.Red:
                    return "red";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'Health'"
            );
        }

        public static string GetStringValue(this ClusterHealthLevel enumValue)
        {
            switch (enumValue)
            {
                case ClusterHealthLevel.Cluster:
                    return "cluster";
                case ClusterHealthLevel.Indices:
                    return "indices";
                case ClusterHealthLevel.Shards:
                    return "shards";
                case ClusterHealthLevel.AwarenessAttributes:
                    return "awareness_attributes";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'ClusterHealthLevel'"
            );
        }

        public static string GetStringValue(this WaitForEvents enumValue)
        {
            switch (enumValue)
            {
                case WaitForEvents.Immediate:
                    return "immediate";
                case WaitForEvents.Urgent:
                    return "urgent";
                case WaitForEvents.High:
                    return "high";
                case WaitForEvents.Normal:
                    return "normal";
                case WaitForEvents.Low:
                    return "low";
                case WaitForEvents.Languid:
                    return "languid";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'WaitForEvents'"
            );
        }

        public static string GetStringValue(this WaitForStatus enumValue)
        {
            switch (enumValue)
            {
                case WaitForStatus.Green:
                    return "green";
                case WaitForStatus.Yellow:
                    return "yellow";
                case WaitForStatus.Red:
                    return "red";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'WaitForStatus'"
            );
        }

        public static string GetStringValue(this SampleType enumValue)
        {
            switch (enumValue)
            {
                case SampleType.Cpu:
                    return "cpu";
                case SampleType.Wait:
                    return "wait";
                case SampleType.Block:
                    return "block";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'SampleType'"
            );
        }

        public static string GetStringValue(this NodesStatLevel enumValue)
        {
            switch (enumValue)
            {
                case NodesStatLevel.Indices:
                    return "indices";
                case NodesStatLevel.Node:
                    return "node";
                case NodesStatLevel.Shards:
                    return "shards";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'NodesStatLevel'"
            );
        }

        public static string GetStringValue(this GroupBy enumValue)
        {
            switch (enumValue)
            {
                case GroupBy.Nodes:
                    return "nodes";
                case GroupBy.Parents:
                    return "parents";
                case GroupBy.None:
                    return "none";
            }
            throw new ArgumentException(
                $"'{enumValue.ToString()}' is not a valid value for enum 'GroupBy'"
            );
        }
    }
}

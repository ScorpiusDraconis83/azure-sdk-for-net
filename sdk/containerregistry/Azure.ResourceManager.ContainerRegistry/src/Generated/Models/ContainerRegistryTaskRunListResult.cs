// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The collection of task runs. </summary>
    internal partial class ContainerRegistryTaskRunListResult
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunListResult"/>. </summary>
        internal ContainerRegistryTaskRunListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryTaskRunData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskRunListResult"/>. </summary>
        /// <param name="value"> The collection value. </param>
        /// <param name="nextLink"> The URI that can be used to request the next set of paged results. </param>
        internal ContainerRegistryTaskRunListResult(IReadOnlyList<ContainerRegistryTaskRunData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection value. </summary>
        public IReadOnlyList<ContainerRegistryTaskRunData> Value { get; }
        /// <summary> The URI that can be used to request the next set of paged results. </summary>
        public string NextLink { get; }
    }
}

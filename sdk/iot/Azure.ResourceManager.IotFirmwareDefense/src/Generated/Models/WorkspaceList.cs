// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotFirmwareDefense;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Return a list of firmware analysis workspaces. </summary>
    internal partial class WorkspaceList
    {
        /// <summary> Initializes a new instance of <see cref="WorkspaceList"/>. </summary>
        internal WorkspaceList()
        {
            Value = new ChangeTrackingList<FirmwareWorkspaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceList"/>. </summary>
        /// <param name="value"> The list of firmware analysis workspaces. </param>
        /// <param name="nextLink"> The uri to fetch the next page of asset. </param>
        internal WorkspaceList(IReadOnlyList<FirmwareWorkspaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of firmware analysis workspaces. </summary>
        public IReadOnlyList<FirmwareWorkspaceData> Value { get; }
        /// <summary> The uri to fetch the next page of asset. </summary>
        public string NextLink { get; }
    }
}

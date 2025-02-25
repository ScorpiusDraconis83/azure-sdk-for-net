// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> The response of a DeviceGroup list operation. </summary>
    internal partial class DeviceGroupListResult
    {
        /// <summary> Initializes a new instance of <see cref="DeviceGroupListResult"/>. </summary>
        /// <param name="value"> The DeviceGroup items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DeviceGroupListResult(IEnumerable<SphereDeviceGroupData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceGroupListResult"/>. </summary>
        /// <param name="value"> The DeviceGroup items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal DeviceGroupListResult(IReadOnlyList<SphereDeviceGroupData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The DeviceGroup items on this page. </summary>
        public IReadOnlyList<SphereDeviceGroupData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}

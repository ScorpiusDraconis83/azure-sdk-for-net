// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Cross tenant scopes. </summary>
    public partial class CrossTenantScopes
    {
        /// <summary> Initializes a new instance of <see cref="CrossTenantScopes"/>. </summary>
        internal CrossTenantScopes()
        {
            ManagementGroups = new ChangeTrackingList<string>();
            Subscriptions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CrossTenantScopes"/>. </summary>
        /// <param name="tenantId"> Tenant ID. </param>
        /// <param name="managementGroups"> List of management groups. </param>
        /// <param name="subscriptions"> List of subscriptions. </param>
        internal CrossTenantScopes(Guid? tenantId, IReadOnlyList<string> managementGroups, IReadOnlyList<string> subscriptions)
        {
            TenantId = tenantId;
            ManagementGroups = managementGroups;
            Subscriptions = subscriptions;
        }

        /// <summary> Tenant ID. </summary>
        public Guid? TenantId { get; }
        /// <summary> List of management groups. </summary>
        public IReadOnlyList<string> ManagementGroups { get; }
        /// <summary> List of subscriptions. </summary>
        public IReadOnlyList<string> Subscriptions { get; }
    }
}

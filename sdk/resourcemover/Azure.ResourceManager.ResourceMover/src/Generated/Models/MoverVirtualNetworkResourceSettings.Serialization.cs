// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverVirtualNetworkResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
            if (Optional.IsDefined(EnableDdosProtection))
            {
                if (EnableDdosProtection != null)
                {
                    writer.WritePropertyName("enableDdosProtection"u8);
                    writer.WriteBooleanValue(EnableDdosProtection.Value);
                }
                else
                {
                    writer.WriteNull("enableDdosProtection");
                }
            }
            if (Optional.IsCollectionDefined(AddressSpace))
            {
                if (AddressSpace != null)
                {
                    writer.WritePropertyName("addressSpace"u8);
                    writer.WriteStartArray();
                    foreach (var item in AddressSpace)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("addressSpace");
                }
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                if (DnsServers != null)
                {
                    writer.WritePropertyName("dnsServers"u8);
                    writer.WriteStartArray();
                    foreach (var item in DnsServers)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dnsServers");
                }
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                if (Subnets != null)
                {
                    writer.WritePropertyName("subnets"u8);
                    writer.WriteStartArray();
                    foreach (var item in Subnets)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("subnets");
                }
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
            }
            writer.WriteEndObject();
        }

        internal static MoverVirtualNetworkResourceSettings DeserializeMoverVirtualNetworkResourceSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<bool?> enableDdosProtection = default;
            Optional<IList<string>> addressSpace = default;
            Optional<IList<string>> dnsServers = default;
            Optional<IList<SubnetResourceSettings>> subnets = default;
            string resourceType = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroupName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("enableDdosProtection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableDdosProtection = null;
                        continue;
                    }
                    enableDdosProtection = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("addressSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        addressSpace = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressSpace = array;
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dnsServers = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("subnets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnets = null;
                        continue;
                    }
                    List<SubnetResourceSettings> array = new List<SubnetResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubnetResourceSettings.DeserializeSubnetResourceSettings(item));
                    }
                    subnets = array;
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
            }
            return new MoverVirtualNetworkResourceSettings(resourceType, targetResourceName.Value, targetResourceGroupName.Value, Optional.ToDictionary(tags), Optional.ToNullable(enableDdosProtection), Optional.ToList(addressSpace), Optional.ToList(dnsServers), Optional.ToList(subnets));
        }
    }
}

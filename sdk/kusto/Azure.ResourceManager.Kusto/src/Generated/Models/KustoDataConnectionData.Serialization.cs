// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoDataConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static KustoDataConnectionData DeserializeKustoDataConnectionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CosmosDb": return KustoCosmosDBDataConnection.DeserializeKustoCosmosDBDataConnection(element);
                    case "EventGrid": return KustoEventGridDataConnection.DeserializeKustoEventGridDataConnection(element);
                    case "EventHub": return KustoEventHubDataConnection.DeserializeKustoEventHubDataConnection(element);
                    case "IotHub": return KustoIotHubDataConnection.DeserializeKustoIotHubDataConnection(element);
                }
            }
            return UnknownDataConnection.DeserializeUnknownDataConnection(element);
        }
    }
}

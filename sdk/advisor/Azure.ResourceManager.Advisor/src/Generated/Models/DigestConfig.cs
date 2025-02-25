// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> Advisor Digest configuration entity. </summary>
    public partial class DigestConfig
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DigestConfig"/>. </summary>
        public DigestConfig()
        {
            Categories = new ChangeTrackingList<Category>();
        }

        /// <summary> Initializes a new instance of <see cref="DigestConfig"/>. </summary>
        /// <param name="name"> Name of digest configuration. Value is case-insensitive and must be unique within a subscription. </param>
        /// <param name="actionGroupResourceId"> Action group resource id used by digest. </param>
        /// <param name="frequency"> Frequency that digest will be triggered, in days. Value must be between 7 and 30 days inclusive. </param>
        /// <param name="categories"> Categories to send digest for. If categories are not provided, then digest will be sent for all categories. </param>
        /// <param name="language"> Language for digest content body. Value must be ISO 639-1 code for one of Azure portal supported languages. Otherwise, it will be converted into one. Default value is English (en). </param>
        /// <param name="state"> State of digest configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DigestConfig(string name, string actionGroupResourceId, int? frequency, IList<Category> categories, string language, DigestConfigState? state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ActionGroupResourceId = actionGroupResourceId;
            Frequency = frequency;
            Categories = categories;
            Language = language;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of digest configuration. Value is case-insensitive and must be unique within a subscription. </summary>
        public string Name { get; set; }
        /// <summary> Action group resource id used by digest. </summary>
        public string ActionGroupResourceId { get; set; }
        /// <summary> Frequency that digest will be triggered, in days. Value must be between 7 and 30 days inclusive. </summary>
        public int? Frequency { get; set; }
        /// <summary> Categories to send digest for. If categories are not provided, then digest will be sent for all categories. </summary>
        public IList<Category> Categories { get; }
        /// <summary> Language for digest content body. Value must be ISO 639-1 code for one of Azure portal supported languages. Otherwise, it will be converted into one. Default value is English (en). </summary>
        public string Language { get; set; }
        /// <summary> State of digest configuration. </summary>
        public DigestConfigState? State { get; set; }
    }
}

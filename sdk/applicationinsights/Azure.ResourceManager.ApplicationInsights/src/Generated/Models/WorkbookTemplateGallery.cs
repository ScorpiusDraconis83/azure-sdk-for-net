// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Gallery information for a workbook template. </summary>
    public partial class WorkbookTemplateGallery
    {
        /// <summary> Initializes a new instance of <see cref="WorkbookTemplateGallery"/>. </summary>
        public WorkbookTemplateGallery()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkbookTemplateGallery"/>. </summary>
        /// <param name="name"> Name of the workbook template in the gallery. </param>
        /// <param name="category"> Category for the gallery. </param>
        /// <param name="workbookTemplateGalleryType"> Type of workbook supported by the workbook template. </param>
        /// <param name="order"> Order of the template within the gallery. </param>
        /// <param name="resourceType"> Azure resource type supported by the gallery. </param>
        internal WorkbookTemplateGallery(string name, string category, string workbookTemplateGalleryType, int? order, string resourceType)
        {
            Name = name;
            Category = category;
            WorkbookTemplateGalleryType = workbookTemplateGalleryType;
            Order = order;
            ResourceType = resourceType;
        }

        /// <summary> Name of the workbook template in the gallery. </summary>
        public string Name { get; set; }
        /// <summary> Category for the gallery. </summary>
        public string Category { get; set; }
        /// <summary> Type of workbook supported by the workbook template. </summary>
        public string WorkbookTemplateGalleryType { get; set; }
        /// <summary> Order of the template within the gallery. </summary>
        public int? Order { get; set; }
        /// <summary> Azure resource type supported by the gallery. </summary>
        public string ResourceType { get; set; }
    }
}

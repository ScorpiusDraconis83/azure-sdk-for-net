// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentProperties. </summary>
    public partial class NginxDeploymentProperties
    {
        /// <summary> Initializes a new instance of <see cref="NginxDeploymentProperties"/>. </summary>
        public NginxDeploymentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="nginxVersion"></param>
        /// <param name="managedResourceGroup"> The managed resource group to deploy VNet injection related network resources. </param>
        /// <param name="networkProfile"></param>
        /// <param name="ipAddress"> The IP address of the deployment. </param>
        /// <param name="enableDiagnosticsSupport"></param>
        /// <param name="logging"></param>
        /// <param name="scalingProperties"></param>
        /// <param name="userProfile"></param>
        internal NginxDeploymentProperties(NginxProvisioningState? provisioningState, string nginxVersion, string managedResourceGroup, NginxNetworkProfile networkProfile, string ipAddress, bool? enableDiagnosticsSupport, NginxLogging logging, NginxDeploymentScalingProperties scalingProperties, NginxDeploymentUserProfile userProfile)
        {
            ProvisioningState = provisioningState;
            NginxVersion = nginxVersion;
            ManagedResourceGroup = managedResourceGroup;
            NetworkProfile = networkProfile;
            IPAddress = ipAddress;
            EnableDiagnosticsSupport = enableDiagnosticsSupport;
            Logging = logging;
            ScalingProperties = scalingProperties;
            UserProfile = userProfile;
        }

        /// <summary> Gets the provisioning state. </summary>
        public NginxProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the nginx version. </summary>
        public string NginxVersion { get; }
        /// <summary> The managed resource group to deploy VNet injection related network resources. </summary>
        public string ManagedResourceGroup { get; set; }
        /// <summary> Gets or sets the network profile. </summary>
        public NginxNetworkProfile NetworkProfile { get; set; }
        /// <summary> The IP address of the deployment. </summary>
        public string IPAddress { get; }
        /// <summary> Gets or sets the enable diagnostics support. </summary>
        public bool? EnableDiagnosticsSupport { get; set; }
        /// <summary> Gets or sets the logging. </summary>
        internal NginxLogging Logging { get; set; }
        /// <summary> Gets or sets the logging storage account. </summary>
        public NginxStorageAccount LoggingStorageAccount
        {
            get => Logging is null ? default : Logging.StorageAccount;
            set
            {
                if (Logging is null)
                    Logging = new NginxLogging();
                Logging.StorageAccount = value;
            }
        }

        /// <summary> Gets or sets the scaling properties. </summary>
        internal NginxDeploymentScalingProperties ScalingProperties { get; set; }
        /// <summary> Gets or sets the scaling capacity. </summary>
        public int? ScalingCapacity
        {
            get => ScalingProperties is null ? default : ScalingProperties.Capacity;
            set
            {
                if (ScalingProperties is null)
                    ScalingProperties = new NginxDeploymentScalingProperties();
                ScalingProperties.Capacity = value;
            }
        }

        /// <summary> Gets or sets the user profile. </summary>
        internal NginxDeploymentUserProfile UserProfile { get; set; }
        /// <summary> The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string or a valid email address. </summary>
        public string UserPreferredEmail
        {
            get => UserProfile is null ? default : UserProfile.PreferredEmail;
            set
            {
                if (UserProfile is null)
                    UserProfile = new NginxDeploymentUserProfile();
                UserProfile.PreferredEmail = value;
            }
        }
    }
}

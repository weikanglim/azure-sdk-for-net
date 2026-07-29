// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Provisioning;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.Provisioning.Cdn
{
    // Flattening emits both the base and derived HostName properties onto CdnOrigin.
    // Suppress them and provide one forwarding property until https://github.com/Azure/azure-sdk-for-net/issues/61500 is fixed.
    [CodeGenSuppress("HostName")] // Suppresses both generated HostName properties.
    public partial class CdnOrigin
    {
        /// <summary> Gets or sets the host name of the origin. </summary>
        public BicepValue<string> HostName
        {
            get
            {
                return Properties is null ? default! : Properties.HostName;
            }
            set
            {
                if (Properties is null)
                {
                    Properties = new OriginProperties();
                }
                Properties.HostName = value;
            }
        }
    }
}

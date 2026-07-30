// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Provisioning;

#nullable disable

namespace Azure.Provisioning.Search
{
    internal partial class SearchServiceProperties
    {
        private BicepList<SearchDisabledDataExfiltrationOption> _disabledDataExfiltrationOptions;
        private BicepList<SearchPrivateEndpointConnectionData> _privateEndpointConnectionData;
        private BicepList<SharedSearchServicePrivateLinkResourceData> _sharedPrivateLinkResourceData;
        private BicepValue<SearchServicePublicNetworkAccess> _publicNetworkAccess;

        internal BicepList<SearchDisabledDataExfiltrationOption> DisabledDataExfiltrationOptions
        {
            get { Initialize(); return _disabledDataExfiltrationOptions; }
            set { Initialize(); _disabledDataExfiltrationOptions.Assign(value); }
        }

        internal BicepList<SearchPrivateEndpointConnectionData> PrivateEndpointConnectionData
        {
            get { Initialize(); return _privateEndpointConnectionData; }
        }

        internal BicepList<SharedSearchServicePrivateLinkResourceData> SharedPrivateLinkResourceData
        {
            get { Initialize(); return _sharedPrivateLinkResourceData; }
        }

        internal BicepValue<SearchServicePublicNetworkAccess> PublicNetworkAccess
        {
            get { Initialize(); return _publicNetworkAccess; }
            set { Initialize(); _publicNetworkAccess.Assign(value); }
        }

        partial void DefineAdditionalProperties()
        {
            _disabledDataExfiltrationOptions = DefineListProperty<SearchDisabledDataExfiltrationOption>("DisabledDataExfiltrationOptions", new string[] { "disabledDataExfiltrationOptions" });
            _privateEndpointConnectionData = DefineListProperty<SearchPrivateEndpointConnectionData>("PrivateEndpointConnections", new string[] { "privateEndpointConnections" }, isOutput: true);
            _sharedPrivateLinkResourceData = DefineListProperty<SharedSearchServicePrivateLinkResourceData>("SharedPrivateLinkResources", new string[] { "sharedPrivateLinkResources" }, isOutput: true);
            _publicNetworkAccess = DefineProperty<SearchServicePublicNetworkAccess>("PublicNetworkAccess", new string[] { "publicNetworkAccess" });
        }
    }
}

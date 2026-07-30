// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Provisioning;

namespace Azure.Provisioning.Redis
{
    internal partial class RedisProperties
    {
        // Backing storage for RedisResource.PrivateEndpointConnections compatibility. This stays on RedisProperties
        // because the public RedisResource property is flattened from the resource properties model.
        private BicepList<RedisPrivateEndpointConnectionData> _privateEndpointConnections;

        internal BicepList<RedisPrivateEndpointConnectionData> PrivateEndpointConnections
        {
            get
            {
                Initialize();
                return _privateEndpointConnections;
            }
        }

        partial void DefineAdditionalProperties()
        {
            _privateEndpointConnections = DefineListProperty<RedisPrivateEndpointConnectionData>("PrivateEndpointConnections", new string[] { "privateEndpointConnections" }, isOutput: true);
        }
    }
}

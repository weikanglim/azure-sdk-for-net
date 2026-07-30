// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Provisioning;
using System;
using System.ComponentModel;

#nullable disable

namespace Azure.Provisioning.Search
{
    public partial class SharedSearchServicePrivateLinkResourceProperties
    {
        private BicepValue<SharedSearchServicePrivateLinkResourceProvisioningState> _provisioningState;
        private BicepValue<SharedSearchServicePrivateLinkResourceStatus> _status;

        /// <summary> Gets or sets the provisioning state. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsoleted and will be removed in a future version, please use SharedPrivateLinkResourceProvisioningState instead.")]
        public BicepValue<SharedSearchServicePrivateLinkResourceProvisioningState> ProvisioningState
        {
            get { Initialize(); return _provisioningState; }
            set { Initialize(); _provisioningState.Assign(value); }
        }

        /// <summary> Gets or sets the status. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsoleted and will be removed in a future version, please use SharedPrivateLinkResourceStatus instead.")]
        public BicepValue<SharedSearchServicePrivateLinkResourceStatus> Status
        {
            get { Initialize(); return _status; }
            set { Initialize(); _status.Assign(value); }
        }

        partial void DefineAdditionalProperties()
        {
            _provisioningState = DefineProperty<SharedSearchServicePrivateLinkResourceProvisioningState>(nameof(ProvisioningState), new string[] { "provisioningState" });
            _status = DefineProperty<SharedSearchServicePrivateLinkResourceStatus>(nameof(Status), new string[] { "status" });
        }
    }
}

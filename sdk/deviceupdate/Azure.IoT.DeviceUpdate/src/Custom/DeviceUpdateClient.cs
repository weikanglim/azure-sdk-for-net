// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.IoT.DeviceUpdate
{
    [CodeGenSuppress("GetOperationStatuses", typeof(string), typeof(int?), typeof(RequestContext))]
    [CodeGenSuppress("GetOperationStatusesAsync", typeof(string), typeof(int?), typeof(RequestContext))]
    public partial class DeviceUpdateClient
    {
        public DeviceUpdateClient(Uri endpoint, string instanceId, TokenCredential credential)
            : this(endpoint?.Authority, instanceId, credential)
        {
        }

        public DeviceUpdateClient(Uri endpoint, string instanceId, TokenCredential credential, DeviceUpdateClientOptions options)
            : this(endpoint?.Authority, instanceId, credential, options)
        {
        }

        public virtual Operation StartImportUpdate(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
            => ImportUpdate(waitUntil, content, context);

        public virtual Task<Operation> StartImportUpdateAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
            => ImportUpdateAsync(waitUntil, content, context);

        public virtual Pageable<BinaryData> GetOperationStatuses(string filter = null, int? top = default, RequestContext context = null)
            => new DeviceUpdateClientGetOperationStatusesCollectionResult(this, filter, top, context, "DeviceUpdateClient.GetOperationStatuses");

        public virtual AsyncPageable<BinaryData> GetOperationStatusesAsync(string filter = null, int? top = default, RequestContext context = null)
            => new DeviceUpdateClientGetOperationStatusesAsyncCollectionResult(this, filter, top, context, "DeviceUpdateClient.GetOperationStatuses");
    }
}
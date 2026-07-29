// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.IoT.DeviceUpdate
{
    [CodeGenSuppress("GetOperationStatuses", typeof(string), typeof(int?), typeof(RequestContext))]
    [CodeGenSuppress("GetOperationStatusesAsync", typeof(string), typeof(int?), typeof(RequestContext))]
    public partial class DeviceManagementClient
    {
        public DeviceManagementClient(Uri endpoint, string instanceId, TokenCredential credential)
            : this(endpoint?.Authority, instanceId, credential)
        {
        }

        public DeviceManagementClient(Uri endpoint, string instanceId, TokenCredential credential, DeviceUpdateClientOptions options)
            : this(endpoint?.Authority, instanceId, credential, options)
        {
        }

        public virtual Pageable<BinaryData> GetBestUpdatesForGroups(string groupId, RequestContext context = null)
            => GetBestUpdatesForGroup(groupId, context);

        public virtual AsyncPageable<BinaryData> GetBestUpdatesForGroupsAsync(string groupId, RequestContext context = null)
            => GetBestUpdatesForGroupAsync(groupId, context);

        public virtual Pageable<BinaryData> GetDeploymentsForDeviceClassSubgroups(string groupId, string deviceClassId, string orderBy = null, RequestContext context = null)
            => GetDeploymentsForDeviceClassSubgroup(groupId, deviceClassId, orderBy, context);

        public virtual AsyncPageable<BinaryData> GetDeploymentsForDeviceClassSubgroupsAsync(string groupId, string deviceClassId, string orderBy = null, RequestContext context = null)
            => GetDeploymentsForDeviceClassSubgroupAsync(groupId, deviceClassId, orderBy, context);

        public virtual Pageable<BinaryData> GetDeploymentsForGroups(string groupId, string orderBy = null, RequestContext context = null)
            => GetDeploymentsForGroup(groupId, orderBy, context);

        public virtual AsyncPageable<BinaryData> GetDeploymentsForGroupsAsync(string groupId, string orderBy = null, RequestContext context = null)
            => GetDeploymentsForGroupAsync(groupId, orderBy, context);

        public virtual Pageable<BinaryData> GetDeviceClassSubgroupsForGroups(string groupId, string filter = null, RequestContext context = null)
            => GetDeviceClassSubgroupsForGroup(groupId, filter, context);

        public virtual AsyncPageable<BinaryData> GetDeviceClassSubgroupsForGroupsAsync(string groupId, string filter = null, RequestContext context = null)
            => GetDeviceClassSubgroupsForGroupAsync(groupId, filter, context);

        public virtual Pageable<BinaryData> GetDeviceStatesForDeviceClassSubgroupDeployments(string groupId, string deviceClassId, string deploymentId, string filter = null, RequestContext context = null)
            => GetDeviceStatesForDeviceClassSubgroupDeployment(groupId, deviceClassId, deploymentId, filter, context);

        public virtual AsyncPageable<BinaryData> GetDeviceStatesForDeviceClassSubgroupDeploymentsAsync(string groupId, string deviceClassId, string deploymentId, string filter = null, RequestContext context = null)
            => GetDeviceStatesForDeviceClassSubgroupDeploymentAsync(groupId, deviceClassId, deploymentId, filter, context);

        public virtual Pageable<BinaryData> GetInstallableUpdatesForDeviceClasses(string deviceClassId, RequestContext context = null)
            => GetInstallableUpdatesForDeviceClass(deviceClassId, context);

        public virtual AsyncPageable<BinaryData> GetInstallableUpdatesForDeviceClassesAsync(string deviceClassId, RequestContext context = null)
            => GetInstallableUpdatesForDeviceClassAsync(deviceClassId, context);

        public virtual Pageable<BinaryData> GetOperationStatuses(string filter = null, int? top = default, RequestContext context = null)
            => new DeviceManagementClientGetOperationStatusesCollectionResult(this, filter, top, context, "DeviceManagementClient.GetOperationStatuses");

        public virtual AsyncPageable<BinaryData> GetOperationStatusesAsync(string filter = null, int? top = default, RequestContext context = null)
            => new DeviceManagementClientGetOperationStatusesAsyncCollectionResult(this, filter, top, context, "DeviceManagementClient.GetOperationStatuses");
    }
}
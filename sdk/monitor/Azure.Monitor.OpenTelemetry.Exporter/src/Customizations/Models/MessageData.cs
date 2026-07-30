// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter.Internals;

using OpenTelemetry.Logs;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class MessageData
    {
        public MessageData(int version, LogRecord logRecord, string? message, ChangeTrackingDictionary<string, string> properties) : base(version)
        {
            Properties = properties;
            Measurements = new ChangeTrackingDictionary<string, double>();
            Message = message?.Truncate(SchemaConstants.MessageData_Message_MaxLength);

            // TODO: Remove warning disable with next Stable release.
            SeverityLevel = LogsHelper.GetSeverityLevel(logRecord.LogLevel);
        }
    }
}

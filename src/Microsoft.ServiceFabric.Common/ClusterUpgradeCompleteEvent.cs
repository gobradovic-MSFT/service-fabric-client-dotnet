// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Cluster Upgrade Complete event.
    /// </summary>
    public partial class ClusterUpgradeCompleteEvent : ClusterEvent
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpgradeCompleteEvent class.
        /// </summary>
        /// <param name="eventInstanceId">The identifier for the FabricEvent instance.</param>
        /// <param name="timeStamp">The time event was logged.</param>
        /// <param name="targetClusterVersion">Target Cluster version.</param>
        /// <param name="overallUpgradeElapsedTimeInMs">Overall duration of upgrade in milli-seconds.</param>
        /// <param name="hasCorrelatedEvents">Shows there is existing related events available.</param>
        public ClusterUpgradeCompleteEvent(
            Guid? eventInstanceId,
            DateTime? timeStamp,
            string targetClusterVersion,
            double? overallUpgradeElapsedTimeInMs,
            bool? hasCorrelatedEvents = default(bool?))
            : base(
                eventInstanceId,
                timeStamp,
                Common.FabricEventKind.ClusterUpgradeComplete,
                hasCorrelatedEvents)
        {
            targetClusterVersion.ThrowIfNull(nameof(targetClusterVersion));
            overallUpgradeElapsedTimeInMs.ThrowIfNull(nameof(overallUpgradeElapsedTimeInMs));
            this.TargetClusterVersion = targetClusterVersion;
            this.OverallUpgradeElapsedTimeInMs = overallUpgradeElapsedTimeInMs;
        }

        /// <summary>
        /// Gets target Cluster version.
        /// </summary>
        public string TargetClusterVersion { get; }

        /// <summary>
        /// Gets overall duration of upgrade in milli-seconds.
        /// </summary>
        public double? OverallUpgradeElapsedTimeInMs { get; }
    }
}

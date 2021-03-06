// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Monitor.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Monitor.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System;

    internal partial class ActivityLogsImpl
    {
        /// <summary>
        /// Gets Executes the query.
        /// </summary>
        /// <summary>
        /// Gets a representation of the deferred computation of Activity Log query call.
        /// </summary>
        async Task<IPagedCollection<IEventData>> Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute.ExecuteAsync(CancellationToken cancellationToken)
        {
            return await this.ExecuteAsync(cancellationToken) as IPagedCollection<IEventData>;
        }

        /// <summary>
        /// Gets Executes the query.
        /// </summary>
        /// <summary>
        /// Gets Activity Log events received after query execution.
        /// </summary>
        System.Collections.Generic.IEnumerable<Models.IEventData> Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute.Execute()
        {
            return this.Execute() as System.Collections.Generic.IEnumerable<Models.IEventData>;
        }

        /// <summary>
        /// Gets Begins a definition for a new Activity log query.
        /// </summary>
        /// <summary>
        /// Gets the stage of start time filter definition.
        /// </summary>
        Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataStartTimeFilter Microsoft.Azure.Management.Monitor.Fluent.IActivityLogs.DefineQuery()
        {
            return this.DefineQuery();
        }

        /// <summary>
        /// Sets the start time for Activity Log query filter.
        /// </summary>
        /// <param name="startTime">Specifies start time of cut off filter.</param>
        /// <return>The stage of end time filter definition.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataEndFilter Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataStartTimeFilter.StartingFrom(DateTime startTime)
        {
            return this.StartingFrom(startTime) as Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataEndFilter;
        }

        /// <summary>
        /// Gets the manager client of this resource type.
        /// </summary>
        MonitorManager Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasManager<MonitorManager>.Manager
        {
            get
            {
                return this.Manager() as MonitorManager;
            }
        }

        /// <summary>
        /// Selects data fields that will be populated in the server response.
        /// </summary>
        /// <param name="responseProperties">Field names in the server response.</param>
        /// <return>The stage of Activity log filtering by type and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataFieldFilter.WithResponseProperties(params EventDataPropertyName[] responseProperties)
        {
            return this.WithResponseProperties(responseProperties) as Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter;
        }

        /// <summary>
        /// Sets the server response to include all the available properties.
        /// </summary>
        /// <return>The stage of Activity log filtering by type and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataFieldFilter.WithAllPropertiesInResponse()
        {
            return this.WithAllPropertiesInResponse() as Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter;
        }

        /// <summary>
        /// Sets the end time for Activity Log query filter.
        /// </summary>
        /// <param name="endTime">Specifies end time of cut off filter.</param>
        /// <return>The stage of optional query parameter definition and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataFieldFilter Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataEndFilter.EndsBefore(DateTime endTime)
        {
            return this.EndsBefore(endTime) as Microsoft.Azure.Management.Monitor.Fluent.IWithEventDataFieldFilter;
        }

        /// <summary>
        /// Filters events for a given resource group.
        /// </summary>
        /// <param name="resourceGroupName">Specifies resource group name.</param>
        /// <return>The stage of Activity log filtering by type and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter.FilterByResourceGroup(string resourceGroupName)
        {
            return this.FilterByResourceGroup(resourceGroupName) as Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute;
        }

        /// <summary>
        /// Filters events for a given correlation id.
        /// </summary>
        /// <param name="correlationId">Specifies correlation id.</param>
        /// <return>The stage of Activity log filtering by type and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter.FilterByCorrelationId(string correlationId)
        {
            return this.FilterByCorrelationId(correlationId) as Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute;
        }

        /// <summary>
        /// Filters events for a given resource provider.
        /// </summary>
        /// <param name="resourceProviderName">Specifies resource provider.</param>
        /// <return>The stage of Activity log filtering by type and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter.FilterByResourceProvider(string resourceProviderName)
        {
            return this.FilterByResourceProvider(resourceProviderName) as Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute;
        }

        /// <summary>
        /// Filters events for a given resource.
        /// </summary>
        /// <param name="resourceId">Specifies resource Id.</param>
        /// <return>The stage of Activity log filtering by type and query execution.</return>
        Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsSelectFilter.FilterByResource(string resourceId)
        {
            return this.FilterByResource(resourceId) as Microsoft.Azure.Management.Monitor.Fluent.IWithActivityLogsQueryExecute;
        }
    }
}
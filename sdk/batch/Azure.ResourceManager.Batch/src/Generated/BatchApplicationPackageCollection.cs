// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="BatchApplicationPackageResource"/> and their operations.
    /// Each <see cref="BatchApplicationPackageResource"/> in the collection will belong to the same instance of <see cref="BatchApplicationResource"/>.
    /// To get a <see cref="BatchApplicationPackageCollection"/> instance call the GetBatchApplicationPackages method from an instance of <see cref="BatchApplicationResource"/>.
    /// </summary>
    public partial class BatchApplicationPackageCollection : ArmCollection, IEnumerable<BatchApplicationPackageResource>, IAsyncEnumerable<BatchApplicationPackageResource>
    {
        private readonly ClientDiagnostics _batchApplicationPackageApplicationPackageClientDiagnostics;
        private readonly ApplicationPackageRestOperations _batchApplicationPackageApplicationPackageRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchApplicationPackageCollection"/> class for mocking. </summary>
        protected BatchApplicationPackageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchApplicationPackageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchApplicationPackageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchApplicationPackageApplicationPackageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", BatchApplicationPackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchApplicationPackageResource.ResourceType, out string batchApplicationPackageApplicationPackageApiVersion);
            _batchApplicationPackageApplicationPackageRestClient = new ApplicationPackageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchApplicationPackageApplicationPackageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchApplicationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchApplicationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an application package record. The record contains a storageUrl where the package should be uploaded to.  Once it is uploaded the `ApplicationPackage` needs to be activated using `ApplicationPackageActive` before it can be used. If the auto storage account was configured to use storage keys, the URL returned will contain a SAS.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="data"> The parameters for the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchApplicationPackageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string versionName, BatchApplicationPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchApplicationPackageApplicationPackageRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BatchArmOperation<BatchApplicationPackageResource>(Response.FromValue(new BatchApplicationPackageResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an application package record. The record contains a storageUrl where the package should be uploaded to.  Once it is uploaded the `ApplicationPackage` needs to be activated using `ApplicationPackageActive` before it can be used. If the auto storage account was configured to use storage keys, the URL returned will contain a SAS.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="data"> The parameters for the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BatchApplicationPackageResource> CreateOrUpdate(WaitUntil waitUntil, string versionName, BatchApplicationPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchApplicationPackageApplicationPackageRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, data, cancellationToken);
                var operation = new BatchArmOperation<BatchApplicationPackageResource>(Response.FromValue(new BatchApplicationPackageResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified application package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<BatchApplicationPackageResource>> GetAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchApplicationPackageApplicationPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified application package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<BatchApplicationPackageResource> Get(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.Get");
            scope.Start();
            try
            {
                var response = _batchApplicationPackageApplicationPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the application packages in the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchApplicationPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchApplicationPackageResource> GetAllAsync(int? maxresults = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchApplicationPackageApplicationPackageRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, maxresults);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchApplicationPackageApplicationPackageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, maxresults);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BatchApplicationPackageResource(Client, BatchApplicationPackageData.DeserializeBatchApplicationPackageData(e)), _batchApplicationPackageApplicationPackageClientDiagnostics, Pipeline, "BatchApplicationPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the application packages in the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchApplicationPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchApplicationPackageResource> GetAll(int? maxresults = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _batchApplicationPackageApplicationPackageRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, maxresults);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _batchApplicationPackageApplicationPackageRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, maxresults);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BatchApplicationPackageResource(Client, BatchApplicationPackageData.DeserializeBatchApplicationPackageData(e)), _batchApplicationPackageApplicationPackageClientDiagnostics, Pipeline, "BatchApplicationPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchApplicationPackageApplicationPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<bool> Exists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchApplicationPackageApplicationPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<NullableResponse<BatchApplicationPackageResource>> GetIfExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _batchApplicationPackageApplicationPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BatchApplicationPackageResource>(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchApplicationPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual NullableResponse<BatchApplicationPackageResource> GetIfExists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _batchApplicationPackageApplicationPackageClientDiagnostics.CreateScope("BatchApplicationPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _batchApplicationPackageApplicationPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BatchApplicationPackageResource>(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchApplicationPackageResource> IEnumerable<BatchApplicationPackageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchApplicationPackageResource> IAsyncEnumerable<BatchApplicationPackageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

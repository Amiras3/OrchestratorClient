// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QueueDefinitions operations.
    /// </summary>
    public partial interface IQueueDefinitions
    {
        /// <summary>
        /// Gets the list of queue definitions.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View.
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a Boolean condition.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='orderby'>
        /// Sorts the results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results.
        /// </param>
        /// <param name='count'>
        /// Includes a count of the matching results in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListQueueDefinitionDto>> GetQueueDefinitionsWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates a new queue.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.Create.
        /// </remarks>
        /// <param name='queueDefinitionDto'>
        /// The entity to post
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<QueueDefinitionDto>> PostWithHttpMessagesAsync(QueueDefinitionDto queueDefinitionDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a single queue definition based on its Id.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<QueueDefinitionDto>> GetByIdWithHttpMessagesAsync(long id, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Edits a queue.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.Edit.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='queueDefinitionDto'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<QueueDefinitionDto>> PutByIdWithHttpMessagesAsync(long id, QueueDefinitionDto queueDefinitionDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a queue based on its key.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.Delete.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='ifMatch'>
        /// If-Match header
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns an Excel file containing all the items in the given queue.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.View.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a Boolean condition.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='orderby'>
        /// Sorts the results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results.
        /// </param>
        /// <param name='count'>
        /// Includes a count of the matching results in the odata-count header.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Stream>> ReportsByIdWithHttpMessagesAsync(long id, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}

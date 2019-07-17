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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Logs operations.
    /// </summary>
    public partial interface ILogs
    {
        /// <summary>
        /// Inserts a log entry with a specified message in JSON format.
        /// </summary>
        /// <remarks>
        /// Required permissions: Logs.Create.
        ///
        /// Example of jMessage parameter.
        ///
        /// {
        /// "message": "TTT execution started",
        /// "level": "Information",
        /// "timeStamp": "2017-01-18T14:46:07.4152893+02:00",
        /// "windowsIdentity": "DESKTOP-1L50L0P\\WindowsUser",
        /// "agentSessionId": "00000000-0000-0000-0000-000000000000",
        /// "processName": "TTT",
        /// "fileName": "Main",
        /// "jobId": "8066c309-cef8-4b47-9163-b273fc14cc43"
        /// }
        /// </remarks>
        /// <param name='jMessage'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> PostWithHttpMessagesAsync(object jMessage, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Inserts a collection of log entries, each in a specific JSON
        /// format.
        /// </summary>
        /// <remarks>
        /// Required permissions: Logs.Create.
        ///
        /// Example of log entry:
        /// {
        /// "message": "TTT execution started",
        /// "level": "Information",
        /// "timeStamp": "2017-01-18T14:46:07.4152893+02:00",
        /// "windowsIdentity": "DESKTOP-1L50L0P\\WindowsUser",
        /// "agentSessionId": "00000000-0000-0000-0000-000000000000",
        /// "processName": "TTT",
        /// "fileName": "Main",
        /// "jobId": "8066c309-cef8-4b47-9163-b273fc14cc43"
        /// }
        /// </remarks>
        /// <param name='logEntries'>
        /// Collection of string representations of JSON objects
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
        Task<HttpOperationResponse<object>> SubmitLogsWithHttpMessagesAsync(IList<string> logEntries, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}

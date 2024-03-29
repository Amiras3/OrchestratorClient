// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WebClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Alerts.
    /// </summary>
    public static partial class AlertsExtensions
    {
            /// <summary>
            /// Gets alerts.
            /// </summary>
            /// <remarks>
            /// Required permissions: Alerts.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListAlertDto> GetAlertsAsync(this IAlerts operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAlertsWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the total number of alerts, per tenant, that haven't been read by
            /// the current user.
            /// </summary>
            /// <remarks>
            /// Required permissions: Alerts.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseInt64> GetUnreadCountAsync(this IAlerts operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetUnreadCountWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Marks alerts as read and returns the remaining number of unread
            /// notifications.
            /// </summary>
            /// <remarks>
            /// Required permissions: Alerts.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='markAsReadParameters'>
            /// Collection containing the unique identifiers of the notifications that will
            /// be marked as read
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseInt64> MarkAsReadAsync(this IAlerts operations, MarkAsReadParameters markAsReadParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.MarkAsReadWithHttpMessagesAsync(markAsReadParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a Process Alert
            /// </summary>
            /// <remarks>
            /// Required permissions: Alerts.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='raiseAlertParameters'>
            /// RaiseProcessAlert action parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RaiseProcessAlertAsync(this IAlerts operations, RaiseAlertParameters raiseAlertParameters = default(RaiseAlertParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.RaiseProcessAlertWithHttpMessagesAsync(raiseAlertParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}

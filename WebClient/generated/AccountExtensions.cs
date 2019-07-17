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
    /// Extension methods for Account.
    /// </summary>
    public static partial class AccountExtensions
    {
            /// <summary>
            /// Authenticates the user based on user name and password
            /// </summary>
            /// <remarks>
            /// Authenticates the user based on user name and password.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='loginModel'>
            /// The login parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AjaxResponse> AuthenticateAsync(this IAccount operations, LoginModel loginModel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.AuthenticateWithHttpMessagesAsync(loginModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

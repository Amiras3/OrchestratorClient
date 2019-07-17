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
    /// Extension methods for Token.
    /// </summary>
    public static partial class TokenExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='clientSecret'>
            /// </param>
            /// <param name='grantType'>
            /// </param>
            /// <param name='audience'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessToken> PostAsync(this IToken operations, string clientId = default(string), string clientSecret = default(string), string grantType = default(string), string audience = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(clientId, clientSecret, grantType, audience, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

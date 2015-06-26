using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityModel
{
    public interface IOauth2Client
    {
        string CreateCodeFlowUrl(
            string clientId, 
            string scope = null, 
            string redirectUri = null, 
            string state = null, 
            string nonce = null, 
            string loginHint = null,
            string acrValues = null,
            Dictionary<string, string> additionalValues = null);

        string CreateImplicitFlowUrl(
            string clientId,
            string scope = null,
            string redirectUri = null,
            string state = null,
            string nonce = null,
            string loginHint = null,
            string acrValues = null,
            Dictionary<string, string> additionalValues = null);

        string CreateAuthorizeUrl(
            string clientId, 
            string responseType, 
            string scope = null, 
            string redirectUri = null, 
            string state = null, 
            string nonce = null,
            string loginHint = null,
            string acrValues = null,
            string responseMode = null,
            Dictionary<string, string> additionalValues = null);

        Task<ITokenResponse> RequestResourceOwnerPasswordAsync(string userName, string password, string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestAuthorizationCodeAsync(string code, string redirectUri, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestRefreshTokenAsync(string refreshToken, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestClientCredentialsAsync(string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestCustomGrantAsync(string grantType, string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestCustomAsync(Dictionary<string, string> values, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestAssertionAsync(string assertionType, string assertion, string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<ITokenResponse> RequestAsync(Dictionary<string, string> form, CancellationToken cancellationToken = default(CancellationToken));
    }
}

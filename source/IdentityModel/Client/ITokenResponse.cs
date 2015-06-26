using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IdentityModel.Client
{
    public interface ITokenResponse
    {
        string Raw { get; }
        JObject Json { get; }

        bool IsHttpError { get; }
        HttpStatusCode HttpErrorStatusCode { get; }
        string HttpErrorReason { get; }
        string AccessToken { get; }
        string IdentityToken { get; }
        string Error { get; }
        bool IsError { get; }
        long ExpiresIn { get; }
        string TokenType { get; }
        string RefreshToken { get; }
    }
}

using AspNetCore.Authentication.ApiKey;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ApiKey : IApiKey
    {
        public ApiKey(IOptionsMonitor<AppOptions> options)
        {
            //retreive secret Api key via Depencendy Injection
            Key = options.CurrentValue.ApiKey;
        }

        /// <summary>
        /// provide the secret API Key
        /// </summary>
        public string Key { get; }

        public string OwnerName { get; }

        public IReadOnlyCollection<Claim> Claims { get; }
    }
}
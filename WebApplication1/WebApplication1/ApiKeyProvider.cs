using AspNetCore.Authentication.ApiKey;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ApiKeyProvider : IApiKeyProvider
    {
        public ApiKeyProvider(IApiKey apiKey)
        {
            _apiKey = apiKey;
        }

        private IApiKey _apiKey;

        public Task<IApiKey> ProvideAsync(string key)
        {
            // just work as a ApiKeyProvider and return an IApiKey instance
            return Task.FromResult(_apiKey);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace OpenFaaS.Dotnet
{
    /// <summary>
    /// Context for default function execution
    /// </summary>
    public class DefaultFunctionContext : IFunctionContext
    {
        public HttpMethod HttpMethod
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("Http_Method");
                switch (env.ToLowerInvariant())
                {
                    case "get":
                        return HttpMethod.Get;
                    case "post":
                        return HttpMethod.Post;
                    default:
                        return new HttpMethod(env);
                }
            }
        }

        public Dictionary<string, StringValues> QueryParameters
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("Http_Query");
                return QueryHelpers.ParseQuery(env);
            }
        }

        public int ReadTimeout
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("read_timeout");
                int result = -1;
                int.TryParse(env, out result);
                return result;
            }
        }

        public int WriteTimeout
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("write_timeout");
                int result = -1;
                int.TryParse(env, out result);
                return result;
            }
        }

        public int ExecTimeout
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("exec_timeout");
                int result = -1;
                int.TryParse(env, out result);
                return result;
            }
        }

        public string[] HttpAccept
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("Http_Accept");
                return env.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public string ContentType
        {
            get
            {
                return Environment.GetEnvironmentVariable("Http_Content_Type");
            }
        }
    }
}

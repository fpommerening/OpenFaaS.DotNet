using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Primitives;

namespace OpenFaaS.Dotnet
{
    public interface IFunctionContext
    {
        /// <summary>
        /// Get the http method
        /// Currently OpenFaaS only supports GET and POST
        /// </summary>
        HttpMethod HttpMethod { get; }

        /// <summary>
        /// Get the query parameter if exists
        /// </summary>
        Dictionary<string, StringValues> QueryParameters { get; }

        /// <summary>
        /// Get the read timeout in seconds
        /// </summary>
        int ReadTimeout { get; }

        /// <summary>
        /// Get the write timeout in seconds
        /// </summary>
        int WriteTimeout { get; }

        /// <summary>
        /// Get the write timeout in seconds
        /// </summary>
        int ExecTimeout { get; }

        /// <summary>
        /// Get the accepted content type
        /// </summary>
        string[] HttpAccept { get; }

        /// <summary>
        /// Get the requested content type
        /// </summary>
        string ContentType { get; }
    }
}

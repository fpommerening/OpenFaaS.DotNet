using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Primitives;

namespace OpenFaaS.Dotnet
{
    /// <summary>
    /// Function context for unit tests
    /// </summary>
    public class TestFuntionContext : IFunctionContext
    {
        public HttpMethod HttpMethod { get; set; } = HttpMethod.Post;

        public Dictionary<string, StringValues> QueryParameters { get; } = new Dictionary<string, StringValues>();

        public int ReadTimeout { get; set; } = -1;

        public int WriteTimeout { get; set; } = -1;
    
        public int ExecTimeout { get; } = -1; 

        public string[] HttpAccept { get; set; }

        public string ContentType { get; set; }

        private readonly StringBuilder _stringBuilderContent = new StringBuilder();

        public void ClearContent()
        {
            _stringBuilderContent.Clear();
        }

        public void WriteContent(string content)
        {
            _stringBuilderContent.AppendLine(content);
        }

        public string Content => _stringBuilderContent.ToString();
    }
}

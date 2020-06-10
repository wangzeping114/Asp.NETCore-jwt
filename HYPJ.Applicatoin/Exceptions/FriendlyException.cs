using System;
using System.Collections.Generic;
using System.Linq;

namespace HYPJ.Applicatoin.Exceptions
{
    public class FriendlyException : Exception
    {
        public int HttpStatusCode { get; }

        public Dictionary<string, string[]> Errors { get; }



        public FriendlyException(string message, int httpStatusCode = 400)
            : this("error", message, null, httpStatusCode)
        {

        }

        public FriendlyException(string key, string message, Exception innerException = null, int httpStatusCode = 400)
            : this(new Dictionary<string, string[]> { { key, new[] { message } } }, innerException, httpStatusCode)
        {

        }

        public FriendlyException(string key, string[] messages, Exception innerException = null, int httpStatusCode = 400)
            : this(new Dictionary<string, string[]> { { key, messages } }, innerException, httpStatusCode)
        {

        }

        public FriendlyException(Dictionary<string, string[]> errors, Exception innerException, int httpStatusCode = 400)
            : base(string.Join("\r\n", errors.Values.Aggregate((a, c) => c.Concat(a).ToArray())), innerException)
        {
            HttpStatusCode = httpStatusCode;
            Errors = errors;
        }
    }
}

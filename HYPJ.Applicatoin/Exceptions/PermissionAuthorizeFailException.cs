using System;

namespace HYPJ.Applicatoin.Exceptions
{
    public class PermissionAuthorizeFailException : Exception
    {
        public PermissionAuthorizeFailException(string message) : base(message)
        {
        }
    }
}

using System;

namespace Estudos5.Entities.Exceptions
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message) { }
    }
}

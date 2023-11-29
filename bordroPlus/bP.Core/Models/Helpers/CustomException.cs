using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.Helpers
{
    public class CustomException : Exception
    {
        public string ReturnMessage { get; set; }
        public override string Message => ReturnMessage;
        public string ErrorMessage { get; set; }
        public int Code { get; }

        public CustomException()
        {
        }
        public CustomException(int code)
        {
            Code = code;
        }
        public CustomException(int code, string message)
        {
            Code = code;
            ReturnMessage = message;
        }

        public CustomException(string message, params object[] args) : this(400, message, args)
        {
        }

        public CustomException(int code, string message, params object[] args) : this(null, message, args)
        {
            ReturnMessage = String.Format(message, args);
            Code = code;
        }

        public CustomException(Exception innerException, string message, params object[] args) : this(innerException, 400, message, args)
        {
            ReturnMessage = "Message:" + message + " Inner Exceptin Message:" + innerException.Message;
            Code = 400;
        }

        public CustomException(Exception innerException, int code, string message, params object[] args) : base(string.Format(message, args), innerException)
        {
            if (innerException is null)
            {
                Code = code;
                ErrorMessage = message;
                ReturnMessage = Message;
            }
            else if (innerException.InnerException == null)
            {
                Code = code;
                ErrorMessage = message + innerException.Message;
                ReturnMessage = innerException.Message;
            }
            else
            {
                throw new CustomException(innerException.InnerException, innerException.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantAPI.Utils
{
    
    public class StatusCode
    {
        public const string SUCCESS = "00000";
        public const string FAIL = "10000";
        public const string TOKEN_EXPIRE = "10001";
        public const string FORCE_UPDATE = "10002";
    }

    public class MessageType
    {
        public const string NONE = "00000";
        public const string POPUP = "10000";
    }
    public class Operation
    {
        public const string Index = "Index";
        public const string GetCustomer = "GetCustomer";
    }
}
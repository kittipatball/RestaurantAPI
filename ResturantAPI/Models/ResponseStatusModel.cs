using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Models
{
    public class ResponseStatusModel
    {
        public String StatusCode { get; set; }
        public String ClientMsg { get; set; }
        public String Operation { get; set; }
        public String MessageType { get; set; }
    }
}
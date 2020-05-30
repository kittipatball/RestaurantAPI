using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Models
{
    public class ResultModel<T>
    {
        public ResponseStatusModel responseStatus {get; set;}
        public T result { get; set; }
    }

    public class ResultListModel<T>
    {
        public ResponseStatusModel responseStatus { get; set; }
        public List<T> result { get; set; }
    }
}
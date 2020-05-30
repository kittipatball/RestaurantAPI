using System;

namespace RestaurantAPI.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Token { get; set; }
        public int Role { get; set; }
    }
}
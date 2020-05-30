
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using RestaurantAPI.Models;
using ResturantAPI.Connection;
using ResturantAPI.Utils;

namespace RestaurantAPI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            string sql = "SELECT * FROM customer WHERE Role = 0";
            MySqlDataReader reader = new Database().Query(sql);
            ArrayList resultList = new ArrayList();
            while (reader.Read())
            {
                resultList.Add(reader.GetString("FirstName") + " " + reader.GetString("LastName"));
            }
           
            return Json(resultList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetCustomer()
        {
            string sql = "SELECT * FROM customer";
            MySqlDataReader reader = new Database().Query(sql);

            ResultListModel<CustomerModel> result = new ResultListModel<CustomerModel>();
            List<CustomerModel> customers = new List<CustomerModel>();
            ResponseStatusModel responseStatus = new ResponseStatusModel()
            {
                 StatusCode = StatusCode.SUCCESS , ClientMsg = "SUCCESS" , MessageType = MessageType.NONE , Operation = Operation.GetCustomer
            };
            
            while (reader.Read())
            {
                CustomerModel customer = new CustomerModel();
                customer.Id = reader.GetInt16("Id");
                customer.Firstname = reader.GetString("FirstName");
                customer.Lastname = reader.GetString("LastName");
                customer.Username = reader.GetString("UserName");
                customer.Password = reader.GetString("Password");
                customer.Role = reader.GetInt16("Role");
                customer.Token = reader.GetString("Token");
                customers.Add(customer);
            }
            result.result = customers;
            result.responseStatus = responseStatus;
            return Json(result, JsonRequestBehavior.AllowGet);
            
        }
    }
}
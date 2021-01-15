using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwonCinema.Areas.Admin.Models;

namespace TwonCinema
{
    public class Middleware
    {
        public static void CheckStafLogin(HttpContext context)
        {
            if (context.Session.GetString("staf") == null)
            {
                context.Response.Redirect("/admin/login");  
            }
        }

        public static void CheckCustomerLogin(HttpContext context)
        {
            if (context.Session.GetString("customer") == null)
            {
                context.Session.SetString("err", "1");
                context.Response.Redirect("/login");
            }
        }
        public static Staf StafLogin(HttpContext context)
        {
            if (context.Session.GetString("staf") != null)
            {
                JObject stafJson = JObject.Parse(context.Session.GetString("staf"));
                Staf staf = new Staf();
                staf.ID = int.Parse(stafJson.SelectToken("ID").ToString());
                staf.Name = stafJson.SelectToken("Name").ToString();
                staf.Email = stafJson.SelectToken("Email").ToString();
                staf.Password = stafJson.SelectToken("Password").ToString();
                staf.Avatar = stafJson.SelectToken("Avatar").ToString();
                staf.Phone = stafJson.SelectToken("Phone").ToString();
                staf.Address = stafJson.SelectToken("Address").ToString();
                staf.Status = int.Parse(stafJson.SelectToken("Status").ToString());
                return staf;
            }
            return null;
        }

        public static Customer CustomerLogin(HttpContext context)
        {
            if (context.Session.GetString("customer") != null)
            {
                JObject cusJson = JObject.Parse(context.Session.GetString("customer"));
                Customer customer = new Customer();
                customer.ID = int.Parse(cusJson.SelectToken("ID").ToString());
                customer.Name = cusJson.SelectToken("Name").ToString();
                customer.Email = cusJson.SelectToken("Email").ToString();
                customer.Password = cusJson.SelectToken("Password").ToString();
                customer.Phone = cusJson.SelectToken("Phone").ToString();
                customer.Total_Spending = int.Parse(cusJson.SelectToken("Total_Spending").ToString());
                customer.Status = int.Parse(cusJson.SelectToken("Status").ToString());
                return customer;
            }
            return null;
        }
    }
}

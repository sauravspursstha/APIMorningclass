using APIMorningClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIMorningClass.DbContext;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace APIMorningClass.Controllers
{
    public class ValuesController : ApiController
    {
        Context dbcon = new Context(); 

        List<Student> std = new List<Student>() {
            new Student(){ID = 1, Name = "Saurav"},
            new Student(){ID = 2, Name = "Akriti"},
            new Student(){ID = 3, Name = "Roshan"},
            new Student(){ID = 4, Name = "Samikshya"}
        };

        public SqlCommand GetConnection()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            return cmd;

        }

        [HttpGet]
        [Route("api/values/GetUserInfo")]
        // GET api/values
        public List<UserInfo> GetUserInfo()
        {
            SqlCommand cmd = GetConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "procGetUsers";
            DataTable dt = new DataTable();
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            List<UserInfo> employeeList = dt.DataTableToList<UserInfo>();

            string a = "Hello";
            return employeeList;
        }


       
        // GET api/values/5
        public UserInfo Get(int id)
        {
            var result = dbcon.users.SingleOrDefault(c => c.Uid == id);

            return result;
        }

        // POST api/values
        public UserInfo Post([FromBody]UserInfo value)
        {
            using (dbcon)
            {
                dbcon.users.Add(value);
                dbcon.SaveChanges();

            }
            return (value);
        }

        // PUT api/values/5
        public UserInfo Put(int id, [FromBody]UserInfo value)
        {
            using (dbcon)
            {
                var user = dbcon.users.SingleOrDefault(u => u.Uid == id);
                user.Lastname = value.Lastname;
                dbcon.SaveChanges();
            }
            return (value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            using (dbcon)
            {
                var user = dbcon.users.SingleOrDefault(u => u.Uid == id);
                dbcon.users.Remove(user);
                dbcon.SaveChanges(); 

            }
        }

       

    }
}

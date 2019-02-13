using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using APIMorningClass.Models;

namespace APIMorningClass.DbContext
{
    public class Context : System.Data.Entity.DbContext
    {

        public Context() : base("dbconnection")
        {

        }


        public DbSet<UserInfo> users { get; set; }

    }
}
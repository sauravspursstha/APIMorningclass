namespace APIMorningClass.Migrations
{
    using APIMorningClass.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APIMorningClass.DbContext.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APIMorningClass.DbContext.Context context)
        {
            //List<UserInfo> user = new List<UserInfo>
            //{
            //    new UserInfo{ Uid = 1, Firstname = "Saurav", Lastname= "Shrestha", Address = "Prayag Pokhari", Phonenumber= "9844792365"},
            //    new UserInfo{ Uid = 2, Firstname = "Ravi", Lastname= "Shrestha", Address = "Prayag Pokhari", Phonenumber= "9844792365"},
            //    new UserInfo{ Uid = 3, Firstname = "Sam", Lastname= "Shrestha", Address = "Prayag Pokhari", Phonenumber= "9844792365"}
            //};

            //user.ForEach(s => context.users.Add(s));
            //context.SaveChanges(); 

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

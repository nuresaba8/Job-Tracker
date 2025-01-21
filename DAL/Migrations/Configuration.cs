namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.JobContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.JobContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Users.Add(new EF.Tables.User
            //{
            //    UserEmail = "saba@gmail.com",
            //    UserPassword = "1234",
            //    UserRole = 1
            //});
            //context.SaveChanges();

            //context.Users.Add(new EF.Tables.User
            //{
            //    UserEmail = "nadim@gmail.com",
            //    UserPassword = "1234",
            //    UserRole = 2
            //});
            //context.SaveChanges();
            //context.Users.Add(new EF.Tables.User
            //{
            //    UserEmail = "nur@gmail.com",
            //    UserPassword = "1234",
            //    UserRole = 3
            //});
            //context.SaveChanges();
        }
    }
}

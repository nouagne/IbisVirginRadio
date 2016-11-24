namespace MRM.Ibis.VirginRadioTour.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MRM.Ibis.VirginRadioTour.Core.DAL.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVC";
        }

        protected override void Seed(MRM.Ibis.VirginRadioTour.Core.DAL.EFDbContext context)
        {

        }
    }

    internal sealed class ConfigurationUMS : DbMigrationsConfiguration<MRM.UMS.Core.DAL.EFDbContext>
    {
        public ConfigurationUMS()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsNamespace = "UMS";
            ContextKey = "UMS";
        }

        protected override void Seed(MRM.UMS.Core.DAL.EFDbContext context)
        {
            context.Users.AddOrUpdate(
                u => u.Email,
                new MRM.UMS.Core.BO.User
                {
                    UUID = Guid.Parse("203FF94A-5524-498B-9FB6-2810D310798E"),
                    Username = "nicolas",
                    Email = "nouagne@gmail.com",
                    Password = "test1234"
                });

            context.Roles.AddOrUpdate(
                r => r.Name,
                new MRM.UMS.Core.BO.Role
                {
                    Name = "Admin"
                });

            context.UserRoles.AddOrUpdate(
                ur => new { ur.UserId, ur.RoleId },
                new MRM.UMS.Core.BO.UserRole
                {
                    UserId = 1,
                    RoleId = 1
                });
        }
    }
}

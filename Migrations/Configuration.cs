namespace QuanLyNha.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyNha.EntityFramework.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuanLyNha.EntityFramework.AppDbContext context)
        {
            context.Accounts.AddOrUpdate(x => x.Id, new EntityFramework.Account()
            {
                Id = 1,
                UserName = "admin",
                Password = "123qwe",
                DislayName = "admin",
                Status = EntityFramework.Status.Active
            });

            context.Accounts.AddOrUpdate(x => x.Id, new EntityFramework.Account()
            {
                Id = 2,
                UserName = "nv",
                Password = "123qwe",
                DislayName = "nv",
                Status = EntityFramework.Status.DeActive
            });
        }
    }
}

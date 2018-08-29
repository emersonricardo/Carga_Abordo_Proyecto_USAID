namespace Carga_AbordoBD1._0.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Carga_AbordoBD1._0.Models.AplicatiomDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Carga_AbordoBD1._0.Models.AplicatiomDbContext";
        }

        protected override void Seed(Carga_AbordoBD1._0.Models.AplicatiomDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

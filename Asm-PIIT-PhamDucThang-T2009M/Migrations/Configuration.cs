namespace Asm_PIIT_PhamDucThang_T2009M.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Asm_PIIT_PhamDucThang_T2009M.Data.Asm_PIIT_PhamDucThang_T2009MContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Asm_PIIT_PhamDucThang_T2009M.Data.Asm_PIIT_PhamDucThang_T2009MContext";
        }

        protected override void Seed(Asm_PIIT_PhamDucThang_T2009M.Data.Asm_PIIT_PhamDucThang_T2009MContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

namespace ColmadoFax.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ColmadoFax.Negocios.Bd>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ColmadoFax.Negocios.Bd context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
///////////////////////////////////////////////////////////////////////////////////////
            //Se llamará a este método después de migrar a la última versión.//

             // Puedes usar el método de extensión auxiliar DbSet <T> .AddOrUpdate ()
             // para evitar la creación de datos semilla duplicados.
        }
    }
}

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
            //Se llamar� a este m�todo despu�s de migrar a la �ltima versi�n.//

             // Puedes usar el m�todo de extensi�n auxiliar DbSet <T> .AddOrUpdate ()
             // para evitar la creaci�n de datos semilla duplicados.
        }
    }
}

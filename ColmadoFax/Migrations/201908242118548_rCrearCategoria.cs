namespace ColmadoFax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rCrearCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(maxLength: 100),
                        Activa = c.Boolean(nullable: false),
                        categorias_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.categorias_Id)
                .Index(t => t.categorias_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categorias", "categorias_Id", "dbo.Categorias");
            DropIndex("dbo.Categorias", new[] { "categorias_Id" });
            DropTable("dbo.Categorias");
        }
    }
}

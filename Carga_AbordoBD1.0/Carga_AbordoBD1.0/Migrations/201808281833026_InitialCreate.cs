namespace Carga_AbordoBD1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ejemploes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ejemplo1 = c.String(),
                        ejemplo2 = c.String(),
                        ejemplo3 = c.String(),
                        ejemplo4 = c.String(),
                        ejemplo5 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ejemploes");
        }
    }
}

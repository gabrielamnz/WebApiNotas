namespace WebApiNotas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criando_Tabela : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 100),
                        Body = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notes");
        }
    }
}

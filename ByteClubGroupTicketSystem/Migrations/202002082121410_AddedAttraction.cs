namespace ByteClubGroupTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttraction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attractions",
                c => new
                    {
                        AttractionId = c.Int(nullable: false, identity: true),
                        AttractionName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.AttractionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Attractions");
        }
    }
}

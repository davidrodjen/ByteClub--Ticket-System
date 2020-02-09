namespace ByteClubGroupTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOption : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        OptionsId = c.Int(nullable: false, identity: true),
                        Attraction = c.String(nullable: false),
                        TimeSlot = c.DateTime(nullable: false),
                        NumberOfGuests = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OptionsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Options");
        }
    }
}

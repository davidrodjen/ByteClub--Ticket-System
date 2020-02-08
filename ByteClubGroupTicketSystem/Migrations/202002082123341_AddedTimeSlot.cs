namespace ByteClubGroupTicketSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTimeSlot : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeSlots",
                c => new
                    {
                        TimeSlotId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        TimeSlotLength = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.TimeSlotId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeSlots");
        }
    }
}

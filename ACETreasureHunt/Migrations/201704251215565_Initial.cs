namespace ACETreasureHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PitStops", "Description", c => c.String());
            AlterColumn("dbo.PitStops", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Staffs", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Staffs", "Longitude", c => c.Double(nullable: false));
            DropColumn("dbo.Events", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Staffs", "Longitude", c => c.Int(nullable: false));
            AlterColumn("dbo.Staffs", "Latitude", c => c.Int(nullable: false));
            AlterColumn("dbo.PitStops", "Latitude", c => c.Int(nullable: false));
            DropColumn("dbo.PitStops", "Description");
        }
    }
}

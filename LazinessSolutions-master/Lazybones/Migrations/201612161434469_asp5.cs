namespace Lazybones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asp5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Badge_Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Badge_Count");
        }
    }
}

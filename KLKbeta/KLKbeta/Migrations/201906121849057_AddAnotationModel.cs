namespace KLKbeta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnotationModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Facts", "Hour");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Facts", "Hour", c => c.Int(nullable: false));
        }
    }
}

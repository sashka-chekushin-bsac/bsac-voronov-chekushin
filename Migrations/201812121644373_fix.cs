namespace BSAC_Voronov_Chekushin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Message", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Message", c => c.String());
            AlterColumn("dbo.Reservations", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Reservations", "Requests");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Requests", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "Name", c => c.String());
            AlterColumn("dbo.Contacts", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String());
            DropColumn("dbo.Reservations", "Message");
        }
    }
}

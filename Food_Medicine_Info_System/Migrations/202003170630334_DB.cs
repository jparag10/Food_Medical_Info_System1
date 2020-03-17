namespace Food_Medicine_Info_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dieticians",
                c => new
                    {
                        did = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Contact = c.Long(nullable: false),
                        Location = c.String(nullable: false),
                        Experience = c.Int(nullable: false),
                        filepath = c.String(),
                    })
                .PrimaryKey(t => t.did);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        ContactNo = c.Long(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.userid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Dieticians");
        }
    }
}

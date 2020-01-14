namespace PerformanceTesting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Topic = c.String(),
                        BrokerList = c.String(),
                        Body = c.String(),
                        FilePath = c.String(),
                        RunTestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RunTest", t => t.RunTestId, cascadeDelete: true)
                .Index(t => t.RunTestId);
            
            CreateTable(
                "dbo.RunTest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RunLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RunDateTime = c.String(),
                        TotalConsumedSeconds = c.Int(nullable: false),
                        NumberOfMessage = c.Int(nullable: false),
                        Topic = c.String(),
                        BrokerList = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Message", "RunTestId", "dbo.RunTest");
            DropIndex("dbo.Message", new[] { "RunTestId" });
            DropTable("dbo.RunLog");
            DropTable("dbo.RunTest");
            DropTable("dbo.Message");
        }
    }
}

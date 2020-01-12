namespace PerformanceTesting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class CREATE_TABLE_Message : DbMigration
    {
        public override void Up()
        {
            var sqlFile = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}/Scripts", @"CREATE_TABLE_Message.sql");
            Sql(File.ReadAllText(sqlFile));
        }

        public override void Down()
        {
            var sqlFile = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}/Scripts", @"CREATE_TABLE_Message_ROLLBACK.sql");
            Sql(File.ReadAllText(sqlFile));
        }
    }
}

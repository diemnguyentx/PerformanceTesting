namespace PerformanceTesting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class INSERT_INTO_TABLE_RunLog : DbMigration
    {
        public override void Up()
        {
            var sqlFile = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}/Scripts", @"INSERT_INTO_TABLE_RunLog.sql");
            Sql(File.ReadAllText(sqlFile));
        }

        public override void Down()
        {
            var sqlFile = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}/Scripts", @"INSERT_INTO_TABLE_RunLog_ROLLBACK.sql");
            Sql(File.ReadAllText(sqlFile));
        }
    }
}

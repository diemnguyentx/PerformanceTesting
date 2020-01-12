namespace PerformanceTesting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class INSERT_INTO_TABLE_RunTest : DbMigration
    {
        public override void Up()
        {
            var sqlFile = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}/Scripts", @"INSERT_INTO_TABLE_RunTest.sql");
            Sql(File.ReadAllText(sqlFile));
        }

        public override void Down()
        {
            var sqlFile = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}/Scripts", @"INSERT_INTO_TABLE_RunTest_ROLLBACK.sql");
            Sql(File.ReadAllText(sqlFile));
        }
    }
}

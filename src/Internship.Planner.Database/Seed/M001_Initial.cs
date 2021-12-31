using Internship.Planner.Database.Migrations;

namespace Internship.Planner.Database.Seed;

public static class M001Initial
{
    public static void SeedDevData(this M001_Initial migration)
    {
        var insert = migration.Insert;
    }
}
using FluentMigrator;
using Internship.Planner.Database.Seed;

namespace Internship.Planner.Database.Migrations;

[Migration(1)]
public partial class M001_Initial : Migration
{
    private readonly bool _seed;

    public M001_Initial(Options options)
    {
        _seed = options.Seed;
    }
    public override void Up()
    {

        Create.Table("Lector")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("Code").AsString(10).NotNullable()
            .WithColumn("Name").AsString(256).NotNullable()
            .WithColumn("Surname").AsString(256).NotNullable()
            .WithColumn("Email").AsString(512).NotNullable();


        Create.Table("Student")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("Name").AsString(256).NotNullable()
            .WithColumn("Surname").AsString(256).NotNullable()
            .WithColumn("Email").AsString(512).NotNullable();
        
        Create.Table("Location")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("Name").AsString(256).NotNullable()
            .WithColumn("Address").AsString(512).NotNullable();
        
        Create.Table("Department")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("LocationId").AsGuid().ForeignKey("Location", "Id")
            .WithColumn("Name").AsString(512).NotNullable()
            .WithColumn("Code").AsString(60).NotNullable();

        Create.Table("DepartmentContact")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("DepartmentId").AsGuid().ForeignKey("Department", "Id")
            .WithColumn("Name").AsString(256).NotNullable()
            .WithColumn("Surname").AsString(256).NotNullable()
            .WithColumn("Email").AsString(512).Nullable()
            .WithColumn("PhoneNumber").AsString(60).Nullable();
        
        Create.Table("Internship")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("StudentId").AsGuid().ForeignKey("Student", "Id")
            .WithColumn("StartDate").AsDateTime2().NotNullable()
            .WithColumn("EndDate").AsDateTime2().NotNullable();

        Create.Table("LectorForInternship")
            .WithColumn("LectorId").AsGuid().ForeignKey("Lector", "Id").PrimaryKey()
            .WithColumn("InternshipId").AsGuid().ForeignKey("Internship", "Id").PrimaryKey();

        Create.Table("TaskPreset")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("Name").AsString(256).NotNullable()
            .WithColumn("LectorId").AsGuid().ForeignKey("Lector", "Id");

        Create.Table("InternshipTask")
            .WithColumn("Id").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("InternshipId").AsGuid().ForeignKey("Internship", "Id")
            .WithColumn("TaskPresetId").AsGuid().ForeignKey("TaskPreset", "Id")
            .WithColumn("Date").AsDateTime2().Nullable()
            .WithColumn("Done").AsBoolean().NotNullable()
            .WithColumn("Title").AsString("256").NotNullable()
            .WithColumn("Text").AsString("1024").Nullable();

        if (_seed)
        {
            this.SeedDevData();
        }
    }

    public override void Down()
    {
        Delete.Table("InternshipTask");
        Delete.Table("TaskPreset");
        Delete.Table("LectorForInternship");
        Delete.Table("Internship");
        Delete.Table("DepartmentContact");
        Delete.Table("Department");
        Delete.Table("Location");
        Delete.Table("Student");
        Delete.Table("Lector");
    }
}
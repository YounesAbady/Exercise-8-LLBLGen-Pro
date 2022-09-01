﻿using FluentMigrator;

namespace Backend.Migrations
{
    [Migration(6)]
    public class AddCategoryTable_6 : Migration
    {
        public override void Down()
        {
            Delete.Table("Category");
        }

        public override void Up()
        {
            Create.Table("Category")
                .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
                .WithColumn("Data").AsString().NotNullable()
                .WithColumn("RecipeId").AsGuid().NotNullable().ForeignKey("Recipe", "Id");
        }
    }
}

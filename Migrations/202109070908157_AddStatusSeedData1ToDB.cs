﻿namespace Tasks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedData1ToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('To Do');");
            Sql("INSERT INTO Status (Name) VALUES ('In Progress');");
            Sql("INSERT INTO Status (Name) VALUES ('Done');");
        }
        
        public override void Down()
        {
        }
    }
}

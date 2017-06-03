namespace linq_groupby_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Mobile_Phone_Number : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Mobile", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Mobile");
        }
    }
}

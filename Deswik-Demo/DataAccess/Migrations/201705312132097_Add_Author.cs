namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Author : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        ingredientid = c.Int(nullable: false, identity: true),
                        recipeid = c.Int(nullable: false),
                        name = c.String(nullable: false, maxLength: 64, fixedLength: true, unicode: false),
                        quantity = c.Int(nullable: false),
                        unit = c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false),
                        sortrder = c.Int(),
                    })
                .PrimaryKey(t => t.ingredientid)
                .ForeignKey("dbo.Recipe", t => t.recipeid)
                .ForeignKey("dbo.Unit", t => t.unit)
                .Index(t => t.recipeid)
                .Index(t => t.unit);
            
            CreateTable(
                "dbo.Recipe",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 100, fixedLength: true, unicode: false),
                        author = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Instruction",
                c => new
                    {
                        instructionid = c.Int(nullable: false, identity: true),
                        recipeid = c.Int(nullable: false),
                        description = c.String(nullable: false, maxLength: 200, fixedLength: true, unicode: false),
                        sortrder = c.Int(),
                    })
                .PrimaryKey(t => t.instructionid)
                .ForeignKey("dbo.Recipe", t => t.recipeid)
                .Index(t => t.recipeid);
            
            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        unit = c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.unit);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredient", "unit", "dbo.Unit");
            DropForeignKey("dbo.Instruction", "recipeid", "dbo.Recipe");
            DropForeignKey("dbo.Ingredient", "recipeid", "dbo.Recipe");
            DropIndex("dbo.Instruction", new[] { "recipeid" });
            DropIndex("dbo.Ingredient", new[] { "unit" });
            DropIndex("dbo.Ingredient", new[] { "recipeid" });
            DropTable("dbo.Unit");
            DropTable("dbo.Instruction");
            DropTable("dbo.Recipe");
            DropTable("dbo.Ingredient");
        }
    }
}

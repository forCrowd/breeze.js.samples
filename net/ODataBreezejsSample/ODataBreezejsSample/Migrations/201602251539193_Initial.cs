namespace ODataBreezejsSample.Models
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TodoListId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 60),
                        IsDone = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TodoLists", t => t.TodoListId, cascadeDelete: true)
                .Index(t => t.TodoListId);
            
            CreateTable(
                "dbo.TodoLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoItems", "TodoListId", "dbo.TodoLists");
            DropIndex("dbo.TodoItems", new[] { "TodoListId" });
            DropTable("dbo.TodoLists");
            DropTable("dbo.TodoItems");
        }
    }
}

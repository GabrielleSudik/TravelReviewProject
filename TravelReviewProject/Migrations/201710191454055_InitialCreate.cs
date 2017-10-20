namespace TravelReviewProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Costs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EstimatedCost = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Country = c.String(),
                        Language = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserRating = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReviewTitle = c.String(),
                        UserReview = c.String(),
                        Date = c.DateTime(nullable: false),
                        DestinationID = c.Int(nullable: false),
                        RatingID = c.Int(nullable: false),
                        CostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Costs", t => t.CostID, cascadeDelete: true)
                .ForeignKey("dbo.Destinations", t => t.DestinationID, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.RatingID, cascadeDelete: true)
                .Index(t => t.DestinationID)
                .Index(t => t.RatingID)
                .Index(t => t.CostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RatingID", "dbo.Ratings");
            DropForeignKey("dbo.Reviews", "DestinationID", "dbo.Destinations");
            DropForeignKey("dbo.Reviews", "CostID", "dbo.Costs");
            DropIndex("dbo.Reviews", new[] { "CostID" });
            DropIndex("dbo.Reviews", new[] { "RatingID" });
            DropIndex("dbo.Reviews", new[] { "DestinationID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Ratings");
            DropTable("dbo.Destinations");
            DropTable("dbo.Costs");
        }
    }
}

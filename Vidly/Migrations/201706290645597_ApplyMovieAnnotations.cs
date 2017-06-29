namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyMovieAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
        }
    }
}

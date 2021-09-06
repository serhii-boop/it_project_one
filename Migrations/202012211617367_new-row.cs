namespace lab4_films.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newrow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "genre_new", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "genre_new");
        }
    }
}

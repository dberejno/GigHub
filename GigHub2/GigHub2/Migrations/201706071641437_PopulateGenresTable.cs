namespace GigHub2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            base.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            base.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            base.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rock')");
            base.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Country')");
        }
        
        public override void Down()
        {
            base.Sql("DELETE FROM Generes WHERE Id IN (1,2,3,4)");
        }
    }
}

namespace FriendOrganizer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProgrammingLanguage1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Friend", "FavoriteLanguageId");
            RenameColumn(table: "dbo.Friend", name: "FavouriteLanguage_Id", newName: "FavoriteLanguageId");
            RenameIndex(table: "dbo.Friend", name: "IX_FavouriteLanguage_Id", newName: "IX_FavoriteLanguageId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Friend", name: "IX_FavoriteLanguageId", newName: "IX_FavouriteLanguage_Id");
            RenameColumn(table: "dbo.Friend", name: "FavoriteLanguageId", newName: "FavouriteLanguage_Id");
            AddColumn("dbo.Friend", "FavoriteLanguageId", c => c.Int());
        }
    }
}

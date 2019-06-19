namespace MigracionesLibreriaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReestructuraLibros : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Libros", name: "Codigo", newName: "SSID");
            AlterColumn("dbo.Libros", "SSID", c => c.String(maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Libros", "SSID", c => c.String());
            RenameColumn(table: "dbo.Libros", name: "SSID", newName: "Codigo");
        }
    }
}

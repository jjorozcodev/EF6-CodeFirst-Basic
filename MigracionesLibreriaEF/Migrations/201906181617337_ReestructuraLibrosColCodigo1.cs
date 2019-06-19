namespace MigracionesLibreriaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReestructuraLibrosColCodigo1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Libros", name: "SSID_Libro", newName: "SSID_LibroCod");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Libros", name: "SSID_LibroCod", newName: "SSID_Libro");
        }
    }
}

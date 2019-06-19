namespace MigracionesLibreriaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReestructuraLibrosColCodigo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Libros", "SSID", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Libros", "SSID", c => c.String(maxLength: 30, unicode: false));
        }
    }
}

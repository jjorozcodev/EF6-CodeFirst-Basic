namespace MigracionesLibreriaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReestructuraEditorial : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Editorials", name: "Nombre", newName: "Descripcion");
            AlterColumn("dbo.Editorials", "Descripcion", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Editorials", "Descripcion", c => c.String(maxLength: 50, unicode: false));
            RenameColumn(table: "dbo.Editorials", name: "Descripcion", newName: "Nombre");
        }
    }
}

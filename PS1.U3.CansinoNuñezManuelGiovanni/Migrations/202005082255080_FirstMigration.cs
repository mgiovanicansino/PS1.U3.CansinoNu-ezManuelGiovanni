namespace PS1.U3.CansinoNuñezManuelGiovanni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Peliculas", "Fecha_Estreno", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Peliculas", "Fecha_Estreno", c => c.DateTime(nullable: false));
        }
    }
}

namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_cari_img : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carilers", "CariGorsel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carilers", "CariGorsel");
        }
    }
}

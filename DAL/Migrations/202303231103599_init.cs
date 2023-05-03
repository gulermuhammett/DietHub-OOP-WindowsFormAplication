namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Eposta = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 20),
                        Statu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AktiviteBilgileris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AktiviteKatSayi = c.Single(nullable: false),
                        Aktivite = c.Int(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 50),
                        Soyad = c.String(maxLength: 50),
                        DogumTarihi = c.DateTime(nullable: false),
                        Boy = c.Int(nullable: false),
                        Kilo = c.Single(nullable: false),
                        BoyunCevresi = c.Single(nullable: false),
                        BelCevresi = c.Single(nullable: false),
                        BasenCevresi = c.Single(nullable: false),
                        Cinsiyet = c.Int(nullable: false),
                        Eposta = c.String(),
                        Sifre = c.String(),
                        Statu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EgzersizBilgileris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Egzersiz = c.Int(nullable: false),
                        KaloriDegeri = c.Single(nullable: false),
                        EgzersizTarihi = c.DateTime(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.HedefBilgileris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HedefKatSayi = c.Single(nullable: false),
                        Hedef = c.Int(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                        Statu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        OgunAdi = c.Int(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        MenuToplamKalori = c.Int(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MenuId)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.BesinBilgileris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BesinAdi = c.String(),
                        OlcuBirimi = c.Int(nullable: false),
                        Gram = c.Single(),
                        Kalori = c.Single(nullable: false),
                        Karbonhidrat = c.Single(nullable: false),
                        Yag = c.Single(nullable: false),
                        Protein = c.Single(nullable: false),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategoris", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Sus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SuMiktari = c.Single(nullable: false),
                        SuTarihi = c.DateTime(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                        Statu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.VucutAnalizis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VKI = c.Single(nullable: false),
                        VYO = c.Single(nullable: false),
                        BMH = c.Single(nullable: false),
                        VucutAnaliziTarihi = c.DateTime(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                        Statu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.MenuBesin",
                c => new
                    {
                        MenulerRefID = c.Int(nullable: false),
                        YiyeceklerRefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MenulerRefID, t.YiyeceklerRefID })
                .ForeignKey("dbo.BesinBilgileris", t => t.MenulerRefID, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.YiyeceklerRefID, cascadeDelete: true)
                .Index(t => t.MenulerRefID)
                .Index(t => t.YiyeceklerRefID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AktiviteBilgileris", "KullaniciID", "dbo.Kullanicis");
            DropForeignKey("dbo.VucutAnalizis", "KullaniciID", "dbo.Kullanicis");
            DropForeignKey("dbo.Sus", "KullaniciID", "dbo.Kullanicis");
            DropForeignKey("dbo.MenuBesin", "YiyeceklerRefID", "dbo.Menus");
            DropForeignKey("dbo.MenuBesin", "MenulerRefID", "dbo.BesinBilgileris");
            DropForeignKey("dbo.BesinBilgileris", "KategoriID", "dbo.Kategoris");
            DropForeignKey("dbo.Menus", "KullaniciID", "dbo.Kullanicis");
            DropForeignKey("dbo.HedefBilgileris", "KullaniciID", "dbo.Kullanicis");
            DropForeignKey("dbo.EgzersizBilgileris", "KullaniciID", "dbo.Kullanicis");
            DropIndex("dbo.MenuBesin", new[] { "YiyeceklerRefID" });
            DropIndex("dbo.MenuBesin", new[] { "MenulerRefID" });
            DropIndex("dbo.VucutAnalizis", new[] { "KullaniciID" });
            DropIndex("dbo.Sus", new[] { "KullaniciID" });
            DropIndex("dbo.BesinBilgileris", new[] { "KategoriID" });
            DropIndex("dbo.Menus", new[] { "KullaniciID" });
            DropIndex("dbo.HedefBilgileris", new[] { "KullaniciID" });
            DropIndex("dbo.EgzersizBilgileris", new[] { "KullaniciID" });
            DropIndex("dbo.AktiviteBilgileris", new[] { "KullaniciID" });
            DropTable("dbo.MenuBesin");
            DropTable("dbo.VucutAnalizis");
            DropTable("dbo.Sus");
            DropTable("dbo.Kategoris");
            DropTable("dbo.BesinBilgileris");
            DropTable("dbo.Menus");
            DropTable("dbo.HedefBilgileris");
            DropTable("dbo.EgzersizBilgileris");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.AktiviteBilgileris");
            DropTable("dbo.Admins");
        }
    }
}

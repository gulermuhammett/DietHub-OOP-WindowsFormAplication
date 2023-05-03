namespace DAL.Migrations
{
    using Models.Entities;
    using Models.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context.DietHubDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Context.DietHubDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            #region Database
            //Kategori k1 = new Kategori() { KategoriAdi = "Tahıl ve Ekmek Ürünleri" };
            //context.Kategoriler.Add(k1);
            //Kategori k2 = new Kategori() { KategoriAdi = "Süt ve Süt Ürünleri" };
            //context.Kategoriler.Add(k2);
            //Kategori k3 = new Kategori() { KategoriAdi = "Meyveler" };
            //context.Kategoriler.Add(k3);
            //Kategori k4 = new Kategori() { KategoriAdi = "Balıklar" };
            //context.Kategoriler.Add(k4);
            //Kategori k5 = new Kategori() { KategoriAdi = "Beyaz Et Ürünleri" };
            //context.Kategoriler.Add(k5);
            //Kategori k6 = new Kategori() { KategoriAdi = "Kahvaltı Ürünleri" };
            //context.Kategoriler.Add(k6);
            //Kategori k7 = new Kategori() { KategoriAdi = "Et Ürünleri" };
            //context.Kategoriler.Add(k7);

            //ADMİN
            Kullanici admin = new Kullanici() { Ad = "Muhammet", Soyad = "Guler", DogumTarihi = DateTime.Now, Cinsiyet = Cinsiyet.Erkek, Boy = 185, Kilo = 85, BoyunCevresi = 40, BelCevresi = 100, BasenCevresi = 120, Eposta = "admin@diethub", Sifre = "123As.", Statu = true };
            context.Kullanicilar.Add(admin);


            ////BALIKLAR VE DENİZ ÜRÜNLERİ

            //BesinBilgileri somon = new BesinBilgileri() { BesinAdi = "Somon", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.08F, Karbonhidrat = 0, Protein = 0.19F, Yag = 0.13F, KategoriID = 4 };
            //context.BesinBilgileri.Add(somon);

            //BesinBilgileri ahtapot = new BesinBilgileri() { BesinAdi = "Ahtapot", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.73F, Karbonhidrat = 0.01F, Protein = 0.15F, Yag = 0.08F, KategoriID = 4 };
            //context.BesinBilgileri.Add(ahtapot);

            //BesinBilgileri alabalik = new BesinBilgileri() { BesinAdi = "Alabalık", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.01F, Karbonhidrat = 0, Protein = 0.19F, Yag = 0.02F, KategoriID = 4 };
            //context.BesinBilgileri.Add(alabalik);

            BesinBilgileri barbun = new BesinBilgileri() { BesinAdi = "Barbun", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.2F, Karbonhidrat = 0, Protein = 0.16F, Yag = 0.06F, KategoriID = 4 };
            context.BesinBilgileri.Add(barbun);

            BesinBilgileri cipura = new BesinBilgileri() { BesinAdi = "Çipura", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.2F, Karbonhidrat = 0, Protein = 0.16F, Yag = 0.06F, KategoriID = 4 };
            context.BesinBilgileri.Add(cipura);

            BesinBilgileri dilBaligi = new BesinBilgileri() { BesinAdi = "Dil Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.79F, Karbonhidrat = 0, Protein = 0.19F, Yag = 0, KategoriID = 4 };
            context.BesinBilgileri.Add(dilBaligi);

            BesinBilgileri hamsiIzgara = new BesinBilgileri() { BesinAdi = "Izgara Hamsi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2F, Karbonhidrat = 0.05F, Protein = 0.19F, Yag = 0.1F, KategoriID = 4 };
            context.BesinBilgileri.Add(hamsiIzgara);

            BesinBilgileri hamsiKizartma = new BesinBilgileri() { BesinAdi = "Kızartma Hamsi", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.15F, Yag = 0.05F, Karbonhidrat = 0, Protein = 0.17F, KategoriID = 4 };
            context.BesinBilgileri.Add(hamsiKizartma);

            BesinBilgileri havyar = new BesinBilgileri() { BesinAdi = "Havyar", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.62F, Karbonhidrat = 0.03F, Protein = 0.26F, Yag = 0.15F, KategoriID = 4 };
            context.BesinBilgileri.Add(havyar);

            BesinBilgileri istakoz = new BesinBilgileri() { BesinAdi = "Istakoz", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.91F, Karbonhidrat = 0F, Protein = 0.17F, Yag = 0.02F, KategoriID = 4 };
            context.BesinBilgileri.Add(istakoz);

            BesinBilgileri istavrit = new BesinBilgileri() { BesinAdi = "İstavrit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.81F, Karbonhidrat = 0F, Protein = 0.17F, Yag = 0.01F, KategoriID = 4 };
            context.BesinBilgileri.Add(istavrit);

            BesinBilgileri istiridye = new BesinBilgileri() { BesinAdi = "İstiridye", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.68F, Karbonhidrat = 0F, Protein = 0.09F, Yag = 0.01F, KategoriID = 4 };
            context.BesinBilgileri.Add(istiridye);

            BesinBilgileri izmarit = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.53F, Karbonhidrat = 0F, Protein = 0.23F, Yag = 0.06F, KategoriID = 4 };
            context.BesinBilgileri.Add(izmarit);

            BesinBilgileri kalkan = new BesinBilgileri() { BesinAdi = "Kalkan Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.35F, Karbonhidrat = 0F, Protein = 0.20F, Yag = 0.06F, KategoriID = 4 };
            context.BesinBilgileri.Add(kalkan);

            BesinBilgileri karidesGuvec = new BesinBilgileri() { BesinAdi = "Karides Güveç", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.25F, Karbonhidrat = 0.02F, Protein = 0.16F, Yag = 0.07F, KategoriID = 4 };
            context.BesinBilgileri.Add(karidesGuvec);

            BesinBilgileri tereyagdaKarides = new BesinBilgileri() { BesinAdi = "Tereyağda Karides", OlcuBirimi = OlcuBirimi.Gram, Kalori = 3.19F, Karbonhidrat = 0F, Protein = 0.16F, Yag = 0.29F, KategoriID = 4 };
            context.BesinBilgileri.Add(tereyagdaKarides);

            BesinBilgileri kefal = new BesinBilgileri() { BesinAdi = "Kefal Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.73F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0, KategoriID = 4 };
            context.BesinBilgileri.Add(kefal);

            BesinBilgileri kilic = new BesinBilgileri() { BesinAdi = "Kılıç Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.53F, Karbonhidrat = 0F, Protein = 0.23F, Yag = 0.06F, KategoriID = 4 };
            context.BesinBilgileri.Add(kilic);

            BesinBilgileri levrek = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.86F, Karbonhidrat = 0F, Protein = 0.18F, Yag = 0, KategoriID = 4 };
            context.BesinBilgileri.Add(levrek);

            BesinBilgileri lufer = new BesinBilgileri() { BesinAdi = "Lüfer", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.37F, Karbonhidrat = 0F, Protein = 0.16F, Yag = 0.09F, KategoriID = 4 };
            context.BesinBilgileri.Add(lufer);

            BesinBilgileri mezgit = new BesinBilgileri() { BesinAdi = "Mezgit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.82F, Karbonhidrat = 0F, Protein = 0.18F, Yag = 0.06F, KategoriID = 4 };
            context.BesinBilgileri.Add(mezgit);

            BesinBilgileri midyeDolma = new BesinBilgileri() { BesinAdi = "Midye Dolma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 26F, Karbonhidrat = 3.08F, Protein = 1.62F, Yag = 0.71F, Gram = 30, KategoriID = 4 };
            context.BesinBilgileri.Add(midyeDolma);

            BesinBilgileri midyeTava = new BesinBilgileri() { BesinAdi = "Midye Tava", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2F, Karbonhidrat = 0.08F, Protein = 0.09F, Yag = 0.10F, KategoriID = 4 };
            context.BesinBilgileri.Add(midyeTava);

            BesinBilgileri palamut = new BesinBilgileri() { BesinAdi = "Palamut", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.51F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.07F, KategoriID = 4 };
            context.BesinBilgileri.Add(palamut);

            BesinBilgileri sardalya = new BesinBilgileri() { BesinAdi = "Sardalya", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.60F, Karbonhidrat = 0F, Protein = 0.15F, Yag = 0.09F, KategoriID = 4 };
            context.BesinBilgileri.Add(sardalya);

            BesinBilgileri sazan = new BesinBilgileri() { BesinAdi = "Sazan", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.45F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.07F, KategoriID = 4 };
            context.BesinBilgileri.Add(sazan);

            BesinBilgileri denizTaragi = new BesinBilgileri() { BesinAdi = "Deniz Tarağı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 0.70F, Karbonhidrat = 0F, Protein = 0.10F, Yag = 0.01F, KategoriID = 4 };
            context.BesinBilgileri.Add(denizTaragi);

            BesinBilgileri tekir = new BesinBilgileri() { BesinAdi = "Tekir", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.51F, Yag = 0.04F, Karbonhidrat = 0F, Protein = 0.25F, KategoriID = 4 };
            context.BesinBilgileri.Add(tekir);

            BesinBilgileri ton = new BesinBilgileri() { BesinAdi = "Ton Balığı", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.90F, Karbonhidrat = 0F, Protein = 0.25F, Yag = 0.21F, KategoriID = 4 };
            context.BesinBilgileri.Add(ton);

            BesinBilgileri uskumru = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.91F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.12F, KategoriID = 4 };
            context.BesinBilgileri.Add(uskumru);

            BesinBilgileri yengec = new BesinBilgileri() { BesinAdi = "İzmarit", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.01F, Karbonhidrat = 0F, Protein = 0.19F, Yag = 0.18F, KategoriID = 4 };
            context.BesinBilgileri.Add(yengec);

            BesinBilgileri susi = new BesinBilgileri() { BesinAdi = "Suşi", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 125F, Karbonhidrat = 12.42F, Protein = 3.04F, Yag = 7.15F, Gram = 155, KategoriID = 4 };
            context.BesinBilgileri.Add(susi);

            //BEYAZ ET URUNLERİ

            BesinBilgileri HaslanmisTavukGogsu = new BesinBilgileri() { BesinAdi = "Haşlanmış Tavuk Göğsü", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.97F, Karbonhidrat = 0F, Protein = 0.30F, Yag = 0.08F, KategoriID = 5 };
            context.BesinBilgileri.Add(HaslanmisTavukGogsu);

            BesinBilgileri PismisTavukEti = new BesinBilgileri() { BesinAdi = "Pişmiş Tavuk Eti", OlcuBirimi = OlcuBirimi.Gram, Kalori = 2.20F, Yag = 0.12F, Karbonhidrat = 0F, Protein = 0.25F, KategoriID = 5 };
            context.BesinBilgileri.Add(PismisTavukEti);

            BesinBilgileri KizarmisKanat = new BesinBilgileri() { BesinAdi = "Kızarmış Tavuk Kanadı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 69F, Karbonhidrat = 0.50F, Protein = 5.85F, Yag = 4.92F, Gram = 30, KategoriID = 5 };
            context.BesinBilgileri.Add(KizarmisKanat);

            BesinBilgileri KizarmisBut = new BesinBilgileri()
            {
                BesinAdi = "Kızarmış Tavuk But",
                OlcuBirimi = OlcuBirimi.Gram,
                Kalori = 300F,
                Karbonhidrat = 0.76F,
                Protein = 13.8F,
                Yag = 26.65F,
                Gram = 80,
                KategoriID = 5
            };
            context.BesinBilgileri.Add(KizarmisBut);

            BesinBilgileri HaslanmisBut = new BesinBilgileri() { BesinAdi = "Haşlanmış Tavuk But", OlcuBirimi = OlcuBirimi.Gram, Kalori = 117F, Karbonhidrat = 4.38F, Protein = 7.96F, Gram = 80, Yag = 7.17F, KategoriID = 5 };
            context.BesinBilgileri.Add(HaslanmisBut);

            BesinBilgileri TavukKoftesi = new BesinBilgileri() { BesinAdi = "Tavuk Köftesi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 46F, Karbonhidrat = 2.25F, Protein = 4.13F, Gram = 30, Yag = 2.25F, KategoriID = 5 };
            context.BesinBilgileri.Add(TavukKoftesi);

            BesinBilgileri TavukCigeri = new BesinBilgileri() { BesinAdi = "Tavuk Ciğeri", OlcuBirimi = OlcuBirimi.Gram, Kalori = 1.72F, Karbonhidrat = 0.01F, Protein = 026F, Yag = 0.06F, KategoriID = 5 };
            context.BesinBilgileri.Add(TavukCigeri);

            BesinBilgileri TavukluPilav = new BesinBilgileri() { BesinAdi = "Tavuklu Pilav", OlcuBirimi = OlcuBirimi.Tabak, Kalori = 336F, Karbonhidrat = 46.77F, Protein = 15.90F, Yag = 9.03F, Gram = 220, KategoriID = 5 };
            context.BesinBilgileri.Add(TavukluPilav);

            BesinBilgileri TavukNugget = new BesinBilgileri() { BesinAdi = "Tavuk Nugget", OlcuBirimi = OlcuBirimi.Adet, Kalori = 121F, Karbonhidrat = 2.7F, Protein = 7.2F, Yag = 9F, Gram = 45, KategoriID = 5 };
            context.BesinBilgileri.Add(TavukNugget);

            BesinBilgileri EkmekAraTavukDoner = new BesinBilgileri() { BesinAdi = "Ekmek Arası Tavuk Döner", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 309F, Karbonhidrat = 15.13F, Protein = 43.10F, Yag = 36.37F, KategoriID = 5 };
            context.BesinBilgileri.Add(EkmekAraTavukDoner);

            BesinBilgileri KoriSosluTavuk = new BesinBilgileri() { BesinAdi = "Ekmek Arası Tavuk Döner", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 243F, Karbonhidrat = 8.92F, Protein = 31.95F, Yag = 7.9F, Gram = 170, KategoriID = 5 };
            context.BesinBilgileri.Add(KoriSosluTavuk);

            BesinBilgileri TavukSote = new BesinBilgileri() { BesinAdi = "Tavuk Sote", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 309F, Karbonhidrat = 15.13F, Protein = 43.10F, Yag = 36.37F, Gram = 250, KategoriID = 5 };
            context.BesinBilgileri.Add(TavukSote);

            //MEYVELER

            BesinBilgileri Elma = new BesinBilgileri() { BesinAdi = "Elma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 95F, Karbonhidrat = 25.13F, Protein = 0.47F, Yag = 0.31F, Gram = 180, KategoriID = 3 };
            context.BesinBilgileri.Add(Elma);

            BesinBilgileri Armut = new BesinBilgileri() { BesinAdi = "Elma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 101F, Karbonhidrat = 27.11F, Protein = 0.64F, Yag = 0.25F, Gram = 178, KategoriID = 3 };
            context.BesinBilgileri.Add(Armut);

            BesinBilgileri Portakal = new BesinBilgileri() { BesinAdi = "Portakal", OlcuBirimi = OlcuBirimi.Adet, Kalori = 62F, Karbonhidrat = 15.40F, Protein = 1.25F, Yag = 0.16F, Gram = 130, KategoriID = 3 };
            context.BesinBilgileri.Add(Portakal);

            BesinBilgileri Greyfurt = new BesinBilgileri() { BesinAdi = "Greyfurt", OlcuBirimi = OlcuBirimi.Adet, Kalori = 74F, Karbonhidrat = 18.45F, Protein = 1.35F, Yag = 0.25F, Gram = 245, KategoriID = 3 };
            context.BesinBilgileri.Add(Greyfurt);

            BesinBilgileri Ayva = new BesinBilgileri() { BesinAdi = "Elma", OlcuBirimi = OlcuBirimi.Adet, Kalori = 57F, Karbonhidrat = 15.30F, Protein = 0.40F, Yag = 0.10F, Gram = 250, KategoriID = 3 };
            context.BesinBilgileri.Add(Ayva);

            BesinBilgileri Mandalina = new BesinBilgileri() { BesinAdi = "Mandalina", OlcuBirimi = OlcuBirimi.Adet, Kalori = 40F, Karbonhidrat = 10.15F, Protein = 0.60F, Yag = 0.25F, Gram = 75, KategoriID = 3 };
            context.BesinBilgileri.Add(Mandalina);

            BesinBilgileri Kivi = new BesinBilgileri() { BesinAdi = "Kivi", OlcuBirimi = OlcuBirimi.Adet, Kalori = 42F, Karbonhidrat = 10.10F, Protein = 0.62F, Yag = 0.25F, Gram = 69, KategoriID = 3 };
            context.BesinBilgileri.Add(Kivi);

            BesinBilgileri Muz = new BesinBilgileri() { BesinAdi = "Muz", OlcuBirimi = OlcuBirimi.Adet, Kalori = 105F, Karbonhidrat = 27F, Protein = 1.30F, Yag = 0.40F, Gram = 118, KategoriID = 3 };
            context.BesinBilgileri.Add(Muz);

            BesinBilgileri Kayisi = new BesinBilgileri() { BesinAdi = "Kayısı", OlcuBirimi = OlcuBirimi.Adet, Kalori = 17F, Karbonhidrat = 3.90F, Protein = 0.50F, Yag = 0.15F, Gram = 35, KategoriID = 3 };
            context.BesinBilgileri.Add(Kayisi);

            BesinBilgileri Cilek = new BesinBilgileri() { BesinAdi = "Çilek", OlcuBirimi = OlcuBirimi.Kase, Kalori = 46F, Karbonhidrat = 11F, Protein = 0.95F, Yag = 0.45F, Gram = 144, KategoriID = 3 };
            context.BesinBilgileri.Add(Cilek);

            BesinBilgileri TrabzonHurmasi = new BesinBilgileri() { BesinAdi = "Trabzon Hurması", OlcuBirimi = OlcuBirimi.Adet, Kalori = 60F, Karbonhidrat = 16F, Protein = 0.50F, Yag = 0.17F, Gram = 80, KategoriID = 3 };
            context.BesinBilgileri.Add(TrabzonHurmasi);

            BesinBilgileri Kiraz = new BesinBilgileri() { BesinAdi = "Kiraz", OlcuBirimi = OlcuBirimi.Kase, Kalori = 87F, Karbonhidrat = 22.10F, Protein = 1.45F, Yag = 0.30F, Gram = 138, KategoriID = 3 };
            context.BesinBilgileri.Add(Kiraz);

            BesinBilgileri Visne = new BesinBilgileri() { BesinAdi = "Vişne", OlcuBirimi = OlcuBirimi.Kase, Kalori = 52F, Karbonhidrat = 13F, Protein = 1.03F, Yag = 0.30F, Gram = 250, KategoriID = 3 };
            context.BesinBilgileri.Add(Visne);

            BesinBilgileri Kavun = new BesinBilgileri() { BesinAdi = "Kavun", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 54F, Karbonhidrat = 13.05F, Protein = 1.35F, Yag = 0.30F, Gram = 150, KategoriID = 3 };
            context.BesinBilgileri.Add(Kavun);

            BesinBilgileri Karpuz = new BesinBilgileri() { BesinAdi = "Karpuz", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 46F, Karbonhidrat = 15.13F, Protein = 43.10F, Yag = 36.37F, Gram = 150, KategoriID = 3 };
            context.BesinBilgileri.Add(Karpuz);

            BesinBilgileri Ananas = new BesinBilgileri() { BesinAdi = "Ananas", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 28F, Karbonhidrat = 7.35F, Protein = 0.30F, Yag = 0.07F, Gram = 56, KategoriID = 3 };
            context.BesinBilgileri.Add(Ananas);


            BesinBilgileri Avakado = new BesinBilgileri() { BesinAdi = "Avakado", OlcuBirimi = OlcuBirimi.Adet, Kalori = 160F, Karbonhidrat = 8.5F, Protein = 2.0F, Yag = 14.7F, Gram = 100, KategoriID = 3 };
            context.BesinBilgileri.Add(Avakado);

            BesinBilgileri Mango = new BesinBilgileri() { BesinAdi = "Mango", OlcuBirimi = OlcuBirimi.Adet, Kalori = 100F, Karbonhidrat = 24.70F, Protein = 1.35F, Yag = 0.63F, Gram = 165, KategoriID = 3 };
            context.BesinBilgileri.Add(Mango);

            BesinBilgileri Ahududu = new BesinBilgileri() { BesinAdi = "Ahududu", OlcuBirimi = OlcuBirimi.Kase, Kalori = 64F, Karbonhidrat = 14.70F, Protein = 1.5F, Yag = 0.80F, Gram = 125, KategoriID = 3 };
            context.BesinBilgileri.Add(Ahududu);

            BesinBilgileri Bogurtlen = new BesinBilgileri() { BesinAdi = "Böğürtlen", OlcuBirimi = OlcuBirimi.Kase, Kalori = 62F, Karbonhidrat = 13.80F, Protein = 1.5F, Yag = 0.80F, Gram = 100, KategoriID = 3 };
            context.BesinBilgileri.Add(Bogurtlen);

            BesinBilgileri YesilErik = new BesinBilgileri() { BesinAdi = "Yeşil Erik", OlcuBirimi = OlcuBirimi.Kase, Kalori = 76F, Karbonhidrat = 18.85F, Protein = 1.15F, Yag = 0.5F, Gram = 165, KategoriID = 3 };
            context.BesinBilgileri.Add(YesilErik);

            BesinBilgileri Incir = new BesinBilgileri() { BesinAdi = "İncir", OlcuBirimi = OlcuBirimi.Adet, Kalori = 37F, Karbonhidrat = 9.35F, Protein = 0.4F, Yag = 0.15F, Gram = 50, KategoriID = 3 };
            context.BesinBilgileri.Add(Incir);

            BesinBilgileri Dut = new BesinBilgileri() { BesinAdi = "Dut", OlcuBirimi = OlcuBirimi.Kase, Kalori = 60F, Karbonhidrat = 13.70F, Protein = 2F, Yag = 0.55F, Gram = 140, KategoriID = 3 };
            context.BesinBilgileri.Add(Dut);

            BesinBilgileri Uzum = new BesinBilgileri() { BesinAdi = "Üzüm", OlcuBirimi = OlcuBirimi.Kase, Kalori = 104F, Karbonhidrat = 27.3F, Protein = 1.1F, Yag = 0.25F, Gram = 150, KategoriID = 3 };
            context.BesinBilgileri.Add(Uzum);

            BesinBilgileri Nar = new BesinBilgileri() { BesinAdi = "Nar", OlcuBirimi = OlcuBirimi.Kase, Kalori = 145F, Karbonhidrat = 33F, Protein = 3F, Yag = 2F, Gram = 170, KategoriID = 3 };
            context.BesinBilgileri.Add(Nar);

            BesinBilgileri Seftali = new BesinBilgileri() { BesinAdi = "Şeftali", OlcuBirimi = OlcuBirimi.Adet, Kalori = 60F, Karbonhidrat = 14.30F, Protein = 1.36F, Yag = 0.38F, Gram = 150, KategoriID = 3 };
            context.BesinBilgileri.Add(Seftali);

            BesinBilgileri Limon = new BesinBilgileri() { BesinAdi = "Limon", OlcuBirimi = OlcuBirimi.Adet, Kalori = 17F, Karbonhidrat = 5.4F, Protein = 0.65F, Yag = 0.17F, Gram = 58, KategoriID = 3 };
            context.BesinBilgileri.Add(Limon);

            BesinBilgileri KirmiziErik = new BesinBilgileri() { BesinAdi = "Kırmızı Erik", OlcuBirimi = OlcuBirimi.Kase, Kalori = 80F, Karbonhidrat = 21F, Protein = 1F, Yag = 0.15F, Gram = 135, KategoriID = 3 };
            context.BesinBilgileri.Add(KirmiziErik);


            //SÜT ÜRÜNLERİ

            BesinBilgileri TamyagliInekSutu = new BesinBilgileri() { BesinAdi = "Tam Yağlı İnek Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 110F, Karbonhidrat = 8.64F, Protein = 5.65F, Yag = 5.85F, KategoriID = 2 };
            context.BesinBilgileri.Add(TamyagliInekSutu);

            BesinBilgileri YarimYagliInekSutu = new BesinBilgileri() { BesinAdi = "Yarım Yağlı İnek Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 92F, Karbonhidrat = 10.84F, Protein = 6.66F, Yag = 2.10F, KategoriID = 2 };
            context.BesinBilgileri.Add(YarimYagliInekSutu);

            BesinBilgileri KeciSutu = new BesinBilgileri() { BesinAdi = "Keçi Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 124F, Karbonhidrat = 10F, Protein = 6.66F, Yag = 6.66F, KategoriID = 2 };
            context.BesinBilgileri.Add(KeciSutu);

            BesinBilgileri SoyaSutu = new BesinBilgileri() { BesinAdi = "Soya Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 112F, Karbonhidrat = 17.6F, Protein = 4F, Yag = 2.4F, KategoriID = 2 };
            context.BesinBilgileri.Add(SoyaSutu);

            BesinBilgileri BademSutu = new BesinBilgileri() { BesinAdi = "Badem Sütü", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 48F, Karbonhidrat = 6F, Protein = 1F, Yag = 2.2F, KategoriID = 2 };
            context.BesinBilgileri.Add(BademSutu);

            BesinBilgileri BeyazPeynir = new BesinBilgileri() { BesinAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 93F, Karbonhidrat = 0.76F, Protein = 6.11F, Yag = 7.30F, Gram = 30, KategoriID = 2 };
            context.BesinBilgileri.Add(BeyazPeynir);

            BesinBilgileri SuzmePeynir = new BesinBilgileri() { BesinAdi = "Süzme Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 72F, Karbonhidrat = 1.14F, Protein = 3.4F, Yag = 6F, Gram = 30, KategoriID = 2 };
            context.BesinBilgileri.Add(SuzmePeynir);

            BesinBilgileri LorPeyniri = new BesinBilgileri() { BesinAdi = "Lor Peyniri", OlcuBirimi = OlcuBirimi.CorbaKasigi, Kalori = 30F, Karbonhidrat = 0.14F, Protein = 2.17F, Yag = 2.34F, Gram = 15, KategoriID = 2 };
            context.BesinBilgileri.Add(LorPeyniri);

            BesinBilgileri KasarPeyniri = new BesinBilgileri() { BesinAdi = "Kaşar Peyniri", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 71F, Karbonhidrat = 0.51F, Protein = 5.4F, Yag = 5.32F, Gram = 20, KategoriID = 2 };
            context.BesinBilgileri.Add(KasarPeyniri);

            BesinBilgileri Labne = new BesinBilgileri() { BesinAdi = "Labne", OlcuBirimi = OlcuBirimi.TatliKasigi, Kalori = 10F, Karbonhidrat = 0.28F, Protein = 0.25F, Yag = 0.9F, Gram = 5, KategoriID = 2 };
            context.BesinBilgileri.Add(Labne);

            BesinBilgileri OrguPeynir = new BesinBilgileri() { BesinAdi = "Örgü Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 72F, Karbonhidrat = 0.38F, Protein = 6.25F, Yag = 5F, Gram = 25, KategoriID = 2 };
            context.BesinBilgileri.Add(OrguPeynir);

            BesinBilgileri DilPeyniri = new BesinBilgileri() { BesinAdi = "Dil Peyniri", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 68F, Karbonhidrat = 1.58F, Protein = 4.3F, Yag = 4.93F, Gram = 25, KategoriID = 2 };
            context.BesinBilgileri.Add(DilPeyniri);

            BesinBilgileri HellimPeyniri = new BesinBilgileri() { BesinAdi = "Hellim Peyniri", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 90F, Karbonhidrat = 0.26F, Protein = 6.98F, Yag = 7.38F, Gram = 25, KategoriID = 2 };
            context.BesinBilgileri.Add(HellimPeyniri);

            BesinBilgileri Mozarella = new BesinBilgileri() { BesinAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 90F, Karbonhidrat = 0.66F, Protein = 6.61F, Yag = 6.71F, Gram = 30, KategoriID = 2 };
            context.BesinBilgileri.Add(Mozarella);

            BesinBilgileri CheddarPeyniri = new BesinBilgileri() { BesinAdi = "Beyaz Peynir", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 61F, Karbonhidrat = 0F, Protein = 3.71F, Yag = 5.1F, Gram = 15, KategoriID = 2 };
            context.BesinBilgileri.Add(CheddarPeyniri);

            BesinBilgileri Kefir = new BesinBilgileri() { BesinAdi = "Kefir", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 120F, Karbonhidrat = 10F, Protein = 5.6F, Yag = 6F, KategoriID = 2 };
            context.BesinBilgileri.Add(Kefir);

            BesinBilgileri Yogurt = new BesinBilgileri() { BesinAdi = "Yoğurt", OlcuBirimi = OlcuBirimi.Kase, Kalori = 122F, Karbonhidrat = 9.32F, Protein = 6.94F, Yag = 6.5F, Gram = 200, KategoriID = 2 };
            context.BesinBilgileri.Add(Yogurt);

            BesinBilgileri Ayran = new BesinBilgileri() { BesinAdi = "Ayran", OlcuBirimi = OlcuBirimi.SuBardagi, Kalori = 76F, Karbonhidrat = 5.6F, Protein = 4F, Yag = 4F, KategoriID = 2 };
            context.BesinBilgileri.Add(Ayran);

            BesinBilgileri Cacik = new BesinBilgileri() { BesinAdi = "Cacık", OlcuBirimi = OlcuBirimi.Kase, Kalori = 115F, Karbonhidrat = 11F, Protein = 6.66F, Yag = 4.85F, Gram = 200, KategoriID = 2 };
            context.BesinBilgileri.Add(Cacik);


            //KAHVALTILI SICAKLARI

            BesinBilgileri HaslanmisYumurta = new BesinBilgileri() { BesinAdi = "Haşlanmış Yumurta", OlcuBirimi = OlcuBirimi.Adet, Kalori = 78F, Karbonhidrat = 0.56F, Protein = 6.3F, Yag = 5.31F, Gram = 50, KategoriID = 6 };
            context.BesinBilgileri.Add(HaslanmisYumurta);

            BesinBilgileri Omlet = new BesinBilgileri() { BesinAdi = "Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 101F, Karbonhidrat = 1.27F, Protein = 6.7F, Yag = 7.94F, Gram = 55, KategoriID = 6 };
            context.BesinBilgileri.Add(Omlet);

            BesinBilgileri PeynirliOmlet = new BesinBilgileri() { BesinAdi = "Peynirli Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 254F, Karbonhidrat = 2.05F, Protein = 15.3F, Yag = 15F, Gram = 130, KategoriID = 6 };
            context.BesinBilgileri.Add(PeynirliOmlet);

            BesinBilgileri MantarliOmlet = new BesinBilgileri() { BesinAdi = "Mantarlı Omlet", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 205F, Karbonhidrat = 3.7F, Protein = 12.45F, Yag = 10F, Gram = 150, KategoriID = 6 };
            context.BesinBilgileri.Add(MantarliOmlet);

            BesinBilgileri Menemen = new BesinBilgileri() { BesinAdi = "Menemen", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 205F, Karbonhidrat = 3.7F, Protein = 12.45F, Yag = 10F, Gram = 150, KategoriID = 6 };
            context.BesinBilgileri.Add(Menemen);

            BesinBilgileri SucukluYumurta = new BesinBilgileri() { BesinAdi = "Sucuklu Yumurta", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 242F, Karbonhidrat = 3.4F, Protein = 13.5F, Yag = 19.5F, Gram = 100, KategoriID = 6 };
            context.BesinBilgileri.Add(SucukluYumurta);

            BesinBilgileri Kuymak = new BesinBilgileri() { BesinAdi = "Kuymak - Mıhlama", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 489F, Karbonhidrat = 3.95F, Protein = 19.1F, Yag = 44.4F, Gram = 120, KategoriID = 6 };
            context.BesinBilgileri.Add(Kuymak);

            //SARKUTERI

            BesinBilgileri Sucuk = new BesinBilgileri() { BesinAdi = "Sucuk", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 166F, Karbonhidrat = 2.57F, Protein = 7.1F, Yag = 14.2F, Gram = 50, KategoriID = 7 };
            context.BesinBilgileri.Add(Sucuk);

            BesinBilgileri Sosis = new BesinBilgileri() { BesinAdi = "Sosis", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 60F, Karbonhidrat = 0.12F, Protein = 2.24F, Yag = 5.6F, Gram = 40, KategoriID = 7 };
            context.BesinBilgileri.Add(Sosis);

            BesinBilgileri DanaSalam = new BesinBilgileri() { BesinAdi = "Dana Salam", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 45F, Karbonhidrat = 0.64F, Protein = 1.65F, Yag = 3.92F, Gram = 15, KategoriID = 7 };
            context.BesinBilgileri.Add(DanaSalam);

            BesinBilgileri HindiSalam = new BesinBilgileri() { BesinAdi = "Hindi Salam", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 17F, Karbonhidrat = 0.24F, Protein = 1.31F, Yag = 1.13F, Gram = 8, KategoriID = 7 };
            context.BesinBilgileri.Add(HindiSalam);

            BesinBilgileri DanaJambon = new BesinBilgileri() { BesinAdi = "Dana Jambon", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 32F, Karbonhidrat = 0.7F, Protein = 4.92F, Yag = 0F, Gram = 30, KategoriID = 7 };
            context.BesinBilgileri.Add(DanaJambon);

            BesinBilgileri HindiJambon = new BesinBilgileri() { BesinAdi = "Hindi Jambon", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 15F, Karbonhidrat = 0.35F, Protein = 2.35F, Yag = 0.46F, Gram = 12, KategoriID = 7 };
            context.BesinBilgileri.Add(HindiJambon);

            BesinBilgileri PilicJambon = new BesinBilgileri() { BesinAdi = "Piliç Jambon", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 11F, Karbonhidrat = 0.12F, Protein = 1.56F, Yag = 0.44F, Gram = 12, KategoriID = 7 };
            context.BesinBilgileri.Add(PilicJambon);

            BesinBilgileri HindiFume = new BesinBilgileri() { BesinAdi = "Hindi Füme", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 51F, Karbonhidrat = 0F, Protein = 8.8F, Yag = 1.5F, Gram = 30, KategoriID = 7 };
            context.BesinBilgileri.Add(HindiFume);

            BesinBilgileri PilicFume = new BesinBilgileri() { BesinAdi = "Pilic Füme", OlcuBirimi = OlcuBirimi.Dilim, Kalori = 26F, Karbonhidrat = 0.3F, Protein = 3.9F, Yag = 0.9F, Gram = 30, KategoriID = 7 };
            context.BesinBilgileri.Add(PilicFume);

            BesinBilgileri Pastirma = new BesinBilgileri() { BesinAdi = "Pastırma", OlcuBirimi = OlcuBirimi.Porsiyon, Kalori = 75F, Karbonhidrat = 0F, Protein = 8.85F, Yag = 4.17F, Gram = 30, KategoriID = 7 };
            context.BesinBilgileri.Add(Pastirma);
            #endregion
        }
    }
}

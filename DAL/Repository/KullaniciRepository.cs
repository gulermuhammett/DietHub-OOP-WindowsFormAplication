using DAL.Context;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KullaniciRepository : BaseRepository<Kullanici>
    {
        DietHubDbContext db;


        public KullaniciRepository()
        {
            db = new DietHubDbContext();
        }

        public override bool Delete(int id)
        {
            Kullanici deleteHedef = db.Kullanicilar.Find(id);
            deleteHedef.Statu = false;
            return db.SaveChanges() > 0;
        }

        public override List<Kullanici> GetAll()
        {
            return db.Kullanicilar.ToList();
        }

        public override Kullanici GetById(int id)
        {
            return db.Kullanicilar.Find(id);
        }

        public Kullanici GetByMail(string mail)
        {
            return db.Kullanicilar.Where(a => a.Eposta == mail).FirstOrDefault();
        }

        public override bool Insert(Kullanici entity)
        {
            db.Kullanicilar.Add(entity);
            return db.SaveChanges() > 0;
        }

        public override bool Update(Kullanici entity)
        {
            var updateKullanici = GetById(entity.ID);
            db.Entry(updateKullanici).CurrentValues.SetValues(entity);
            return db.SaveChanges() > 0;
        }
        public bool CheckMail(Kullanici entity)
        {
            bool check = db.Kullanicilar.Where(a => a.Eposta == entity.Eposta).FirstOrDefault() == null ? true : false;
            return check;
        }

        public bool CheckLogin(Kullanici entity)
        {
            bool check = db.Kullanicilar.Where(a => a.Eposta == entity.Eposta && a.Sifre == entity.Sifre).FirstOrDefault() == null ? true : false;
            return check;
        }

        public Aktivite AktiviteGetir(Kullanici entity)
        {
            var result = (Aktivite)db.Aktiviteler.Where(a => a.KullaniciID == entity.ID).FirstOrDefault().Aktivite;
            return result;
        }

        public Hedef HedefGetir(Kullanici entity)
        {
            var result = db.HedefBilgileri.Where(a => a.KullaniciID == entity.ID).FirstOrDefault().Hedef;
            return result;
        }
    }
}

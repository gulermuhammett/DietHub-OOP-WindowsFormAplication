using BLL.Services;
using DAL.Context;
using DAL.Repository;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciService : BaseService<Kullanici>
    {
        HedefBilgileri hedef = new HedefBilgileri();
        AktiviteBilgileri aktivite = new AktiviteBilgileri();
        KullaniciRepository kullaniciRepository;
        public KullaniciService()
        {
            kullaniciRepository = new KullaniciRepository();
        }

        public override bool Delete(int id)
        {
            return kullaniciRepository.Delete(id);
        }

        public override List<Kullanici> GetAll()
        {
            return kullaniciRepository.GetAll();
        }

        public override Kullanici GetById(int id)
        {
            return kullaniciRepository.GetById(id);
        }

        public override bool Insert(Kullanici entity)
        {
            if (string.IsNullOrEmpty(entity.Ad) || string.IsNullOrEmpty(entity.Soyad) || string.IsNullOrEmpty(entity.Sifre) || string.IsNullOrEmpty(entity.Eposta))
            {
                throw new Exception("Ad, Soyad, Şifre veya E-Posta boş geçilemez");
            }
            if (!CheckMail(entity))
            {
                throw new Exception("Eposta mevcut, farklı bir eposta giriniz!");
            }

            return kullaniciRepository.Insert(entity);
        }

        public override bool Update(Kullanici entity)
        {
            return kullaniciRepository.Update(entity);
        }

        public bool CheckMail(Kullanici entity)//üye ol
        {
            return kullaniciRepository.CheckMail(entity);
        }

        public bool CheckLogin(Kullanici entity)//giris
        {
            return kullaniciRepository.CheckLogin(entity);
        }

        public Kullanici KullaniciGirisKontrol(Kullanici entity)//giris
        {
            Kullanici kullanici;
            if (CheckLogin(entity))
            {
                throw new Exception("Hatalı eposta veya şifre girdiniz!");
            }
            
            else
            {
                kullanici = kullaniciRepository.GetByMail(entity.Eposta);
            }
            return kullanici;
        }

        public float VucutKitleIndeksHesapla(Kullanici entity)
        {
            float bmi;
            float boy = (float)entity.Boy / 100;
            bmi = (float)(entity.Kilo / (boy * boy));
            return bmi;
        }

        public float VucutYagOraniHesapla(Kullanici entity)
        {
            float vyo = 0;

            if (entity.Cinsiyet == Cinsiyet.Erkek)
            {
                vyo = (float)(495 / (1.0324 - 0.19077 * Math.Log10(entity.BelCevresi - entity.BoyunCevresi) + 0.15456 * Math.Log10(entity.Boy)) - 450);
            }
            if (entity.Cinsiyet == Cinsiyet.Kadın)
            {
                vyo = (float)(495 / (1.29579 - 0.35004 * Math.Log10(entity.BelCevresi + entity.BasenCevresi - entity.BoyunCevresi) + 0.22100 * Math.Log10(entity.Boy)) - 450);
            }
            return vyo;
        }

        public float BazalMetabolizmaHesapla(Kullanici entity)
        {
            float bmh = 0;

            if (entity.Cinsiyet == Cinsiyet.Erkek)
            {
                bmh = (float)(65.5 + (9.6 * entity.Kilo) + (1.8 * entity.Boy) - (4.7 * entity.YasHesapla(entity.DogumTarihi)));
            }
            if (entity.Cinsiyet == Cinsiyet.Kadın)
            {
                bmh = (float)(66.5 + (13.7 * entity.Kilo) + (5 * entity.Boy) - (6.7 * entity.YasHesapla(entity.DogumTarihi)));
            }
            return bmh * (float)aktivite.AktiviteKatsayiHesapla(kullaniciRepository.AktiviteGetir(entity)) + hedef.HedefKatsayi(kullaniciRepository.HedefGetir(entity));
        }

        public float BazalMetabolizmaKatSayisiz(Kullanici entity)
        {
            float bmh = 0;

            if (entity.Cinsiyet == Cinsiyet.Erkek)
            {
                bmh = (float)(65.5 + (9.6 * entity.Kilo) + (1.8 * entity.Boy) - (4.7 * entity.YasHesapla(entity.DogumTarihi)));
            }
            if (entity.Cinsiyet == Cinsiyet.Kadın)
            {
                bmh = (float)(66.5 + (13.7 * entity.Kilo) + (5 * entity.Boy) - (6.7 * entity.YasHesapla(entity.DogumTarihi)));
            }
            return bmh;
        }

        public float BelKalcaOrani(Kullanici entity)
        {
            float belKalca = (entity.BelCevresi / entity.BasenCevresi);
            return belKalca;
        }
    }
}

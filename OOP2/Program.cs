
using OOP2;

GercekMusteri musteri1=new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "123456";
musteri1.TcNo = "5555555";
musteri1.Adi = "Rabia";
musteri1.Soyadi = "Çobanlı";


TuzelMusteri musteri2=new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "23456";
musteri2.VergiNo = "123456";
musteri2.SirketAdi = "Kodlama.io";


Musteri musteri3=new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Kutuphane
{
    public class Kitap // nesneleri tanımlayacağım Kitap adında bir sınıf oluşturuyorum.
    {
        public string _kitapAdi { get; set; }
        public string _yazarAdi { get; set; }
        public string _yazarSoyad { get; set; }
        public int _sayfa { get; set; }
        public string _yayinEvi { get; set; }
        public DateTime _kayitTarihi { get; set; }

        //Default constructer
        public Kitap()
        {
            _kayitTarihi = DateTime.Now;
        }

        //Parametre girdiğimiz constructer.
        public Kitap(string kitapAdi, string yazarAdi, string yazarSoyad, int sayfa, string yayinEvi)
        {
            _kitapAdi = kitapAdi;
            _yazarAdi = yazarAdi;
            _yazarSoyad = yazarSoyad;
            _sayfa = sayfa;
            _yayinEvi = yayinEvi;
            _kayitTarihi = DateTime.Now;
        }

        //Kitap bilgilerini yazdıran metot.
        public void bilgiler()
        {
            Console.WriteLine($"\nKitap Adı: {_kitapAdi}");
            Console.WriteLine($"Yazar Adı: {_yazarAdi}");
            Console.WriteLine($"Yazar Soyadı : {_yazarSoyad}");
            Console.WriteLine($"Sayfa Sayısı : {_sayfa}");
            Console.WriteLine($"Yayın Evi : {_yayinEvi}");
            Console.WriteLine($"Kayıt Tarihi : {_kayitTarihi}");

        }

    }
}

using Pratik_Kutuphane;

class Program
{
    public static void Main()
    {
        //Default constructer kullanarak ilk örenği oluşturuyorum
        Kitap kitap = new Kitap();
        kitap._kitapAdi = "Kırmızı Saçlı Kadın";
        kitap._yazarAdi = "Orhan";
        kitap._yazarSoyad = "Pamuk";
        kitap._sayfa = 204;
        kitap._yayinEvi = "Yapı Kredi Yayınları";
        kitap.bilgiler();

        //Parametrelerini girdiğimiz bir constructer oluşturuyorum.
        Kitap kitap1 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        kitap1.bilgiler();
    }

}

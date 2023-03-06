namespace KDV_Ögrenci_Proje4
//C# CONSOLE: Girilen ürün fiyatına göre ½18 kdv uygulanmış fiyatını ve ½5 öğrenci indirimi uygulanmış fiyatını ekrana yazan programın uygulamasını yapınız.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double islem,kdvlihesap = 0,ögrencihesap=0;//değişkenleri belirledim.
            Console.Write("Fiyatı Giriniz :");// hesap yapılacak tutarı istedim.
            double sayigir = double.Parse(Console.ReadLine());

            islem = sayigir * 0.18;//kdv işlemini yaptım.
            kdvlihesap = islem + sayigir;//girilen fiyatın üstüne ekledim.
            ögrencihesap = sayigir -(sayigir * 0.05);//girilen fiyattan öğrenci indirimini çıkardım.

            Console.WriteLine("KDV'li hesap :"+kdvlihesap);
            Console.WriteLine("Ögrenci indirimli hesap :" + ögrencihesap);//çıktıları aldım.
        }
    }
}
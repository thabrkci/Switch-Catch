// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;

//Expression Switch-Case deyimi if-else deyimleri gibi karar kontrol yapılarıdır. 
//Switch-Case ifadeleri yapabileceğiniz her şeyi if-else blokları ile de yapabiliriz. 
//Bir ifade üç veya daha fazla koşula göre ayrıştırıldığında genel olarak if-else'e ,
//alternatif olarak switch case kullanılır.
switch (month)
{
    case 10://
    Console.WriteLine("Ekim ayındasınız!");//
        break;
    default:
    Console.WriteLine("Yanlış tarihi girdiniz!");//Case'de 10.ay değilde 2.ay olmuş olsaydı bu hata ile 
    //karşılaşılacaktı.
        break;



       
}


switch (month)
{
    case 10://Birden fazla case yazdırma örneği 10 11 ve 12 aylarda isek otomatik olarak alltaki mesaj alınır
    case 11:
    case 12:
    Console.WriteLine("Sonbahar ayındasınız!");
    Console.WriteLine("Aman hasta olmayın :)");
        break;
    default:
        break;
}


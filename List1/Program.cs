//  Bir liste oluşturuyoruz ve ziyaretçilerin isimlerini ekliyoruz
List<string> davetliler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

//  Liste içerisinde for döngüsü ile dönerek isimlerini ekrana yazdırma
Console.WriteLine("* Davetliler *");
int index = 1;
foreach (string davetli in davetliler)
{
    Console.WriteLine("{0} - {1}", index++, davetli);
}

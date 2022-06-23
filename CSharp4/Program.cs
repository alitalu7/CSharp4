try
{
    Console.WriteLine("Bir sayı giriniz...");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Bir sayı giriniz...");
    int b = Convert.ToInt32(Console.ReadLine());
    int sonuc = a + b;
    Console.WriteLine(sonuc);

}
catch
{
    Console.WriteLine("Bir hata oluştu...");
}

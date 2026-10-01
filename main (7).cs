using System;

class Pembanding
{
    public static void Main(string[] args)
    {
        int mangga, apel = 0;
        
        COnsole.Write("jumlah mangga = ");
        mangga = int.Parse(Console.Readline());
        Console.Write("jumlah apel = ");
        apel = int.Parse(Console.Readline());
        
        Console.WriteLine("Hasil Perbandingan : ");
        Console.WriteLine($"mangga > apel : {mangga > apel}");
        Console.WriteLine($"mangga < apel : {mangga < apel}");
        Console.WriteLine($"mangga >= apel : {mangga >= apel}");
        Console.WriteLine($"mangga <= apel : {mangga <= apel}");
        Console.WriteLine($"mangga == apel : {mangga == apel}");
        Console.WriteLine($"mangga != apel : {mangga != apel}");
    }
}
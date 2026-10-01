using System;

class Aritmatika
{
    static void Main(string[] args)
    {
        int mangga, apel, hasil=0;
        
        Console.WriteLine("=== Aritmatika ===");
        
        Console.Write("mangga = ");
        mangga = int.Parse(Console.ReadLine());
        Console.Write("apel = ");
        apel = int.Parse(Console.Readline());
        
        hasil = mangga + apel;
        hasil = mangga - apel;
        hasil = mangga / apel;
        hasil = mangga * apel;
        hasil = mangga % apel;
        
        Console.WriteLine ($"hasil mangga + apel = {mangga + apel}");
        Console.WriteLine ($"hasil mangga - apel = {mangga - apel}");
        Console.WriteLine ($"hasil mangga / apel = {mangga / apel}");
        Console.WriteLine ($"hasil mangga * apel = {mangga * apel}");
        Console.WriteLine ($"hasil mangga % apel = {mangga % apel}");
    }
}
using System;

class LuasLingkaran 
{
  static void Main(string[] args) 
  {
    const float Phi = 3.14f;
    Console.WriteLine("=== Luas Lingkaran ===");
    Console.Write("Input Jari-Jari : ");
    int r = int.Parse(Console.ReadLine());
    
    var luas = Phi * r * r;
    
    Console.WriteLine($"Luas Lingkaran = {luas}");
    
  }
}
using System;

class Pendaftaran_Penduduk
{
    static void Main(string[] args)
    {
    //membuat variabel kosong
    string nama;
    int umur;
    
    Console.WriteLine("=== Program Pendaftaran Penduduk ===");
    Console.Write("Masukkan Nama : ");
    nama = Console.ReadLine();
    Console.Write("Masukkan Alamat : ");
    var alamat = Console.ReadLine();
    Console.Write("Masukkan Umur : ");
    umur = int.Parse(Console.ReadLine());
    
    Console.WriteLine();
    Console.WriteLine("Terimakasih");
    Console.WriteLine("Data Berikut");
    Console.WriteLine("$Nama : {nama}");
    Console.WriteLine("$Alamat : {alamat}");
    Console.WriteLine("$Umur : {umur} tahun");
    Console.WriteLine("Sudah Disimpan!");
    }
}
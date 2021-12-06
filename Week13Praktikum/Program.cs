using System;

namespace Week13Praktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Berapa Data = ");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.Write("NIM              :");
            int nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("NAMA             :");
            int nama = Convert.ToInt32(Console.ReadLine());
            Console.Write("JENIS KELAMIN    :");
            int jenisKelamin = Convert.ToInt32(Console.ReadLine());
            Console.Write("TAHUN MASUK      :");
            int tahunMasuk = Convert.ToInt32(Console.ReadLine());
            Console.Write("PROGRAM STUDI    :");
            int programStudi = Convert.ToInt32(Console.ReadLine());
            Console.Write("KELAS            :");
            int kelas = Convert.ToInt32(Console.ReadLine());
        }
    }
}

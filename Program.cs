using System;

namespace ResponsiPemrograman3359
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : ngarvan dwi bachtiar");
            Console.WriteLine("NIM      : 20.11.3359");
            Console.WriteLine("Kelas    : 20 IF 01");

            Console.WriteLine("\n");


            Karyawan karyawan1 = new Karyawan(1911, "ngarvan", 3000000);
            Karyawan karyawan2 = new Karyawan(2742, "dwi", 2000000);
            


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            
            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji nih!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
           


            Console.ReadKey();
        }
    }

}

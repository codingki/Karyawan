using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : Nur Fikri");
            Console.WriteLine("NIM  : 19.11.2790");
            Console.WriteLine("");
            Karyawan karyawan1 = new Karyawan();
            karyawan1.No = 1;
            karyawan1.Nik = 19112790;
            karyawan1.Nama = "Nur Fikri";
            karyawan1.Gaji = 3000000;

            Karyawan karyawan2 = new Karyawan();
            karyawan2.No = 2;
            karyawan2.Nik = 19222951;
            karyawan2.Nama = "Faiz Bagas";
            karyawan2.Gaji = 1000000;

            Karyawan karyawan3 = new Karyawan();
            karyawan3.No = 3;
            karyawan3.Nik = 19332951;
            karyawan3.Nama = "Pradito Pramono";
            karyawan3.Gaji = -100;

            Console.WriteLine("No |   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.KaryawanInfo();
            karyawan2.KaryawanInfo();
            karyawan3.KaryawanInfo();
            Console.WriteLine("");
            Console.WriteLine("Asyiik dapat kenaikan gaji 10%");
            Console.WriteLine("");
            Console.WriteLine("No |   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.NaikGaji();
            karyawan2.NaikGaji();
            karyawan3.NaikGaji();
            Console.ReadKey();
        }
    }

    public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

       

        public void KaryawanInfo()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  | {1}/{2}/{3}        ", No, Nik, Nama, Gaji);
            
        }

        public void NaikGaji()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  | {1}/{2}/{3}        ", No, Nik, Nama, Gaji*0.1+Gaji);

        }


    }
}

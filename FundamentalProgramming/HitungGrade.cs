using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming
{
    class HitungGrade
    {
        public string Nama { get; set; }
        public float Tugas { get; set; }
        public float Kuis { get; set; }
        public float Uts { get; set; }
        public float Uas { get; set; }
        public float Hasil { get; set; }
        public string Grade { get; set; }

        public void LihatNilai()
        {
            InputNilai();
            Console.Write($"Nilai Akhir Mahasiswa  : \n Nama : {Nama}  Nilai : {Hasil}");
            Console.Write("\nGrade Anda : ");
            if (Hasil >= 80)
            {
                Console.WriteLine(Grade = "A");
            }
            else if (Hasil >= 70)
            {
                Console.WriteLine(Grade = "B");
            }
            else if (Hasil >= 60)
            {
                Console.WriteLine(Grade = "C");
            }
            else if (Hasil >= 50)
            {
                Console.WriteLine(Grade = "D");
            }
            else
            {
                Console.WriteLine(Grade = "E");
            }
        }
        public void InputNilai() 
        {
            Console.Write($"NAMA : {Nama}");
            Nama = Console.ReadLine();
            Console.Write($"TUGAS : {Tugas}");
            Tugas = float.Parse(Console.ReadLine());
            Console.Write($"KUIS : {Kuis}");
            Kuis = float.Parse(Console.ReadLine());
            Console.Write($"UTS : {Uts}");
            Uts = float.Parse(Console.ReadLine());
            Console.Write($"UAS : {Uas}");
            Uas = float.Parse(Console.ReadLine());
            Hasil = (Tugas + Kuis + Uts + Uas) / 4;
        }

    }
}

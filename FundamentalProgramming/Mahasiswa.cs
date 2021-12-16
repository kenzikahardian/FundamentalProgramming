using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming
{
    public class Mahasiswa 
    {
        public int Nim { get; set; }
        public string Name { get; set; }
        public string Jurusan { get; set; }
        public float Ipk { get; set; }
        public int LihatMhs { get; set; }
        public int TotalInput { get; set; }

        public Mahasiswa[] mhs = new Mahasiswa[25];
        public List<Mahasiswa> dataMhs = new List<Mahasiswa>();


        public void LihatMahasiswa(List<Mahasiswa> l)
        {
            if (LihatMhs == 0)
            {
                Console.WriteLine("Data Mahasiswa Tidak ada");
            }
            else
            {
                Console.WriteLine("Total Karyawan:" + dataMhs.Count);
                foreach (Mahasiswa e in l)
                {
                    Console.WriteLine("Id :", e.Nim);
                    Console.WriteLine("Nama  is:", e.Name);
                    Console.WriteLine("Jurusan:", e.Jurusan);
                }
            }

            /*Console.WriteLine($"NIM : {Nim}");
            Console.WriteLine($"NAMA : {Name}");
            Console.WriteLine($"JURUSAN : {Jurusan}");
            Console.WriteLine($"IPK : {Ipk}");*/
        }
        public void TambahMahasiswa(List<string> datamhs) 
        {
            Console.WriteLine("Berapa banyak mahasiswa yang mau ditambah?");
            TotalInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < TotalInput; i++)
            {
                mhs[i] = new Mahasiswa();
                dataMhs.Add(mhs[i]);
            }
            Console.WriteLine("Masukkan Nama");
            Name = Console.ReadLine();
        }

        
        }
    }


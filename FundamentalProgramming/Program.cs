using System;
using System.Collections.Generic;

namespace FundamentalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string lanjut;
            int hapus;
            //List<string> dataMhs = new List<string>();
            menu:
                int pilih;
                Console.WriteLine("Menu Program Mahasiswa");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Hitung Nilai Mahasiswa");
                Console.WriteLine("2. Tambah Mahasiswa");
                Console.WriteLine("3. Lihat Data Mahasiswa");
                Console.WriteLine("4. Lihat Data Dosen");
                Console.WriteLine("5. Hapus Data Mahasiswa");
                Console.WriteLine("=========================");
                Console.Write("Masukkan Pilihan (1-4) : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pilih)
                {
                    case 1:
                        HitungGrade coba = new HitungGrade();
                        coba.LihatNilai();
                        break;
                    case 2:
                        /*ist<Mahasiswa> mhs = new List<Mahasiswa> ();
                        Mahasiswa.TambahMahasiswa();*/
                        /*Console.WriteLine("Tambah Data Mahasiswa");
                        Console.WriteLine("==========================");
                        string name;
                        Console.Write("Masukkan Name : ");
                        name = Console.ReadLine();
                        dataMhs.Add(name);
                        Console.WriteLine("=========================");*/
                        break;
                    case 3:
                        Console.WriteLine("Lihat Data Mahasiswa");
                        Console.WriteLine("=========================");
                        Mahasiswa jaki = new Mahasiswa();
                        jaki.Nim = 1006;
                        jaki.Name = "Jaki";
                        jaki.Jurusan = "Ilmu Komputer";
                        jaki.Ipk = 3.5f;

                        //jaki.LihatMahasiswa();

                        /*for (int i = 0; i < dataMhs.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". Nama Mahasiswa : " + dataMhs[i]);
                        }
                        Console.WriteLine("=========================");*/
                        break;
                    case 4:
                        Console.WriteLine("Lihat Data Dosen");
                        Console.WriteLine("=========================");
                        Dosen dana = new Dosen();
                        dana.Nid = 2006;
                        dana.Name = "Dana";
                        dana.Jurusan = "Ilmu Komputer";
                        dana.MataKuliah = "DSS";
                        dana.Gaji = 10000000;
                        dana.LihatDosen();
                        break;
                    case 5:
                        Console.WriteLine("Hapus Data Mahasiswa");
                        Console.WriteLine("=========================");
                        Console.Write("Masukkan Index data yang ingin dihapus : ");
                        try
                        {
                            hapus = Convert.ToInt32(Console.ReadLine());
                            //dataMhs.RemoveAt(hapus);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Data tidak ada");
                        }
                        break;
                    default:
                        Console.WriteLine("PIlihan tidak terdaftar.");
                        Console.WriteLine("=========================");
                        break;
                }
            lanjutMenu:
                Console.WriteLine("Apakah mau dilanjut?");
                Console.WriteLine("Ketik 'y'/'Y' untuk balik ke menu awal atau 'n'/'N' untuk keluar");
                lanjut = (Console.ReadLine());
                Console.Clear();
            if (lanjut.ToLower() == "y")
            {
                goto menu;
            }
            else if (lanjut.ToLower() == "n")
            {
                Environment.Exit(0);
            }
            else {
                Console.WriteLine("Inputan salah");
                goto lanjutMenu;
            }
        }
    }
    ///static float hitungNilai(float tugas, float kuis, float uts, float uas)
    //{
    //  Console.Write("Nilai Tugas : ");
    // tugas = float.Parse(Console.ReadLine());
    // Console.Write("Nilai Kuis  : ");
    // kuis = float.Parse(Console.ReadLine());
    // Console.Write("Nilai UTS   : ");
    // uts = float.Parse(Console.ReadLine());
    // Console.Write("Nilai UAS   : ");
    // uas = float.Parse(Console.ReadLine());
    //Console.WriteLine();
    // float nilaiAkhir = (tugas + kuis + uts + uas)/4 ;

    // return nilaiAkhir;
    // }
}

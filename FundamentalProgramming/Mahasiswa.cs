using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming
{
    class Mahasiswa 
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Jurusan { get; set; }

        public Mahasiswa(Activity a)
        {
            Console.Write("Masukkan NIM: ");
            this.Nim = Console.ReadLine();
            Console.Write("Masukkan Nama: ");
            this.Nama = Console.ReadLine();
            Console.Write("Masukkan Jurusan: ");
            this.Jurusan = Console.ReadLine();
        }
   
        
     }
}


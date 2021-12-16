using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming
{
    class Dosen : Mahasiswa
    {
        public int Nid { get; set; }
        public string MataKuliah { get; set; }
        public int Gaji { get; set; }

        public void LihatDosen()
        {
            //base.LihatMahasiswa();
            Console.WriteLine($"NID : {Nid}");
            Console.WriteLine($"MATA KULIAH : {MataKuliah}");
            Console.WriteLine($"GAJI: {Gaji}");

        }
    }
}

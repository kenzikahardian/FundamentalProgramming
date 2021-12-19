using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalProgramming
{
    class Activity
    {
        public List<Mahasiswa> mahasiswa = new List<Mahasiswa>();
        public void LihatMhs()
        {

            foreach (var element in mahasiswa)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine($"Nama:{element.Nim} ");
                Console.WriteLine($"Username:{ element.Nama }");
                Console.WriteLine($"Password:{element.Jurusan}");
                Console.WriteLine("=========================================");
            }
        }
        public void BuatMhs(Mahasiswa mahasiswa)
        {
            this.mahasiswa.Add(mahasiswa);
            Console.WriteLine("==============================");
            Console.WriteLine("Sukses Menambahkan");
            Console.WriteLine("==============================");
        }
        public void CariMhs(string nama)
        {
            
            var validate = mahasiswa.Exists(mahasiswa => mahasiswa.Nama.Contains(nama));
            if (validate == true && mahasiswa.Count > 0)
            {
                Console.WriteLine("data ditemukan");
                var foundMhs = mahasiswa.FindAll(x => x.Nama.Contains(nama));
                foreach (Mahasiswa e in foundMhs)
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine($"Nama:{e.Nim}");
                    Console.WriteLine($"Username:{e.Nama }");
                    Console.WriteLine($"Password:{e.Jurusan}");
                    Console.WriteLine("=========================================");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("data tidak ditemukan");
                Console.ReadKey();
            }
        }
        public void UbahMhs(string Nim)
        {
            var validate = mahasiswa.Exists(mahasiswa => mahasiswa.Nim == Nim);
            if (validate == true && mahasiswa.Count > 0)
            {
                Console.WriteLine("data ditemukan");
                var foundUser = mahasiswa.FindAll(x => x.Nim == Nim);
                foreach (Mahasiswa e in foundUser)
                {
                    Console.WriteLine("=========================================");
                    Console.Write("Edit NIM : ");
                    e.Nim = Console.ReadLine();
                    Console.Write("Edit Nama : ");
                    e.Nama = Console.ReadLine();
                    Console.Write("Edit Jurusan ");
                    e.Jurusan = Console.ReadLine();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Edit profil sukses!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("data tidak ditemukan");
                Console.ReadKey();
            }
        }
        public void HapusMhs()
        {
            try
            {
                Console.Write("Silahkan Masukkan NIM yang ingin dihapus :");
                var dlt = Console.ReadLine();
                var validasi = mahasiswa.Exists(x => x.Nim == dlt);
                var validate = mahasiswa.FindAll(user => user.Nim == dlt);
              
                if (validasi == true)
                {
                    foreach (Mahasiswa item in validate)
                    {
                        Console.WriteLine("data berhasil dihapus");
                        mahasiswa.Remove(item);
                    }
                }
                else
                {
                    Console.WriteLine("data tidak berhasil dihapus");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_025
{
    class MainClass
    {
        class Penduduk
        {
            public string NIM { get; set; }
            public string NamaMhs { get; set; }
            public string JenisKelamin { get; set; }
            public string Kelas { get; set; }
            public string KotaAsal { get; set; }
        }

        public static void Main(string[] args)
        {
            List<Penduduk> dataPenduduk = new List<Penduduk>();
            int pilihan;
            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("===============MENU===============");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Masukkan Data");
                Console.WriteLine("2. Menampilkan Data");
                Console.WriteLine("3. Mencari Data");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilihan: ");
                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Penduduk pddk = new Penduduk();
                        Console.Write("Masukkan NIM: ");
                        pddk.NIM = Console.ReadLine();
                        Console.Write("Masukkan Nama: ");
                        pddk.NamaMhs = Console.ReadLine();
                        Console.Write("Jenis Kelamin: ");
                        pddk.JenisKelamin = Console.ReadLine();
                        Console.Write("Masukkan Kelas: ");
                        pddk.Kelas = Console.ReadLine();
                        Console.Write("Masukkan Kota Asal: ");
                        pddk.KotaAsal = Console.ReadLine();
                        dataPenduduk.Add(pddk);
                        break;
                    case 2:
                        Console.WriteLine("==================================");
                        Console.WriteLine("==========Data Mahasiswa==========");
                        Console.WriteLine("==================================");
                        foreach (Penduduk p in dataPenduduk)
                        {
                            Console.WriteLine("NIM: " + p.NIM);
                            Console.WriteLine("Nama: " + p.NamaMhs);
                            Console.WriteLine("Jenis Kelamin: " + p.JenisKelamin);
                            Console.WriteLine("Kelas: " + p.Kelas);
                            Console.WriteLine("Kota Asal: " + p.KotaAsal);
                            Console.WriteLine("==================================");
                            Console.WriteLine();

                        }
                        break;
                    case 3:
                        Console.Write("Cari data berdasarkan kota asal: ");
                        string cari = Console.ReadLine();
                        bool ketemu = false;
                        foreach (Penduduk p in dataPenduduk)
                        {
                            if (p.KotaAsal == cari)
                            {
                                Console.WriteLine("NIM: " + p.NIM);
                                Console.WriteLine("Nama: " + p.NamaMhs);
                                Console.WriteLine("Jenis Kelamin: " + p.JenisKelamin);
                                Console.WriteLine("Kelas: " + p.Kelas);
                                Console.WriteLine("Kota Asal: " + p.KotaAsal);
                                Console.WriteLine();
                                ketemu = true;
                            }
                        }
                        if (!ketemu)
                        {
                            Console.WriteLine("Data tidak ditemukan.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi ini. Sampai jumpa lagi.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid, silakan masukkan pilihan yang benar.");
                        break;
                }
            } while (pilihan != 4);
        }
    }
}

/*2. */

/*3. Data ditambahkan diakhir disebut "enqueue" 
 dan data dihapus dari yang paling terakhir disebut "dequeue"*/

/*4. Array memiliki akses data yang lebih cepat namun memerlukan lebih banyak memori, 
 * sedangkan linked list memiliki akses data yang lebih lambat namun memerlukan lebih sedikit memori. 
 * Array lebih cocok digunakan untuk aplikasi yang memerlukan akses data yang cepat dan tidak sering diganti, 
 * sedangkan linked list lebih cocok digunakan untuk aplikasi yang sering menambah atau menghapus data.*/

/**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarasi variabel
            int jumlah, ganti, hapus, cari;
            int ketemu = 0, posisi = 0;
            int[] B=new int[10];
            char pilih;

        atas:
            //input jumlah indeks data
            Console.WriteLine("Masukkan Jumlah Data");
            jumlah = Convert.ToInt32(Console.ReadLine());
            if (jumlah > 10)
            {
                //Kode yang di eksekusi jika indeks >10
                Console.WriteLine("Maaf jumlah maksimal 10 data");
                goto atas;
            }
            else
            {
                //input data
                for (int i = 0; i < jumlah; i++)
                {
                    Console.Write("Masukkan data ke {0} = ", i + 1);
                    B[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("\n\nOK, Luangkan waktu sejenak, Berikut adalah hasilnya");
                //menampilkan data
                for (int j = 0; j < jumlah; j++)
                {
                    Console.WriteLine("B[{0}]={1}", j, B[j]);
                }
            }
            
        menu:
            Console.WriteLine("\n\n[E] Edit Data\t[H] Hapus Data\t[C] Cari Data\t[X] Selesai");
            pilih = Convert.ToChar((Console.ReadLine().ToLower()));
            if (pilih == 'e')
            {
                //Kode untuk mengedit disini
                Console.Write("\n\nMasukkan Data yang akan Diedit = ");
                ganti = Convert.ToInt32(Console.ReadLine());
                for (int g = 0; g < jumlah; g++)
                {
                    if (B[g] == ganti)
                    {
                        Console.Write("Masukkan Data Baru = ");
                        B[g] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\nData Setelah Diedit = ");
                        for (int h = 0; h < jumlah; h++)
                        {
                            Console.WriteLine("B[{0}] = {1}", h, B[h]);
                        }
                    }
                }
                goto menu;
            }
            else if (pilih == 'h')
            {
                //Kode Untuk menghapus disini
                Console.Write("\n\nMasukkan index data yang akan dihapus = ");
                hapus = Convert.ToInt32(Console.ReadLine());
                for (int p = hapus; p < jumlah; p++)
                {
                    B[p] = B[p + 1];
                    jumlah -= 1;
                }
                Console.Write("Data Baru = \n");
                for (int p = 0; p < jumlah; p++)
                {
                    Console.WriteLine("B[{0}] = {1}", p, B[p]);
                }
                goto menu;
            }
            else if (pilih == 'c')
            {
                //kode untuk mencari disini
                Console.Write("\n\nData Yang akan dicari = ");
                cari = Convert.ToInt32(Console.ReadLine());
                for (int n = 0; n < jumlah; n++)
                {
                    if (cari == B[n])
                    {
                        ketemu = 1;
                        posisi = n;
                        Console.WriteLine("Data {0} Ditemukan Di Posisi {1}", cari, n);
                    }
                }
                if (ketemu == 0)
                {
                    Console.WriteLine("Maaf Data yang kamu cari tidak ada.");
                }
                goto menu;
            }
            else Console.WriteLine("Terimakasih\n\n");
            Console.WriteLine();
        }

    }
}

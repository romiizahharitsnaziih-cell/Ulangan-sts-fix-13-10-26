using System;

namespace AplikasiUjianSts
{
    class Home
    {
        static void Main(string[] args)
        {
            bool ulang = true;

            while (ulang)
            {
                Console.Clear();

                Menu menu = new Menu();
                menu.menuUtama();

                Console.Write("Pilih menu: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 1)
                {
                    AplikasiJualan aplikasiJualan = new AplikasiJualan();
                    aplikasiJualan.menuJualan();
                    Console.ReadLine();
                }
                else if (pilihan == 2)
                {
                    AplikasiKaryawan aplikasiKaryawan = new AplikasiKaryawan();
                    aplikasiKaryawan.menuKaryawan();
                    Console.ReadLine();
                }
                else if (pilihan == 3)
                {
                    AplikasiSimpanan aplikasiSimpanan = new AplikasiSimpanan();
                    aplikasiSimpanan.menuSimpanan();
                    Console.ReadLine();
                }
                else if (pilihan == 4)
                {
                    ulang = false;
                    Console.WriteLine("2x Enter untuk keluar");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Pilihan ngga ada!");
                    Console.ReadLine();
                }
            }
        }
    }

    class Menu
    {
        public void menuUtama()
        {
            Console.Clear();
            Console.WriteLine("=== Menu Utama ===");
            Console.WriteLine("1. Aplikasi Jualan");
            Console.WriteLine("2. Aplikasi Karyawan");
            Console.WriteLine("3. Aplikasi Simpanan");
            Console.WriteLine("4. Exit");
        }
    }

    class AplikasiJualan
    {
        public void menuJualan()
        {
            Console.Clear();
            Console.WriteLine("=== Aplikasi Jualan ===");
            Console.WriteLine(" [!] FLASHSALE KETENTUAN BELANJA DI APP INI ");
            Console.WriteLine("1. Beli <5 barang = 0% diskon");
            Console.WriteLine("2. Beli 5-10 barang = 5% diskon");
            Console.WriteLine("3. Beli 11-12 barang = 10% diskon");
            Console.WriteLine("4. Beli >12 barang = 15% diskon");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" --- TOKO ICHA --- ");
            Console.WriteLine("1 Buku = Rp 5.000");

            Console.Write("Mau Beli Berapa Buku? : ");
            int pilihanBarang = Convert.ToInt32(Console.ReadLine());

            int hargaBuku = 5000;
            int totalBuku = pilihanBarang * hargaBuku;
            int totalBelanja = totalBuku;

            int diskon = 0;

            if (pilihanBarang < 5)
            {
                diskon = 0;
            }
            else if (pilihanBarang >= 5 && pilihanBarang <= 10)
            {
                diskon = 5;
            }
            else if (pilihanBarang >= 11 && pilihanBarang <= 12)
            {
                diskon = 10;
            }
            else
            {
                diskon = 15;
            }

            int nominalDiskon = (totalBelanja * diskon) / 100;
            int totalBayar = totalBelanja - nominalDiskon;

            Console.WriteLine("");
            Console.WriteLine("===== STRUK BELANJA =====");
            Console.WriteLine("Jumlah Barang   : " + pilihanBarang);
            Console.WriteLine("Total belanja   : Rp " + totalBelanja);
            Console.WriteLine("Diskon yang didapat : " + diskon + "%");
            Console.WriteLine("Potongan harga  : Rp " + nominalDiskon);
            Console.WriteLine("Total Bayar     : Rp " + totalBayar);
            Console.WriteLine("");
            Console.WriteLine("..Tekan Enter untuk kembali ke Menu Utama..");
        }
    }

    class AplikasiKaryawan
    {
        public void menuKaryawan()
        {
            Console.Clear();
            Console.WriteLine("=== Aplikasi Karyawan ===");
            Console.WriteLine("BACA KETENTUAN DI BAWAH INI");
            Console.WriteLine("1. WAJIB BEKERJA 8 JAM SEHARI");
            Console.WriteLine("2. Kerja <8jam potong gaji 50.000");
            Console.WriteLine("3. Kerja >10jam bonus gaji 100.000");
            Console.WriteLine("");

            Console.Write("Masuk jam berapa? (1-24) : ");
            int jamMasuk = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pulang jam berapa? (1-24): ");
            int jamPulang = Convert.ToInt32(Console.ReadLine());

            int totalJamKerja = jamPulang - jamMasuk;
            if (totalJamKerja < 0)
            {
                totalJamKerja += 24;
            }

            int potongan = 0;
            int bonus = 0;

            if (totalJamKerja <= 8)
            {
                potongan = 50000;
            }
            else if (totalJamKerja >= 10)
            {
                bonus = 100000;
            }

            Console.WriteLine("");
            Console.WriteLine("===== RINCIAN JAM KERJA =====");
            Console.WriteLine("Total Jam Kerja : " + totalJamKerja + " jam");
            Console.WriteLine("Potongan Gaji   : Rp " + potongan);
            Console.WriteLine("Bonus Gaji      : Rp " + bonus);
            Console.WriteLine("..Tekan Enter untuk kembali ke Menu Utama..");
        }
    }

    class AplikasiSimpanan
    {
        public void menuSimpanan()
        {
            Console.Clear();
            Console.WriteLine("=== Aplikasi Simpanan ===");
            Console.WriteLine(">BACA KETENTUAN DI BAWAH INI");
            Console.WriteLine("1. Jika kamu menyimpan uang disini sebanyak +10x maka kamu dapat bonus 500");
            Console.WriteLine("2. Jika kamu menyimpan uang disini sebanyak +30x maka kamu dapat bonus 1.000");
            Console.WriteLine("3. Jika kamu menyimpan uang disini sebanyak +50x maka kamu dapat bonus 2.000");
            Console.WriteLine("");

            Console.Write("Sudah berapa kali simpan di app ini? : ");
            int jumlahSimpan = Convert.ToInt32(Console.ReadLine());
            int bonus = 0;

            if (jumlahSimpan >= 50)
            {
                bonus = 2000;
            }
            else if (jumlahSimpan >= 30)
            {
                bonus = 1000;
            }
            else if (jumlahSimpan >= 10)
            {
                bonus = 500;
            }
            else
            {
                bonus = 0;
            }

            Console.WriteLine("");
            Console.WriteLine("===== RINCIAN SIMPANAN =====");
            Console.WriteLine("Total Transaksi Simpan : " + jumlahSimpan + "x");
            Console.WriteLine("Bonus yang diperoleh   : Rp " + bonus);
            Console.WriteLine("..Tekan Enter untuk kembali ke Menu Utama..");
        }
    }
}
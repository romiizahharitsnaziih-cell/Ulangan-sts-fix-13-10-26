using System;
namespace Tugas
{
    class Home
    {
        static void Main(string[] args)
        {
            bool ulang = true;
            while (ulang)
            {
                Menu me = new Menu();
                me.menuUtama();

                int pilihan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(pilihan);

                if (pilihan == 2)
                {
                    Console.Clear();
                    Console.WriteLine("MENU ITS");
                    Console.WriteLine("1. Cek Jalur TKA");
                    Console.WriteLine("2. Cek Jalur UTBK");
                    Console.Write("-> PILIH SYARAT: ");
                    int pilihanJalur = Convert.ToInt32(Console.ReadLine());


                    if (pilihanJalur == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("JALUR PRESTASI ITS");

                        Console.Write("Input Nilai Math: ");
                        int nilaiA = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input Nilai English: ");
                        int nilaiB = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input Nilai Pilihan: ");
                        int nilaiC = Convert.ToInt32(Console.ReadLine());

                        if (nilaiA > 100 || nilaiB > 100 || nilaiC > 100 || nilaiA < 0 || nilaiB < 0 || nilaiC < 0)
                        {
                            Console.WriteLine("Nilai yang diinputkan salah! maksimal 100");
                        }
                        else
                        {
                            int totalNilai = ITS.jalurPrestasi(nilaiA, nilaiB, nilaiC);
                            Console.WriteLine("Total Nilai Anda: " + totalNilai);
                            if (totalNilai >= 280)
                            {
                                Console.WriteLine("LULUS");
                            }
                            else
                            {
                                Console.WriteLine("TIDAK LULUS");
                            }
                        }

                        Console.WriteLine("[!] Kembali");
                        Console.ReadLine();
                    }
                    else if (pilihanJalur == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("JALUR UTBK");

                        Console.Write("Input nilai UTBK(minim 600): ");
                        int nilaiA = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input Nilai TKA(minim 280): ");
                        int nilaiB = Convert.ToInt32(Console.ReadLine());
                        if (nilaiA < 600 || nilaiB < 280)
                        {
                            Console.WriteLine("Nilai yang diinputkan salah!");
                        }
                        else
                        {
                            double totalUTBK = ITS.jalurUTBK(nilaiA, nilaiB);
                            Console.WriteLine("Total Nilai UTBK: " + totalUTBK);
                            Console.WriteLine("STATUS:LULUS");
                        }

                        Console.WriteLine("Enter");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Tidak Ada Pilihan Jalur");
                    }

                }
            }
        }
    }
    class Menu
    {
        public void menuUtama()
        {
            Console.Clear();

            Console.WriteLine("PILIH MENU UTAMA");
            Console.WriteLine("1. Menu Kasir Toko");
            Console.WriteLine("2. Menu Perhitungan Masuk ITS");
            Console.WriteLine("0. Kembali Ke Awal");
        }
        public void menuKasir()
        {
            Console.Clear();

            Console.WriteLine("Selamat Datang Pada Menu Kasir Toko");
        }
        public void menuPerhitunganMasukITS()
        {
            Console.Clear();

            Console.WriteLine("Cek peluang Anda masuk syarat ITS");

            Console.WriteLine("Pilih jalur periksa");
            Console.WriteLine("1. Jalur Prestasi");
            Console.WriteLine("2. Jalur UTBK");
        }
    }
    class Kasir
    {
        public void belanja()
        {

        }
    }
    class ITS
    {
        public static int jalurPrestasi(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double jalurUTBK(int a, int b)
        {
            return a + (b * 0.30);
        }
    }
}
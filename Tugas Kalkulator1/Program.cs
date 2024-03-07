using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ulangi = true;

            while (ulangi)
            {
                char opsi;
                double angka1, angka2;

                Console.WriteLine("Pilihan Menu Kalkulator:");
                Console.WriteLine("1. Penjumlahan (+)");
                Console.WriteLine("2. Pengurangan (-)");
                Console.WriteLine("3. Perkalian (X)");
                Console.WriteLine("4. Pembagian (:)");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih operasi yang diinginkan: ");
                opsi = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Untuk memberikan baris baru setelah pengguna memilih opsi.

                if (opsi == '5')
                {
                    ulangi = false;
                    continue;
                }

                Console.Write("Masukkan dua angka: ");
                angka1 = Convert.ToDouble(Console.ReadLine());
                angka2 = Convert.ToDouble(Console.ReadLine());

                switch (opsi)
                {
                    case '1':
                        Console.WriteLine($"Hasil penjumlahan: {angka1 + angka2}");
                        break;
                    case '2':
                        Console.WriteLine($"Hasil pengurangan: {angka1 - angka2}");
                        break;
                    case '3':
                        Console.WriteLine($"Hasil perkalian: {angka1 * angka2}");
                        break;
                    case '4':
                        if (angka2 != 0)
                            Console.WriteLine($"Hasil pembagian: {angka1 / angka2}");
                        else
                            Console.WriteLine("Pembagian oleh nol tidak dapat dilakukan.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }

            Console.WriteLine("Terima kasih telah menggunakan kalkulator.");
        }
    }
    }


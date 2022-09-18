using System;

namespace GradeKelulusan
{
    class Program
    {
        static void Main(string[] args)
        {
            string nim, nama, in_tugas, in_kehadiran, in_uts, in_uas;
            double tugas, kehadiran, uts, uas, akhir;
            Console.WriteLine("--------------- Masukan Data Mahasiswa ---------------");
            Console.Write(" Masukan NIM = "); nim = Console.ReadLine();
            Console.Write(" Masukan Nama = "); nama = Console.ReadLine();
            Console.Write(" Masukan Nilai Tugas = "); in_tugas = Console.ReadLine();
            Console.Write(" Masukan Nilai Kehadiran = "); in_kehadiran = Console.ReadLine();
            Console.Write(" Masukan Nilai UTS = "); in_uts = Console.ReadLine();
            Console.Write(" Masukan Nilai UAS = "); in_uas = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------");

            tugas = Convert.ToDouble(in_tugas);
            kehadiran = Convert.ToDouble(in_kehadiran);
            uts = Convert.ToDouble(in_uts);
            uas = Convert.ToDouble(in_uas);

            akhir = (tugas * 40 / 100) + (kehadiran * 10 / 100) + (uts * 20 / 100) + (uas * 30 / 100);
            Console.WriteLine("-------------- Hasil Penilaian Mahasiswa --------------");
            Console.WriteLine(" NIM = " + nim);
            Console.WriteLine(" Nama = " + nama);
            Console.WriteLine(" Nilai tugas = " + in_tugas);
            Console.WriteLine(" Nilai kehadiran = " + in_kehadiran);
            Console.WriteLine(" Nilai UTS = " + in_uts);
            Console.WriteLine(" Nilai UAS = " + in_uas);
            Console.WriteLine(" Nilai Akhir = " + akhir);
            if (akhir >= 86 & akhir <= 100)
            {
                Console.WriteLine(" Grade = A");
                Console.WriteLine(" Nilai Konversi = 4,00");
            }
            else if (akhir >= 81 & akhir < 86)
            {
                Console.WriteLine(" Grade = B");
                Console.WriteLine(" Nilai Konversi = 3,67");
            }
            else if (akhir >= 76 & akhir < 81)
            {
                Console.WriteLine(" Grade = B+");
                Console.WriteLine(" Nilai Konversi = 3,33");
            }
            else if (akhir >= 61 & akhir < 66)
            {
                Console.WriteLine(" Grade = C+");
                Console.WriteLine(" Nilai Konversi = 2,33");
            }
            else if (akhir >= 56 & akhir < 61)
            {
                Console.WriteLine(" Grade = C");
                Console.WriteLine(" Nilai Konversi = 2,00");
            }
            else if (akhir >= 41 & akhir < 56)
            {
                Console.WriteLine(" Grade = D");
                Console.WriteLine(" Nilai Konversi = 1,00");
            }
            else
            {
                Console.WriteLine(" Grade = E");
                Console.WriteLine(" Nilai Konversi 0.00");
            }

            Console.WriteLine("-------------------------------------------------------");

        }
    }
}

using System;

namespace Rama_Dwiprasetia
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Jawaban Nomor 1 ");
            Console.WriteLine("Masukkan Nama Anda ");
            name = Console.ReadLine();

            Console.WriteLine("Hello. My name is " + name);

            int a;
            Console.WriteLine("Jawaban Nomor 5 ");
            Console.WriteLine("Masukkan angka yang ingin di cek ganjil atau genap");
            a = Convert.ToInt32(Console.ReadLine());

            int b = a % 2;
            bool condition = true;
            if (b == 0)
            {
                condition = true;
                Console.WriteLine(condition);
            }
            else
            {
                condition = false;
                Console.WriteLine(condition);
            }


            Console.WriteLine("Jawaban Nomor 6 ");
            int grade;
            Console.WriteLine("masukkan inputa nilai 0-100 ?");
            grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }

            Console.WriteLine("Jawaban Nomor 12 ");
            String besar;
            Console.WriteLine("Masukkan tulisan yang ingin dibesarkan");
            besar = Console.ReadLine();

            string upper = besar.ToUpper();
            Console.WriteLine(upper);
            Console.WriteLine("Jawaban Nomor 13 ");

            int hitungkata;
            Console.WriteLine("kata apa yang ingin dimasukkan");
            string kata = Console.ReadLine();
            hitungkata = 1;
            int coba = kata.Length;
            Console.WriteLine(coba);
            for (int i = 0; i <= kata.Length - 1; i++)
            {
                if (kata[i] == ' ')
                {
                    hitungkata++;
                }
            }
            Console.WriteLine(hitungkata);

            // Console.WriteLine("Jawaban Nomor 16 ");
            // string[] fruits;
            // fruits = new string[7] { "Jeruk", "Apel", "Anggur", "Pepaya", "Pisang", "Kiwi", "Markisa" };

            // Console.WriteLine("masukkan kata yang ingin dicarai");
            // string cari = Console.ReadLine();


            // for (int i = 0; i <= 6; i++)
            // {

            //     if (fruits[i])
            //     {

            //     }
            // }

            // Console.WriteLine("Jawaban Nomor 18 ");
            // int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
            // int kiyay = 0;
            // int cilik = 0;
            // for (int i = 0; i <= numbers.Length; i++)
            // {

            //     if (numbers[i] > numbers[0])
            //     {
            //         kiyay = numbers[i];
            //     }
            //     else
            //     {
            //         cilik = numbers[i];
            //     }
            //     Console.WriteLine("max= " + kiyay);
            //     Console.WriteLine("min = " + cilik);
            // }
        }
    }
}

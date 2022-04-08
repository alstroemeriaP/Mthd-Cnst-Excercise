using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrogramanlatihan
{
    class Program
    {
        static void Main(string[] args)
        
        {
            static void CetakHasil(string hasil)
            {
                Console.WriteLine(hasil);
            }
            int hasil = 0;

            Calculator calculator = new Calculator();

            hasil = Calculator.penjumlah(10, 2);
            CetakHasil("Hasil Penjumlah : " + hasil);

            hasil = Calculator.penjumlah(10, 2, 3);
            CetakHasil("Hasil Penjumlah overload : " + hasil);

            hasil = Calculator.pengurangan(10, 2);
            CetakHasil("Hasil Pengurangan : " + hasil);

            hasil = Calculator.pengurangan(10, 2);
            CetakHasil("Hasil Pengurangan : " + hasil);

            Console.ReadKey();
        }
    }

}
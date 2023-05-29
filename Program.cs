using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtrasonguyento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songuyento;
            Console.WriteLine("moi ban nhap so ");
            songuyento= int.Parse(Console.ReadLine()); 
            if (songuyento < 2)
            {
                Console.WriteLine("day khong phai so nguyen to");
            }
            else 
            {
                int i = 2;
                bool kiemtra = false;
                while (i <= Math.Sqrt(songuyento))
                {
                    if (songuyento % i == 0)
                    {
                        kiemtra = false;
                        break;
                    }
                    i++;
                }
                if (kiemtra == true)
                {
                    Console.WriteLine("day la so nguyen to");
                }
                else
                {
                    Console.WriteLine("day khong phai so nguyen to");
                }
            }
            Console.ReadKey();
        }
    }
}

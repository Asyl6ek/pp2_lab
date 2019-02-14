using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Program
    {

        static bool F(int a)// объявляет функцию F
        {

            if (a < 2)// условие если входное число меньше чем 2
            {
                return false;// функция F принемает значение false
            }

            for (int i = 2; i <= Math.Sqrt(a); i++)// цикл от 2 до квадратного корня а
            {
                if (a % i == 0)// условие: если а  делиться на i без остатка
                {
                    return false;// функция F принемает значение false
                }

            }
            return true;// функция F принемает значение true
        }
        static void Main(string[] args)
        {
            int n; // объявляет число n
            n = int.Parse(Console.ReadLine()); // переводит n в int и вводит его
            string[] s = Console.ReadLine().Split();// вводит массив в виде строки и пропукает пробелы(Split()) 
            int[] a = new int[s.Length];// объявляет массив чисел
            int cnt = 0;// объявляет число cnt(счетчик)

            for (int i = 0; i < n; i++)// цикл от 0 до n
            {
                if (F(int.Parse(s[i]))== true)// условие: если функция F дает true при входном значение s[i] и переводит его в interger
                {
                    a[cnt] = int.Parse(s[i]);// присваивает занчение s[i](переводит его в int) к a[cnt]
                    cnt++;// + к счетчику
                }
            }
            Console.WriteLine(cnt);// выводит количество чисел в массиве с простыми числами
            for (int i = 0; i < cnt; i++)// цикл от 0 до сnt
            {
                Console.Write(a[i] + " ");// выводит массив простых чисел оставляя пробел
            }
        }
    }
}

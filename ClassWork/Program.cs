using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                a[i] = rnd.Next(1, 9);
                Console.Write("{0} ", array[i]);
                if (array[i] % 2 == 0)
                {
                    maxValue = array.Max();
                }
            }
            Console.WriteLine("Index of max value: {0} ", array.ToList().IndexOf(array.Max()));
            Console.WriteLine("Max even value of array: {0} ", maxValue);

            int indexOfDeleteNum = 3;
            array.ToList().RemoveAt(indexOfDeleteNum); /*Удаление по индексу*/

            int indexOfDeleteValue = 4;
            array.ToList().Remove(indexOfDeleteValue); /*Удаление по значению*/

            int insertIndex = 3;
            int insertValue = 10;
            array.ToList().Insert(insertIndex, insertValue); /*Вставка элемента по индексу*/



            /*************************************************************************************/

            string str = "Lololala";
            for (int i = 0; i < str.Length; i++)     /*Удаляет все буквы A*/
                str.ToList().Remove('a');

            string text = "dadratgwetaet dgoejgasfdfhjgtrg one srg ergdfghdeherh";
            text.ToList().Exists("one"); /*Определяет, есть ли слово one */

            /*************************************************************************************/

            int n = Console.ReadLine(); /*Разворот числа 345 - 543*/
            n.ToString().Reverse();

            string s = "qweqeqweqweqweqe52352q3rwetjy3456wtert436j3tery";
            int countP = s.Count('p');
            Console.Write("{0}", s);
            /*************************************************************************************/

        }
    }
}



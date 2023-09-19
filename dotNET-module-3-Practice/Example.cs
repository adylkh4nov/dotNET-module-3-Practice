using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_3_Practice
{
    public class Example
    {
        public void example1()
        {
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Console.WriteLine("Заполните массив А: ");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int rows = B.GetLength(0);
            int cols = B.GetLength(1);
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    B[i, j] = rnd.Next(1, 100);
                }
            }
            int max = A[0];
            int min = A[0];
            int sum = 0;
            long proiz = 1;
            int sum4et = 0;
            Console.WriteLine("Массив А: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                sum += A[i];
                proiz *= A[i];
                if (A[i] % 2 == 0)
                {
                    sum4et += A[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("MAX A: " + max);
            Console.WriteLine("MIN A: " + min);
            Console.WriteLine("SUM A: " + sum);
            Console.WriteLine("Сумма Произведение A: " + proiz);
            Console.WriteLine("Сумма четных A: " + sum4et);
            max = A[0];
            min = B[0, 0];
            sum = 0;
            proiz = 1;
            int sumne4et = 0;
            Console.WriteLine("Массив В: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(B[i, j] + " ");
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }
                    sum += B[i, j];
                    proiz *= B[i, j];
                    if (j % 2 != 0)
                    {
                        sumne4et += B[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("MAX B: " + max);
            Console.WriteLine("MIN B: " + min);
            Console.WriteLine("SUM B: " + sum);
            Console.WriteLine("Сумма Произведение B: " + proiz);
            Console.WriteLine("Сумма не четных столбцов B: " + sumne4et);
        }

        public int[] example2(int[] arr1, int[] arr2)
        {
            int m = arr1.Length;
            int n = arr2.Length;
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        count++;
                    }
                }
            }
            int[] arr = new int[count];
            count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr[count++] = arr1[i];
                    }
                }
            }
            return arr;
        }

        public bool example3(string str)
        {
            bool flag = true;
            char[] subString1 = new char[str.Length];
            char[] subString2 = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                subString1[i] = str[i];
            }
            int j = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                subString2[j++] = str[i];
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!(subString1[i] == subString2[i]))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public int example4(string str)
        {
            string[] arr = str.Split(' ');

            return arr.Length;
        }

        public void example5()
        {
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }

            int min = arr[0, 0];
            int max = arr[0, 0];
            int[] minIndex = { 0, 0 };
            int[] maxIndex = { 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            int sum = 0;
            int startRow = Math.Min(minIndex[0], maxIndex[0]);
            int endRow = Math.Max(minIndex[0], maxIndex[0]);
            int startCol = Math.Min(minIndex[1], maxIndex[1]);
            int endCol = Math.Max(minIndex[1], maxIndex[1]);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);
        }

        static void example6()
        {
            char a = '0';
            Console.WriteLine("Введите букву и введите 'q', чтобы остановить:");
            while (a != 'q')
            {
                a = char.Parse(Console.ReadLine());
                Console.WriteLine(a + " -> " + char.ToUpper(a));
            }
        }

        public void example7()
        {
            string str = "В лесу родилась елочка в лесу она росла зимой и летом стройная зеленая была";
            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }

        public void example8()
        {
            string num = "slsnlsj 131321 23123";
            string[] temp = num.Split(' ');
            int chislo = 0;
            int sum = 0;

            foreach (string i in temp)
            {
                if (int.TryParse(i, out chislo))
                {
                    sum += chislo;
                }
            }
            Console.WriteLine("Summa:" + sum);
            Console.ReadLine();
        }

        public void example9()
        {
            string a = "hsadas 1 4 asd 6 a 3";
            string[] temp = a.Split(' ');


            int count = 0;
            int chislo = 0;
            foreach (string i in temp)
            {
                if (int.TryParse(i, out chislo))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
        public int example10(string input)
        {
            int count = 0;

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length >= 2 && word[0] == word[word.Length - 1])
                {
                    count++;
                }
            }

            return count;
        }

    }
}

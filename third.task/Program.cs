using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;

namespace third.task
{
    class Program
    {
        public enum DayOfWeek
        {
            Понедельник = 0,
            Вторник = 1,
            Среда = 2,
            Четверг = 3,
            Пятниццо = 4,
            Суббота = 5,
            Воскресенье = 6
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 task");
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите d: ");
            int d = int.Parse(Console.ReadLine());
            if (a > (d + 1) || b > (d + 1))
            {
                Console.WriteLine("Пройдет");
            }
            else
            {
                Console.WriteLine("Не пройдет");
            }

            Console.WriteLine("2 task");
            Console.WriteLine("Введите число от 1 до 9");
            var vvod = Console.ReadLine();
            int choice;
            if (int.TryParse(vvod, out choice) == false)
            {
                Console.Clear();
                Console.WriteLine("Данные введены неверно!");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Вы нажали 1");
                            Console.WriteLine("1*1=1\n1*2=2\n1*3=3\n1*4=4\n1*5=5\n1*6=6\n1*7=7\n1*8=8\n1*9=9");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Вы нажали 2");
                            Console.WriteLine("2*1=2\n2*2=4\n2*3=6\n2*4=8\n2*5=10\n2*6=12\n2*7=14\n2*8=16\n2*9=18");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Вы нажали 3");
                            Console.WriteLine("3*1=3\n3*2=6\n3*3=9\n3*4=12\n3*5=15\n3*6=18\n3*7=21\n3*8=24\n3*9=27");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Вы нажали 4");
                            Console.WriteLine("4*1=4\n4*2=8\n4*3=12\n4*4=16\n4*5=20\n4*6=24\n4*7=28\n4*8=32\n4*9=36");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Вы нажали 5");
                            Console.WriteLine("5*1=5\n5*2=10\n5*3=15\n5*4=20\n5*5=25\n5*6=30\n5*7=35\n5*8=40\n5*9=45");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Вы нажали 6");
                            Console.WriteLine("6*1=6\n6*2=12\n6*3=18\n6*4=24\n6*5=30\n6*6=36\n6*7=42\n6*8=48\n6*9=54");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Вы нажали 7");
                            Console.WriteLine("7*1=6\n7*2=14\n7*3=21\n7*4=28\n7*5=35\n7*6=42\n7*7=49\n7*8=56\n7*9=63");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Вы нажали 8");
                            Console.WriteLine("8*1=8\n8*2=16\n8*3=24\n8*4=32\n8*5=40\n8*6=48\n8*7=56\n8*8=64\n8*9=72");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Вы нажали 9");
                            Console.WriteLine("9*1=9\n9*2=18\n9*3=27\n9*4=36\n9*5=45\n9*6=54\n9*7=63\n9*8=72\n9*9=81");
                            break;
                        }

                }
            }


            Console.WriteLine("3 task");
            Console.Write("Введите любое число: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb % 3 == 0)
            {
                Console.WriteLine("Бэнг!");
            }
            else
            {
                if (numb % 5 == 0)
                {
                    Console.WriteLine("Бум!");
                }
                else
                {
                    if (numb % 3 == 0 & numb % 5 == 0)
                    {
                        Console.WriteLine("БэнгБум");
                    }
                    else
                    {
                        Console.WriteLine("Мимо!")
                    }
                }
            }



            Console.WriteLine("4 task");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            foreach (char i in str)
            {
                if (char.IsUpper(i))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }


            Console.WriteLine("5 task");
            Console.Write("Введите число: ");
            int i = int.Parse(Console.ReadLine());
            while (i > 0)
            {
                Console.WriteLine($"{i} овец..");
                i--;
            }






            Console.WriteLine("6 task");
            try
            {
                Console.Write("Введите количество чисел последовательности: ");
                int elementscount = int.Parse(Console.ReadLine());
                int[] posled = new int[elementscount];
                int i = 0;

                while (i < posled.Length)
                {
                    Console.Write($"Введите элемента массива под индексом {i}: ");
                    posled[i] = int.Parse(Console.ReadLine());
                    i++;
                }
                int sum = 0;
                int cnt = 0;
                int q = 0;
                while (posled[q] > 0)
                {

                    sum += posled[q];
                    cnt++;
                    q++;
                    double srar = sum / cnt;

                    Console.WriteLine($"Среднее арифметическое = {srar}");
                    Console.ReadKey();

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Попробуйте еще раз!");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!\n");
            }


            Console.WriteLine("7 task");
            Console.Write("Введите номер карты от 6 до 14: ");
            int choice = int.Parse(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 6:
                        {
                            Console.WriteLine("Шестерка");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Семерка");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Восьмерка");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Девятка");
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Десятка");
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("Валет");
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("Дама");
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine("Король");
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("Туз");
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Попробуйте еще раз!");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!\n");
            }





            Console.WriteLine("8 task");
            Console.Write("Введите количество строк: ");
            int kol = int.Parse(Console.ReadLine());
            string[] str = new string[kol];
            int i = 0;
            int cnt = 0;
            string doll = "Hello Kitty";
            string doll2 = "Barbie doll";

            while (i < str.Length)
            {
                Console.Write($"Введите строки массива под индексом {i}: ");
                str[i] = Console.ReadLine();
                i++;
            }

            foreach (string q in str)
            {
                if (q == "Hello Kitty" || q == "Barbie doll")
                {
                    cnt++;
                    Console.WriteLine(cnt);
                }


            }


            Console.WriteLine("9 task");
            Console.Write("Введите номер дня недели: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine((DayOfWeek)((d - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));




            Console.WriteLine("10 task");
            Console.Write("Введите количество чисел последовательности: ");
            int elementscount = int.Parse(Console.ReadLine());
            int[] sequence = new int[elementscount];
            int i = 0;

            while (i < sequence.Length)
            {
                Console.Write($"Введите элемента массива под индексом {i}: ");
                sequence[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int temp;
            for (int q = 0; q < sequence.Length - 1; q++)
            {
                for (int j = q + 1; j < sequence.Length; j++)
                {

                    if (sequence[q] > sequence[j])
                    {
                        temp = sequence[q];
                        sequence[q] = sequence[j];
                        sequence[j] = temp;
                    }
                }
            }

            вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int q = 0; q < sequence.Length; q++)
            {
                Console.WriteLine(sequence[q]);
            }



            Console.WriteLine("11 task");
            int[] array = new int[10];
            Random rand = new Random();
            int k = -1;
            Console.WriteLine("исходный список: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 11);

                Console.WriteLine(array[i]);
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    k = i;
                    break;
                }
            }
            Console.WriteLine("Порядковый номер, который всё портит:" + k);
        }
    }
}



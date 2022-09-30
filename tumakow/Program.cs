using System;
using System.Reflection.Emit;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;

namespace tumakow
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = new Dictionary<int, string>()
            {
                {31, "january" },
                {59, "february"},
                {90, "march"},
                {120,"aprill" },
                {151,"may" },
                {181,"june" },
                {212, "jule" },
                {243, "august"},
                {273, "september"},
                {304, "october"},
                {334, "november"},
                {365, "december"}
            };
            Console.Write("Задание 1. День|месяц\nВведите год: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 & year % 100 != 0)
            {
                Console.WriteLine("Год високосный поэтому введите" +
                    "число n(1 <= n <= 366): ");
                int date = int.Parse(Console.ReadLine());
                if (date < 1 || date > 366)
                {
                    Console.WriteLine("Введено неправильно!");
                }
                else
                {
                    if (date <= 31)
                    {
                        Console.WriteLine($"{date}{month[31]}");
                    }
                    else if (date <= 60)
                    {
                        Console.WriteLine($"{date - 31}{month[59]}");
                    }
                    else if (date <= 91)
                    {
                        Console.WriteLine($"{date - 60}{month[90]}");
                    }
                    else if (date <= 121)
                    {
                        Console.WriteLine($"{date - 91}{month[120]}");
                    }
                    else if (date <= 152)
                    {
                        Console.WriteLine($"{date - 121}{month[151]}");
                    }
                    else if (date <= 182)
                    {
                        Console.WriteLine($"{date - 152}{month[181]}");
                    }
                    else if (date <= 213)
                    {
                        Console.WriteLine($"{date - 182}{month[212]}");
                    }
                    else if (date <= 244)
                    {
                        Console.WriteLine($"{date - 213}{month[243]}");
                    }
                    else if (date <= 274)
                    {
                        Console.WriteLine($"{date - 244}{month[273]}");
                    }
                    else if (date <= 305)
                    {
                        Console.WriteLine($"{date - 274}{month[304]}");
                    }
                    else if (date <= 335)
                    {
                        Console.WriteLine($"{date - 305}{month[334]}");
                    }
                    else
                    {
                        Console.WriteLine($"{date - 335}{month[365]}");

                    }

                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Год весокосный поэтому введите" +
                    "число n(1 <= n <= 366): ");
                int date = int.Parse(Console.ReadLine());
                if (date < 1 || date > 366)
                {
                    Console.WriteLine("Введено неправильно");
                }
                else
                {
                    if (date <= 31)
                    {
                        Console.WriteLine($"{date}{month[31]}");
                    }
                    else if (date <= 59)
                    {
                        Console.WriteLine($"{date - 31}{month[59]}");
                    }
                    else if (date <= 90)
                    {
                        Console.WriteLine($"{date - 59}{month[90]}");
                    }
                    else if (date <= 120)
                    {
                        Console.WriteLine($"{date - 90}{month[120]}");
                    }
                    else if (date <= 151)
                    {
                        Console.WriteLine($"{date - 151}{month[181]}");
                    }
                    else if (date <= 212)
                    {
                        Console.WriteLine($"{date - 181}{month[212]}");
                    }
                    else if (date <= 243)
                    {
                        Console.WriteLine($"{date - 212}{month[243]}");
                    }
                    else if (date <= 273)
                    {
                        Console.WriteLine($"{date - 243}{month[273]}");
                    }
                    else if (date <= 304)
                    {
                        Console.WriteLine($"{date - 273}{month[304]}");
                    }
                    else if (date <= 334)
                    {
                        Console.WriteLine($"{date - 304}{month[334]}");
                    }
                    else
                    {
                        Console.WriteLine($"{date - 334}{month[365]}");

                    }
                    Console.ReadLine();



                }

            }


            


            



        }
           




        
            

    }
}


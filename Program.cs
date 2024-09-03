using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWork2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "none";
            string password = "";
            bool pass = false;
            bool isOpen = true;
            while (isOpen == true)
            {

                Console.WriteLine($"Name = {name}");
                if(password == "")
                {
                    Console.WriteLine($"Password = Empty");
                }
                else
                {
                    Console.WriteLine($"Password = yes");
                }

                Console.WriteLine("Ввдите цифру соответствующую выбранному пункту меню: \n 1) Ввести имя. \n 2) Ввести пароль. " +
                    "\n 3) Изменить цвет консоли. \n 4) Выход из программы.");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            bool exit = Password(pass, password);
                            if(exit == false)
                            {
                                isOpen = false;
                            }
                            name = Console.ReadLine(); 
                            break;
                        }
                    case 2:
                        {
                            Password(pass, password);
                            password = Console.ReadLine();
                            if(password != "")
                            {
                                pass = true;
                            }
                            break ;
                        }
                    case 3:
                        {
                            Password(pass, password);
                            Console.WriteLine("Нажмите цифру чтобы выбрать свет: 1) Красный. 2) Черный");
                            int input2 = int.Parse(Console.ReadLine());
                            if(input2 == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            if(input2 == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.WriteLine("Введены неверные данные.");
                            }
                            
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            isOpen = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введены неверные данные");
                            break;
                        }

                      
                }
                Console.Clear() ;
            }


        }

        static bool Password(bool pass, string password)
        {
            bool correct;
                if (pass == true)
                {
                    Console.WriteLine("Чтобы произвести изменения вам нужно ввести пароль.");
                    string inputPass = Console.ReadLine();
                    if (inputPass != password)
                    {
                        Console.WriteLine("Введены неверные данные.");
                        return correct = false;
                        
                    }
                    else
                    {
                        Console.WriteLine("Пароль введен верно.");
                        return correct = true;
                    }
                }
                else
                {
                    return correct = true;
                }
        }
    }
}

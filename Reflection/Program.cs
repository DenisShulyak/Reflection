using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1) Вывести методы класса Console");
                Console.WriteLine("2) Получить свойства и их значения из класса");
                Console.WriteLine("3) Вызвать метод Substring");
                Console.WriteLine("4) Выход");
                int act = int.Parse(Console.ReadLine());


                if (act == 1)
                {
                    Type cons = typeof(Console);
                    MethodInfo[] methArr = cons.GetMethods();
                    foreach (var item in methArr)
                    {
                        Console.Write($"{item.Name}(");
                        ParameterInfo[] p = item.GetParameters();
                        for (int i = 0; i < p.Length; i++)
                        {
                            Console.Write($"{p[i].ParameterType.Name} {p[i].Name}");
                            if (i + 1 < p.Length)
                                Console.Write(", ");
                        }
                        Console.WriteLine(") ");
                    }
                    Console.ReadLine();
                }
                else if (act == 2)
                {
                    Class cl = new Class();
                    Type t = typeof(Class);
                    FieldInfo[] fNames = t.GetFields();
                    foreach (var f in fNames)
                    {
                        Console.WriteLine($"{f.FieldType.Name} {f.Name} = {f.GetValue(cl)}");
                    }
                    Console.ReadLine();

                }
                else if (act == 3)
                {
                    Type t = typeof(String);
                    Type[] parameterTypes = { typeof(int) };
                    MethodInfo sub = t.GetMethod("Substring", parameterTypes);
                    Console.Write("Введите строку: ");
                    string str = Console.ReadLine();
                    Console.Write("Введите аргумент: ");
                    int arg = int.Parse(Console.ReadLine());
                    object[] arguments = { arg };
                    object returnValue = sub.Invoke(str, arguments);
                    Console.WriteLine(returnValue);
                    Console.ReadLine();

                }
               
                else if(act == 4)
                {
                    break;
                }

            }
            
           
            }
        }
    }


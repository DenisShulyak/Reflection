using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHomeWork
{
    class Class
    {
        public string _name = "Ivan";
        public string _surname = "Ivanov";
        public int _age = 23;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Имя: " + _name);
            Console.WriteLine("Фамилия: " + _surname);
            Console.WriteLine("Возраст: " + _age);
        }
    }
}
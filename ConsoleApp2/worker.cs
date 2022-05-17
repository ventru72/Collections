using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal struct worker
    {

        private string name;
        private string last_name;
        private int age;
        public string Name { get; set; }
        public string Last_name { get; set; }
        public int Age { get; set; }
        public worker(string name, string last_name, int age) : this()
        {
            Name = name;
            Last_name = last_name;
            Age = age;
        }
       

        public string  Print( )
        {
            return  $"Имя {Name}| Фамилия {Last_name}| Возвраст {Age}" ;
            
        }

    }
}

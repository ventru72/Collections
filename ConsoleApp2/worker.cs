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

        public int SomeProp { get; set; }

        public worker ( string name, string last_name, int age) : this()
        {
            this.name = name;
            this.last_name = last_name;
            this.age = age;
        }
        public worker(string name ) : this()
        {
            this.name = name;
            this.last_name = string.Empty;
            this.age = 0;
        }

    }
}

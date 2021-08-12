using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class Worker
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Position { get; set; }

        public Worker(string name, string surname, int age, int position)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
        }
    }
}

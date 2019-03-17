using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace report
{
    class RepositoryPerson
    {
        public static List<Person> Fill()
        {

            List<Person> list = new List<Person>()
            {
                new Person {name = "artem", age=23, company="sdfsd" },
                new Person {name = "Kate", age=22, company="ssdfsdfdfsdf" }
            };

            return list;
        }
    }
}

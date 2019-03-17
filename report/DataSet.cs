using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace report
{
    class DataSet
    {
        public List<Person> Fill()
        {

            List<Person> list = new List<Person>()
            {
                new Person {name = "artem", age=23, company="sdfsd" },
                 new Person {name = "anna", age=22, company="sarrr" },
                 new Person {name = "Anton", age=70, company="sdfsd" },
                 new Person {name = "Kate", age=21, company="mail" },
            };

            return list;
        }
    }
}

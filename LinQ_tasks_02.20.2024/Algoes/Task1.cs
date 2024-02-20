using LinQ_tasks_02._20._2024.Models.Bugal_ProgLang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_tasks_02._20._2024.Algoes
{
    public class Task1
    {
        public static List<Buxgalter> GetBuxgalters()
        {
            List<Buxgalter> buxgalters = new List<Buxgalter>
            {
                new Buxgalter{Id = 1,BName= "Alsh",ProgrammingLanguageId = 1},
                new Buxgalter{Id = 2,BName= "Vali",ProgrammingLanguageId = 1},
                new Buxgalter{Id = 3,BName= "G'oppor",ProgrammingLanguageId = 1},
                new Buxgalter{Id = 4,BName= "Umid",ProgrammingLanguageId = 2},
                new Buxgalter{Id = 5,BName= "Rocky",ProgrammingLanguageId = 2},
                new Buxgalter{Id = 6,BName= "Tommy",ProgrammingLanguageId = 3},
                new Buxgalter{Id = 6,BName= "Jon",ProgrammingLanguageId = 3}

            };
            return buxgalters;
        }
    }
}

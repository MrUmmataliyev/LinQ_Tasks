using LinQ_tasks_02._20._2024.Models.Bugal_ProgLang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_tasks_02._20._2024.Algoes
{
    public class Task2
    {
        public static void GetCSharpBuxgalters()
        {
            var langs=Task1.GetProgrammingLanguages();
            var buxgal=Task1.GetBuxgalters();

            var res = buxgal.Join(langs, bux => bux.ProgrammingLanguageId, lan => lan.Id,
            (bux, lan) => new { bux.Id, bux.BName, lan.Name }).Where(x=> x.Name == "C#");

            foreach (var buxgalger in res)
            {
                Console.WriteLine($"Buxgalter_ID:{buxgalger.Id}\nBuxgalter_name:{buxgalger.BName}\nProgramming_language_name:{buxgalger.Name}");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("");
            }
        }
    }
}

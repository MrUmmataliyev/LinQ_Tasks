using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LinQ_tasks_02._20._2024.Algoes
{
    public class Task3
    {
        public static void GetBuxgGroupByProgramLang()
        {
         var langs = Task1.GetProgrammingLanguages();
         var buxg = Task1.GetBuxgalters();
         var res = langs
                .GroupJoin(buxg, langs => langs.Id, buxg => buxg.ProgrammingLanguageId, 
                (langs, buxg) => new { langs, buxg });
         foreach (var bux in res)
         {
                Console.WriteLine(bux.langs.Name+" "+JsonConvert.SerializeObject(bux.buxg, Formatting.Indented));
         }
        
        }
    }
}

﻿using LinQ_tasks_02._20._2024.Algoes;
using LinQ_tasks_02._20._2024.Models.Bugal_ProgLang;

namespace LinQ_tasks_02._20._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (Buxgalter emp in Task1.GetBuxgalters())
            {
                Console.WriteLine($"{emp.Id} {emp.BName} {emp.ProgrammingLanguageId}");
            }
        }
    }
}

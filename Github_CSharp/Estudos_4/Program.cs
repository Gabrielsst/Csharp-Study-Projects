using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class ContaExercicio {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Ana");
            list.Add("Alex");
            list.Add("Antônia");
            list.Insert(1, "Nathan");

            Console.WriteLine(list.Find(x => x[1] == 'n'));
            Console.WriteLine(list.FindLast(x => x[1] == 'n'));
        }
    }
}
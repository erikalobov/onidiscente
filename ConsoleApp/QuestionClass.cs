using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void IterateNamesList()
        {
            int items = NamesList.Count;

            while (items != 0)
            {
                Console.WriteLine(NamesList[items-1]);
                items--;
            }
        }
    }
}

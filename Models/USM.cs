using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_4.Models
{
    public class USM
    {
        private static List<USPM> user_suggestions = new List<USPM>();

        public static IEnumerable<USPM> User_Suggestions => user_suggestions;

        public static void AddUS(USPM US)
        {
            user_suggestions.Add(US);
        }
    }
}

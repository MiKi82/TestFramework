using System.Linq;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace UnitTestProjectMs.Utils
{
    public static class TableExtentions
    {
        public static List<string> TabaleToString(Table table)
        {

            return table.Rows.Select(x => x.Values.FirstOrDefault()).ToList<string>();
        }
    }
}

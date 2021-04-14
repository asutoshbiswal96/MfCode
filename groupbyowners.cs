

using System.Collections.Generic;
using System.Linq;

namespace file
{
    public class FileOwners
    {
        public static object GroupByOwners(Dictionary<string, string> myDict)
        {
            var ownerdict = new Dictionary<string, List<string>>();
            List<KeyValuePair<string, string>> lst = myDict.ToList();
            for(int i=0;i<lst.Count;i++)
            {
                if (!ownerdict.ContainsKey(lst[i].Value))
                {
                    // No items for this key have been added, so create a new list
                    // for the value with item[1] as the only item in the list
                    ownerdict.Add(lst[i].Value, new List<string> { lst[i].Key });
                }
                else
                {
                    // This key already exists, so add item[1] to the existing list value
                    ownerdict[lst[i].Value].Add(lst[i].Key);
                }                
            }
            return ownerdict;
        }
        public static void Main()
        {
            Dictionary<string, string> myDict =   new Dictionary<string, string>();
            myDict.Add("'Input.txt", "Randy");
            myDict.Add("Code.py", "Stan");
            myDict.Add("Output.txt", "Randy");
            GroupByOwners(myDict);
        }
    }
}


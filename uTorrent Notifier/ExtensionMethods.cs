using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ExtensionMethods
{
    public static class Extensions
    {
        public static List<KeyValuePair<string, string>> Merge(this List<KeyValuePair<string, string>> major, 
            List<KeyValuePair<string, string>> defaults)
        {
            List<KeyValuePair<string, string>> merged = new List<KeyValuePair<string, string>>();

            foreach (KeyValuePair<string, string> kv in major)
            {
                KeyValuePair<string, string> found = defaults.Find(item => item.Key == kv.Key);

                if (found.Key != null)
                {
                    major.Add(found);
                }
            }
            return merged;
        }
    }
}
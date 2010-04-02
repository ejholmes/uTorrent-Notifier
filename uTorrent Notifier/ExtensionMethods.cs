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
            List<KeyValuePair<string, string>> updated = new List<KeyValuePair<string, string>>();

            updated.AddRange(defaults);

            foreach (KeyValuePair<string, string> kv in defaults)
            {
                KeyValuePair<string, string> found = major.Find(item => item.Key == kv.Key);

                if (found.Key != null)
                {
                    updated.Remove(kv);
                }
            }

            merged.AddRange(major);
            merged.AddRange(updated);

            return merged;
        }
    }
}
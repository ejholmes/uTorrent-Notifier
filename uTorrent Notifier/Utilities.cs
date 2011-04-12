using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uTorrentNotifier
{
    class Utilities
    {
        public static string FormatBytes(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "PB", "TB", "GB", "MB", "KB", "B" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 B";
        }
    }
}

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
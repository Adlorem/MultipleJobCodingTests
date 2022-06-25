using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleFileParser
{
    public static class Parser
    {
        public static string ChangeTime (string text, string pattern, TimeSpan shitTime)
        {
            if (string.IsNullOrEmpty(text)) return text;
            if (pattern is null)
            {
                throw new ArgumentNullException("Pattern cannot be null");
            }
            var matches = Regex.Matches(text, pattern);
            if (matches.Count() > 0)
            {
                var sb = new StringBuilder(text);
                foreach (var match in matches)
                {
                    if (match is not null)
                    {
                        var oldTime = match.ToString();
                        var newTime = ShiftTime(oldTime, shitTime);
                        sb.Replace(oldTime, newTime);
                    }
                }
                return sb.ToString();
            }
            return text;
        }

        private static string ShiftTime(string oldTime, TimeSpan shiftTime)
        {
            var currentTime = TimeSpan.Parse(oldTime);
            var newTime = currentTime.Add(shiftTime);
            return newTime.ToString("hh':'mm':'ss','fff");
        }
    }
}

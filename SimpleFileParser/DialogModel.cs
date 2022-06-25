using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileParser
{
    public record DialogModel
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public string[] Content { get; set; }
    }
}

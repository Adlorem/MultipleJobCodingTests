using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileParser
{
    public static class Splitter
    {
        // Chop array to chunks and create kind of model.
        public static IEnumerable<DialogModel> DialogSplit(string[] array)
        {
            var result = new List<DialogModel>();
            var skip = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                {                    
                    var chunk = array.Skip(skip).Take(i - skip).ToArray();
                    result.Add(CreateModel(chunk));
                    skip = i + 1;
                }
                else if (i == array.Length - 1)
                {
                    var chunk = array.Skip(skip).Take(i - skip + 1).ToArray();
                    result.Add(CreateModel(chunk));
                }
            }
            
            return result;
        }


        //Dirty model creation. Needs some validation at least. Good for this job though.
        private static DialogModel CreateModel(string[] chunk)
        {
            var model = new DialogModel();
            model.Id = int.Parse(chunk[0]);
            model.StartTime = TimeSpan.Parse(chunk[1].Take(12).ToArray());
            model.Content = chunk.Skip(1).ToArray();
            return model;
        }
    }
}

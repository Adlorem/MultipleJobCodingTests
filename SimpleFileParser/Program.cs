using SimpleFileParser;

//load original file
var lines = File.ReadLines(@".\SourceFile\napisy do filmu.srt");
var pattern = @"\d{0,2}(\:\d{0,2})(\:\d{0,2})(\,\d{0,3})?";
var shiftTime = new TimeSpan(0, 0, 0, 5, 880);

//shift time and write to new file
using (StreamWriter sw = new StreamWriter(@".\SourceFile\napisy do filmu shifted.srt"))
{
    foreach (var line in lines)
    {
        var newLine = Parser.ChangeTime(line, pattern, shiftTime);
        sw.WriteLine(newLine);
    }
}

//cut dialogs that start with round secounds reorder. Create separeted files with new numeration.

var shifted = File.ReadAllLines(@".\SourceFile\napisy do filmu shifted.srt");

//example soution. we can speed thing by moving whole thing to model.

var chunked = Splitter.DialogSplit(shifted);

var roundSeconds = chunked.Where(x => x.StartTime.Milliseconds == 0).ToList();

using (StreamWriter sw = new StreamWriter(@".\SourceFile\napisy do filmu shifted whole seconds.srt"))
{
    foreach (var item in roundSeconds)
    {
        sw.WriteLine(roundSeconds.IndexOf(item) + 1);
        foreach (var content in item.Content)
        {
            sw.WriteLine(content);
        }
        sw.WriteLine(String.Empty);      
    }
}

var withMilliseconds = chunked.Where(x => x.StartTime.Milliseconds != 0).ToList();

using (StreamWriter sw = new StreamWriter(@".\SourceFile\napisy do filmu shifted with milliseconds.srt"))
{
    foreach (var item in withMilliseconds)
    {
        sw.WriteLine(withMilliseconds.IndexOf(item) + 1);
        foreach (var content in item.Content)
        {
            sw.WriteLine(content);
        }
        sw.WriteLine(String.Empty);
    }
}


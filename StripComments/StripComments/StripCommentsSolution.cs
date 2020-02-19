using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        string[] v = text.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();
        var replaced = false;

        foreach (var line in v)
        {
            foreach (var sym in commentSymbols)
            {
                if (line.IndexOf(sym) > 0)
                {
                    sb.AppendLine(line.Substring(0, line.IndexOf(sym)).TrimEnd());
                    replaced = true;
                }
            }
            if (!replaced && !commentSymbols.Contains(line))
            {
                sb.AppendLine(line.TrimEnd());
            }
            replaced = false;
        }

        return sb.ToString().TrimEnd('\n');
    }
}
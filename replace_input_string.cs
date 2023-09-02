using System;

public class Program
{
    public static void Main()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = ExtractQuantity(input);
        string output = ProcessOutput(input);

        Console.WriteLine(quantity);
        Console.WriteLine(output);
    }

    private static string ExtractQuantity(string input)
    {
        return $"Quantity: {ExtractContentBetweenTags(input, "<span>", "</span>")}";
    }

    private static string ProcessOutput(string input)
    {
        string processed = input.Replace("&trade;", "&reg;");
        processed = RemoveTag(processed, "<div>");
        processed = RemoveTag(processed, "</div>");
        return $"Output: {processed}";
    }

    private static string ExtractContentBetweenTags(string input, string startTag, string endTag)
    {
        int startIndex = input.IndexOf(startTag) + startTag.Length;
        int endIndex = input.IndexOf(endTag);
        return input.Substring(startIndex, endIndex - startIndex);
    }

    private static string RemoveTag(string input, string tag)
    {
        int tagStart = input.IndexOf(tag);
        return input.Remove(tagStart, tag.Length);
    }
}

using System.Text.RegularExpressions;

namespace TextTransformer.Transformers;

[ShowcaseTransformer(TransformerCategories.Language)]
public class LyricsFormatter : ILinesTransformer
{
    public static LyricsFormatter Instance { get; set; } = new();

    // Thank you, ChatGPT; very cool
    private static readonly Regex wordPattern = new(@"\b\w+(?:[-']\w+)*\b");

    public string[] TransformLines(string[] lines)
    {
        return lines.Select(TransformLine).ToArray();
    }
    private static string TransformLine(string line)
    {
        var trimmedLine = line.Trim();

        var words = wordPattern.Matches(trimmedLine);
        int wordIndex = 0;
        var formattedLine = Transformations.ReplaceCaptures(trimmedLine, words, TransformWord);

        return formattedLine;

        string TransformWord(string word)
        {
            word = EnglishWordFormatter.Instance.Transform(word);

            if (wordIndex is 0)
            {
                word = FirstLetterCapitalizer.Instance.Transform(word);
            }

            wordIndex++;
            return word;
        }
    }
}

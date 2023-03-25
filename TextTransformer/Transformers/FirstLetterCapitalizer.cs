using Garyon.Extensions;

namespace TextTransformer.Transformers;

[ShowcaseTransformer(TransformerCategories.Language)]
public sealed class FirstLetterCapitalizer : ITextTransformer
{
    public static FirstLetterCapitalizer Instance { get; set; } = new();

    public string Transform(string text)
    {
        int wordStartIndex = WordUtilities.FirstLetterIndex(text);

        if (wordStartIndex == -1)
            return text;

        var left = text[..wordStartIndex];
        var right = text[(wordStartIndex + 1)..];
        char upper = text[wordStartIndex].ToUpper();
        return $"{left}{upper}{right}";
    }
}

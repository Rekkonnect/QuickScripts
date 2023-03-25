namespace TextTransformer.Transformers;

[ShowcaseTransformer(TransformerCategories.Language)]
public sealed class EnglishWordFormatter : ITextTransformer
{
    public static EnglishWordFormatter Instance { get; set; } = new();

    public string Transform(string text)
    {
        return Transformations.Transform(text,
                FixApostrophes,
                FixCapitalization,
                ExpandShortenedWords
            );
    }

    private static string FixCapitalization(string word)
    {
        if (word.StartsWith("i'"))
        {
            return FirstLetterCapitalizer.Instance.Transform(word);
        }

        return word switch
        {
            "i" => "I",
            _ => word,
        };
    }

    private static string ExpandShortenedWords(string word)
    {
        return word switch
        {
            "u" => "you",
            "ure" => "you're",
            "r" => "are",

            "sth" => "something",
            "sb" => "somebody",
            _ => word,
        };
    }

    private static string FixApostrophes(string word)
    {
        return word switch
        {
            "cant" => "can't",
            "dont" => "don't",
            "wont" => "won't",
            "wouldnt" => "wouldn't",
            "couldnt" => "couldn't",
            "shouldnt" => "shouldn't",
            "mustnt" => "mustn't",
            "neednt" => "needn't",

            "wouldve" => "would've",
            "couldve" => "could've",
            "shouldve" => "should've",

            "wouldntve" => "wouldn't've",
            "couldntve" => "couldn't've",
            "shouldntve" => "shouldn't've",

            "heres" => "here's",
            "theres" => "there's",

            "im" => "i'm",
            "ive" => "i've",
            "id" => "i'd",

            "youre" => "you're",
            "youve" => "you've",
            "youd" => "you'd",

            "hes" => "he's",
            "shes" => "she's",
            // DO NOT HANDLE ITS

            "theyre" => "they're",
            "theyve" => "they've",
            "theyd" => "they'd",

            "whos" => "who's",

            _ => word,
        };
    }
}

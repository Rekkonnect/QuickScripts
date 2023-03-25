using Garyon.Extensions;

namespace TextTransformer;

public static class WordUtilities
{
    public static int FirstLetterIndex(string text)
    {
        int wordStartIndex = 0;
        while (true)
        {
            if (wordStartIndex >= text.Length)
            {
                return -1;
            }

            if (text[wordStartIndex].IsLetter())
                break;

            wordStartIndex++;
        }

        return wordStartIndex;
    }
}

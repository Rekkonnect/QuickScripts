using System.Text.RegularExpressions;
using System.Text;

namespace TextTransformer;

public static class Transformations
{
    public static string Transform(string input, params StringTransformer[] transformers)
    {
        var result = input;
        foreach (var transformer in transformers)
        {
            result = transformer(result);
        }
        return result;
    }

    public static string TransformOrInput(this string input, StringTransformer? transformer)
    {
        if (transformer is null)
            return input;

        return transformer(input);
    }

    public static string ReplaceCaptures(string input, IEnumerable<Capture> captures, StringTransformer replacer)
    {
        var builder = new StringBuilder();
        int lastIndex = 0;
        foreach (var capture in captures)
        {
            int index = capture.Index;
            if (index > lastIndex)
            {
                builder.Append(input[lastIndex..index]);
            }
            var replacedCapture = replacer(capture.Value);
            builder.Append(replacedCapture);
            lastIndex = index + capture.Length;
        }
        if (lastIndex < input.Length)
        {
            builder.Append(input[lastIndex..]);
        }
        return builder.ToString();
    }
}

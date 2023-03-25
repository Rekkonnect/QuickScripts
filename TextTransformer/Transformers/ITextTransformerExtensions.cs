namespace TextTransformer.Transformers;

public static class ITextTransformerExtensions
{
    public static StringTransformer AsFunc(this ITextTransformer transformer)
    {
        return transformer.Transform;
    }
}

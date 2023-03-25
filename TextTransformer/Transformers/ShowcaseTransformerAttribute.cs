namespace TextTransformer.Transformers;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class ShowcaseTransformerAttribute : Attribute
{
    public string TransformerCategory { get; }

    public ShowcaseTransformerAttribute(string transformerCategory)
    {
        TransformerCategory = transformerCategory;
    }
}

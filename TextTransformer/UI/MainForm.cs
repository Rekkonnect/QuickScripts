using TextTransformer.Transformers;

namespace LyricFormatter;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        transformedTextBox.SynchronizeVScrollWith(sourceTextBox);
    }

    private void formatButton_Click(object sender, EventArgs e)
    {
        if (sourceTextBox.Text.Length <= 0)
            return;

        var lines = sourceTextBox.Lines;
        transformedTextBox.Lines = LyricsFormatter.Instance.TransformLines(lines);
    }
    private void copyToClipboardButton_Click(object sender, EventArgs e)
    {
        if (transformedTextBox.Text.Length > 0)
        {
            Clipboard.SetText(transformedTextBox.Text);
        }
    }
}